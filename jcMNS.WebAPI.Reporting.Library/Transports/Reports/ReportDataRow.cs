using System.Collections.Generic;

namespace jcMNS.WebAPI.Reporting.Library.Transports.Reports {
    public class ReportDataRow {
        public List<ReportDataCell> DataRowCells { get; set; }

        public void AddCell(ReportDataCell dataCell) {
            DataRowCells.Add(dataCell);
        }

        public ReportDataRow() {
            DataRowCells = new List<ReportDataCell>();
        }
    }
}