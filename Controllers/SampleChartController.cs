using SampleChart.DataModel;
using SampleChart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleChart.Controllers
{
    public class SampleChartController : Controller
    {
        //create instance of datacontext
        SampleDbEntities db = new SampleDbEntities();

        // GET: SampleChart
        public ActionResult AmChartSample()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetChartData()
        {
            var model = db.Prices
                .ToList()
                .Select(m => new ChartDataDTO
                 {
                    Id=m.ID,
                    nopen=m.nopen.HasValue?m.nopen.Value:0,
                    nhigh= m.nhigh.HasValue ? m.nhigh.Value : 0,
                    nlow = m.nlow.HasValue ? m.nlow.Value : 0,
                    nclose = m.nclose.HasValue ? m.nclose.Value : 0,
                    nvol = m.nvol.HasValue ? m.nvol.Value : 0,
                    Date =m.Date.Value.ToString("yyyy-MM-dd")
                }).OrderBy(j=>j.Date).ToList();

            return Json(model.ToArray(), JsonRequestBehavior.AllowGet);
        }

    }
}