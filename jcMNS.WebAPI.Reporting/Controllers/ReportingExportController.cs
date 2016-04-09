using System;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;
using jcMNS.WebAPI.Reporting.Managers;

using Microsoft.AspNet.Mvc;

namespace jcMNS.WebAPI.Reporting.Controllers {
    public class ReportingExportController : BaseController {
        private readonly ReportingManager _reportingManager;

        public ReportingExportController(ReportingManager reportingManager) { _reportingManager = reportingManager; }

        [HttpGet]
        public ReportExportResponseItem GET(Guid reportGUID, Guid? objectGUID = null)
            => _reportingManager.GetReportExport(reportGUID, objectGUID);
    }
}