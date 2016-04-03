using System;

namespace jcMNS.WebAPI.Pingback.DataLayer.EntityObjects.PingBacks {
    public class jcMNS_PingBacks {
        public int ID { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Modified { get; set; }

        public bool Active { get; set; }

        public Guid DeviceGUID { get; set; }

        public string Errors { get; set; }
    }
}