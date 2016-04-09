using System;

using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

namespace jcMNS.WebAPI.Reporting.Report_Implementations {
    public class GetDevicePingBackReport :  BaseReport {
        public override Guid ReportGUID() => new Guid();

        public override ReportResponseItem RunReport(Guid? objectGUID = null) {
            return new ReportResponseItem();
        }
    }
}