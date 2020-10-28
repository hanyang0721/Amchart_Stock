# Amchart_Stock(under construction)

After You have clone the project
Look for Stock.sql file in the application root and run the script
Modify Your connection string in the webconfig to point to your sql server instance and your credential
Build and run the solution

Possible error
package error replace path in .csproj, 
<Import Project="..\packages\Microsoft.CodeDom.Provi remove .., !!! 
reload and unload, or use nuget console run Update-Package –reinstall
