using jcMNS.WebAPI.Reporting.Library.Enums;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

namespace jcMNS.WebAPI.Reporting.Report_Export {
    public class CSVExport : BaseExport {
        public override ExportTypes GetExportType() => ExportTypes.CSV;

        public override string GetFileExtension() => "csv";

        internal override byte[] generateExportData(ReportResponseItem data) {
            var str = string.Empty;

            str += string.Join(",", data.Headers);

            str += string.Join(",", data.Rows);

            return convertStringToBytes(str);
        }
    }
}