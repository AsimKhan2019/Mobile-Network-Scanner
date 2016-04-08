using System.Collections.Generic;
using System.Linq;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Reporting.DataLayer.Entities;
using jcMNS.WebAPI.Reporting.Library.Transports.ReportListing;

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
    }
}