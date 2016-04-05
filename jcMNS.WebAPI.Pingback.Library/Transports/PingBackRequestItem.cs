using System;

namespace jcMNS.WebAPI.Pingback.Library.Transports {
    public class PingBackRequestItem {
        public Guid DeviceGUID { get; set; }

        public string Telemetry { get; set; }
    }
}