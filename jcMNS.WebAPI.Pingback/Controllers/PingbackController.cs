using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Pingback.Library.Transports;
using jcMNS.WebAPI.Pingback.Managers;

using Microsoft.AspNet.Mvc;

namespace jcMNS.WebAPI.Pingback.Controllers {
    public class PingbackController : BaseController {
        [HttpPost]
        public bool CreatePingback(PingBackRequestItem requestItem) => new PingBackManager().CreatePingBack(requestItem);
    }
}