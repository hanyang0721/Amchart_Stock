using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleChart.Models
{
    public class ChartDataDTO
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int nopen { get; set; }
        public int nhigh { get; set; }
        public int nlow { get; set; }
        public int nclose { get; set; }
        public int nvol { get; set; }

    }
}