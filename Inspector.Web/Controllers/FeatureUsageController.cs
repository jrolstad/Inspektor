using System.Collections.Generic;
using System.Web.Mvc;
using Inspector.Web.Models;
using Inspektor;
using Inspektor.Entities;
using Newtonsoft.Json;

namespace Inspector.Web.Controllers
{
    [OutputCache(Duration = 0, VaryByParam = "None")]
    public class FeatureUsageController : Controller
    {
        private readonly ICommand<string, IEnumerable<PivotField>> _getPivotFieldsCommand;
        private readonly ICommand<FeatureUsageRequest, IEnumerable<string[]>> _getFeatureUsageCommand;
        private readonly IMapper<FeatureUsageWebRequest, FeatureUsageRequest> _featureUsageRequestMapper;

        /// <summary>
        /// Constructor with dependencies
        /// </summary>
        /// <param name="getPivotFieldsCommand"></param>
        /// <param name="getFeatureUsageCommand"></param>
        /// <param name="featureUsageRequestMapper"></param>
        public FeatureUsageController(
            ICommand<string,IEnumerable<PivotField>> getPivotFieldsCommand,
            ICommand<FeatureUsageRequest, IEnumerable<string[]>> getFeatureUsageCommand,
            IMapper<FeatureUsageWebRequest,FeatureUsageRequest> featureUsageRequestMapper
            )
        {
            _getPivotFieldsCommand = getPivotFieldsCommand;
            _getFeatureUsageCommand = getFeatureUsageCommand;
            _featureUsageRequestMapper = featureUsageRequestMapper;
        }

        /// <summary>
        /// Shows the main index view page
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Obtains available fields for the view
        /// </summary>
        /// <returns></returns>
        public JsonResult AvailableFields()
        {
            var fields = _getPivotFieldsCommand.Execute(null);

            return Json(fields, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Obtains usage details for the given parameters in the request
        /// </summary>
        /// <param name="webRequest"></param>
        /// <returns></returns>
        public ContentResult FeatureUsage(FeatureUsageWebRequest webRequest)
        {
            var request = _featureUsageRequestMapper.Map(webRequest);
            var usage = _getFeatureUsageCommand.Execute(request);
            var json = JsonConvert.SerializeObject(usage);

            return Content(json, "application/json");
        }
    }
}
