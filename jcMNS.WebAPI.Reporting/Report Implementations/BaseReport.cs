using System;
using System.Collections.Generic;
using System.Reflection;

using jcMNS.WebAPI.Reporting.Library.Enums;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;
using jcMNS.WebAPI.Reporting.Report_Export;

namespace jcMNS.WebAPI.Reporting.Report_Implementations {
    public abstract class BaseReport {
        private ReportResponseItem _reportResponseItem;

        public abstract Guid ReportGUID();

        public abstract ReportResponseItem RunReport(Guid? objectGUID = null);

        public abstract string ReportFileName();

        public abstract string ReportTitle();

        public abstract void InitHeader();

        protected BaseReport() {
            InitResponseItem();
        }

        public void InitResponseItem() {
            _reportResponseItem = new ReportResponseItem { Title = ReportTitle() };

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
        
        private BaseExport getReportExport(ExportTypes exportType) {
            var assemblyTypes = Assembly.Load(typeof(BaseExport).GetTypeInfo().Assembly.GetName()).GetTypes();

            foreach (var type in assemblyTypes) {
                if (type.DeclaringType != typeof(BaseExport)) {
                    continue;
                }

                var baseExport = (BaseExport)Activator.CreateInstance(type);

                if (baseExport.GetExportType() == exportType) {
                    return baseExport;
                }
            }

            return null;
        }

        public ReportExportResponseItem GenerateExport(ExportTypes exportType, Guid? objectGUID = null) {
            var data = RunReport(objectGUID);

            var export = getReportExport(exportType);

            if (export == null) {
                throw new Exception($"No Export Implementation for {exportType}");
            }

            return export.GenerateExport(data);
        }

        protected ReportResponseItem GenerateAndReturn<T>(List<T> rows) {
            CreateRows(rows);

            return GetResponseItem();
        }

        public ReportResponseItem GetResponseItem() => _reportResponseItem;
    }
}