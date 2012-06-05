using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Inspector.Web.Models;

namespace Inspector.Web.Controllers
{
    [OutputCache(Duration = 0, VaryByParam = "None")]
    public class FeatureUsageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AvailableFields()
        {
            var fields = new[]
                             {
                                 new PivotField{name = "Application",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Feature",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "UsedBy",type = "string",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "UsedAt",type = "date",filterable = true,columnLabelable = true,labelable = true},
                                 new PivotField{name = "Usage",type = "integer",summarizable  = "sum"}
                             };

            return Json(fields, JsonRequestBehavior.AllowGet);
        }

        public JsonResult FeatureUsage(FeatureUsageRequest request)
        {
            var usageString = new[]
                                  {
                                      new[]{"Application","Feature","Usage","UsedAt","UsedBy"},
                                      new[]{"Magnet","Home","1","2012-05-02","PARAPORT\\User1"},
                                      new[]{"Magnet","Home","1","2012-05-02","PARAPORT\\User2"},
                                      new[]{"Magnet","FX","1","2012-05-01","PARAPORT\\User2"},
                                      new[]{"Verona","Bias","1","2012-05-06","PARAPORT\\User1"},
                                  };

            return Json(usageString, JsonRequestBehavior.AllowGet);
        }
    }
}
