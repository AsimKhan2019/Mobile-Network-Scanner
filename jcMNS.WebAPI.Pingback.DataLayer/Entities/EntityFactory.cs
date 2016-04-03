using jcMNS.WebAPI.Pingback.DataLayer.EntityObjects.PingBacks;

using Microsoft.Data.Entity;

namespace jcMNS.WebAPI.Pingback.DataLayer.Entities {
    public class EntityFactory : DbContext {
        public DbSet<jcMNS_PingBacks> PingBacks { get; set; } 
    }
}