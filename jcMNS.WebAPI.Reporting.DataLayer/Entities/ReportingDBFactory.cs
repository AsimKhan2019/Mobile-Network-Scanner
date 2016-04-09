using jcMNS.Library.DataLayer;
using jcMNS.WebAPI.Reporting.DataLayer.EntityObjects.Reporting;

using Microsoft.Data.Entity;

namespace jcMNS.WebAPI.Reporting.DataLayer.Entities {
    public class ReportingDBFactory : EntityFactory {
        public DbSet<REPORTING_getActiveReportsSP> ListingItems { get; set; }

        public DbSet<Reports> Report { get; set; }
    }
}