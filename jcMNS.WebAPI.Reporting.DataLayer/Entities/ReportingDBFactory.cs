using jcMNS.Library.DataLayer;
using jcMNS.WebAPI.Reporting.Library.Transports.ReportListing;

using Microsoft.Data.Entity;

namespace jcMNS.WebAPI.Reporting.DataLayer.Entities {
    public class ReportingDBFactory : EntityFactory {
        public DbSet<ReportListingItem> ListingItems { get; set; }
    }
}