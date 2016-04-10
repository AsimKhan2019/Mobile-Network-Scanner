using jcMNS.WebAPI.Reporting.Library.Enums;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

using Newtonsoft.Json;

namespace jcMNS.WebAPI.Reporting.Report_Export {
    public class JSONExport : BaseExport {
        public override ExportTypes GetExportType() => ExportTypes.JSON;

        public override string GetFileExtension() => "json";

        internal override byte[] generateExportData(ReportResponseItem data) => convertStringToBytes(JsonConvert.SerializeObject(data));
    }
}