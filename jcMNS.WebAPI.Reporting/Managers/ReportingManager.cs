using System;
using System.Collections.Generic;   
using System.Linq;
using System.Reflection;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Reporting.DataLayer.Entities;
using jcMNS.WebAPI.Reporting.Library.Transports.ReportListing;
using jcMNS.WebAPI.Reporting.Library.Transports.Reports;
using jcMNS.WebAPI.Reporting.Report_Implementations;

namespace jcMNS.WebAPI.Reporting.Managers {
    public class ReportingManager : BaseManager {
        public List<ReportListingItem> GetListing() {
            using (var eFactory = new ReportingDBFactory()) {
                return eFactory.ListingItems.ToList().Select(a => new ReportListingItem {
                    Name = a.Description,
                    ReportGUID = a.GUID
                }).ToList();
            }
        }

        public ReportResponseItem GetReport(Guid reportGuid, Guid? objectGuid) {
            var assemblyTypes = Assembly.Load(typeof(ReportingManager).GetTypeInfo().Assembly.GetName()).GetTypes();

            foreach (var type in assemblyTypes) {
                if (type.DeclaringType != typeof (BaseReport)) {
                    continue;
                }

                var report = (BaseReport)Activator.CreateInstance(type);

                if (report.ReportGUID() == reportGuid) {
                    return report.RunReport(objectGuid);
                }
            }

            return null;
        }
    }
}