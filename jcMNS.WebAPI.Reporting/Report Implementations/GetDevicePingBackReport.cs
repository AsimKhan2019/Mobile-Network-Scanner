using System;
using System.Linq;

using jcMNS.WebAPI.Pingback.DataLayer.Entities;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

namespace jcMNS.WebAPI.Reporting.Report_Implementations {
    public class GetDevicePingBackReport : BaseReport {
        public override Guid ReportGUID() => new Guid();

        public override string ReportFileName() {
            return $"DevicePingBack-{DateTime.Now}";
        }

        public override string ReportTitle() => "Device Ping Back History";

        public override void InitHeader() {
            AddHeader("Ping Back Time");
        }

        public override ReportResponseItem RunReport(Guid? objectGUID = null) {
            if (!objectGUID.HasValue) {
                return GetResponseItem();
            }

            using (var eFactory = new PingBackDBFactory()) {
                var rows = eFactory.PingBacks.Where(a => a.DeviceGUID == objectGUID.Value).OrderBy(b => b.Modified).ToList();
                
                return GenerateAndReturn(rows);
            }
        }
    }
}