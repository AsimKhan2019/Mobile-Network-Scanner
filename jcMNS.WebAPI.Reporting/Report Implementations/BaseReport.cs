using System;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

namespace jcMNS.WebAPI.Reporting.Report_Implementations {
    public abstract  class BaseReport {
        public abstract Guid ReportGUID();

        public abstract ReportResponseItem RunReport(Guid? objectGUID = null);
    }
}