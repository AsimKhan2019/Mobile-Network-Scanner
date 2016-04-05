using System;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Pingback.DataLayer.Entities;
using jcMNS.WebAPI.Pingback.DataLayer.EntityObjects.PingBacks;
using jcMNS.WebAPI.Pingback.Library.Transports;

namespace jcMNS.WebAPI.Pingback.Managers {
    public class PingBackManager : BaseManager {
        public bool CreatePingBack(PingBackRequestItem requestItem) {
            using (var eFactory = new PingBackDBFactory()) {
                var nRow = new jcMNS_PingBacks();

                nRow.Active = true;
                nRow.Created = DateTimeOffset.Now;
                nRow.Modified = DateTimeOffset.Now;
                nRow.DeviceGUID = requestItem.DeviceGUID;
                nRow.Errors = requestItem.Telemetry;

                eFactory.PingBacks.Add(nRow);

                eFactory.SaveChanges();

                return true;
            }
        }
    }
}