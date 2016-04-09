using System;
using System.Collections.Generic;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Reporting.Library.Transports.ReportListing;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;
using jcMNS.WebAPI.Reporting.Managers;

using Microsoft.AspNet.Mvc;

namespace jcMNS.WebAPI.Reporting.Controllers {
    public class ReportingController : BaseController {
        private readonly ReportingManager _reportingManager;

        public ReportingController(ReportingManager reportingManager) { _reportingManager = reportingManager; }

        [HttpGet]
        public List<ReportListingItem> GET() => _reportingManager.GetListing();

        [HttpGet]
        public ReportResponseItem GET(Guid reportGUID, Guid? objectGUID = null) => _reportingManager.GetReport(reportGUID, objectGUID);
    }
}