using jcMNS.Library.WebAPI;

using Microsoft.AspNet.Mvc;

namespace jcMNS.WebAPI.Reporting.Controllers {
    public class PBIReportingController : BaseController
    {
        [HttpGet]
        public string GET()
        {
            return "test";
        }
    }
}