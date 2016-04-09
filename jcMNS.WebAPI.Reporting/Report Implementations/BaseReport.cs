using System;
using System.Collections.Generic;
using System.Reflection;

using jcMNS.WebAPI.Reporting.Library.Transports.Reports;

namespace jcMNS.WebAPI.Reporting.Report_Implementations {
    public abstract  class BaseReport {
        private ReportResponseItem _reportResponseItem;

        public abstract Guid ReportGUID();

        public abstract ReportResponseItem RunReport(Guid? objectGUID = null);

        public abstract string ReportTitle();

        public abstract void InitHeader();

        protected BaseReport() {
            InitResponseItem();
        }

        public void InitResponseItem() {
            _reportResponseItem = new ReportResponseItem {Title = ReportTitle()};

            InitHeader();
        }

        public void AddHeader(string headerName) {
            _reportResponseItem.Headers.Add(headerName);
        }

        public void AddRow(ReportDataRow row) {
            _reportResponseItem.Rows.Add(row);
        }

        protected void CreateRows<T>(List<T> rows) {
            foreach (var row in rows) {
                CreateRow(row);
            }
        }

        protected void CreateRow<T>(T row) {
            var reportRow = new ReportDataRow();

            foreach (var property in row.GetType().GetProperties()) {
                var cell = new ReportDataCell {
                    DataValue = property.GetValue(row),
                    DataType = property.PropertyType
                };

                reportRow.AddCell(cell);
            }
        }

        protected ReportResponseItem GenerateAndReturn<T>(List<T> rows) {
            CreateRows(rows);

            return GetResponseItem();
        }

        public ReportResponseItem GetResponseItem() => _reportResponseItem;
    }
}