using System.Collections.Generic;

namespace jcMNS.WebAPI.Reporting.Library.Transports.Reports {
    public class ReportResponseItem {
        public string Title { get; set; }

        public List<string> Headers { get; set; }

        public List<ReportDataRow> Rows { get; set; }

        public ReportResponseItem() {
            Title = string.Empty;

            Headers = new List<string>();

            Rows = new List<ReportDataRow>();
        }
    }
}