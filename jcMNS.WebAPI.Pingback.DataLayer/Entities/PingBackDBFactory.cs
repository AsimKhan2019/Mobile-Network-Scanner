using jcMNS.Library.DataLayer;
using jcMNS.WebAPI.Pingback.DataLayer.EntityObjects.PingBacks;

using Microsoft.Data.Entity;

namespace jcMNS.WebAPI.Pingback.DataLayer.Entities {
    public class PingBackDBFactory : EntityFactory {
        public DbSet<DevicePingBacks> PingBacks { get; set; } 
    }
}