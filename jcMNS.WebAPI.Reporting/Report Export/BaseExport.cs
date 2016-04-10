using System.Text;

using jcMNS.WebAPI.Reporting.Library.Enums;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

namespace jcMNS.WebAPI.Reporting.Report_Export {
    public abstract class BaseExport {
        public abstract ExportTypes GetExportType();

        public abstract string GetFileExtension();

        internal abstract byte[] generateExportData(ReportResponseItem data);
        
        public ReportExportResponseItem GenerateExport(ReportResponseItem data) {
            var responseItem = new ReportExportResponseItem {
                FileName = $"{data.Title}.{GetFileExtension()}",
                Data = generateExportData(data)
            };
            
            return responseItem;
        }

        internal byte[] convertStringToBytes(string data) {
            return Encoding.ASCII.GetBytes(data);
        }
    }
}