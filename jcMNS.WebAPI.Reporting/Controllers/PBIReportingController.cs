﻿using System.Collections.Generic;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Reporting.Library.Transports.ReportListing;
using Microsoft.AspNet.Mvc;

namespace jcMNS.WebAPI.Reporting.Controllers {
    public class PBIReportingController : BaseController {
        [HttpGet]
        public List<ReportListingItem> GET() {
            return new List<ReportListingItem>();
        }
    }
}