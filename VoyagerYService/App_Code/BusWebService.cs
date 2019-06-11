using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VoyagerYBusiness;

/// <summary>
/// Summary description for BusWebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class BusWebService : System.Web.Services.WebService
{

    public BusWebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public List<Bus> GetBuses()
    {
        App app = new App();
        return app.busService.GetAll().ToList<Bus>();
    }

}
