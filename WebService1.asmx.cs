using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WcfService1
{
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public Boolean FindRestaurant(int area)
        {
            if (area < 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        [WebMethod]
        public String IsOpen(String isWeekend, String isFree)
        {
            if (Boolean.Parse(isFree) == true)
            {
                return "zatvorené";
            }
            else if (Boolean.Parse(isWeekend) == true)
            {
                return "8:00-12:00";
            }
            else
            {
                return "6:00 – 21:00";
            }
        }

    }
}
