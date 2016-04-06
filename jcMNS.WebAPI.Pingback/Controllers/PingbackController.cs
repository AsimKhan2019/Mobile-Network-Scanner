using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Pingback.Library.Transports;
using jcMNS.WebAPI.Pingback.Managers;

using Microsoft.AspNet.Mvc;

namespace jcMNS.WebAPI.Pingback.Controllers {
    public class PingbackController : BaseController {
        private readonly PingBackManager _manager;

        public PingbackController(PingBackManager pingbackManger) { _manager = pingbackManger; }

        [HttpPost]
        public bool CreatePingback(PingBackRequestItem requestItem) => _manager.CreatePingBack(requestItem);
    }
}