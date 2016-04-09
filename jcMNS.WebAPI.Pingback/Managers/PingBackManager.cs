using System;

using jcMNS.Library.WebAPI;
using jcMNS.WebAPI.Pingback.DataLayer.Entities;
using jcMNS.WebAPI.Pingback.DataLayer.EntityObjects.PingBacks;
using jcMNS.WebAPI.Pingback.Library.Transports;

namespace jcMNS.WebAPI.Pingback.Managers {
    public class PingBackManager : BaseManager {
        public bool CreatePingBack(PingBackRequestItem requestItem) {
            using (var eFactory = new PingBackDBFactory()) {
                var nRow = new DevicePingBacks();

                nRow.Active = true;
                nRow.Created = DateTimeOffset.Now;
                nRow.Modified = DateTimeOffset.Now;
                nRow.DeviceGUID = requestItem.DeviceGUID;
                
                eFactory.PingBacks.Add(nRow);

                eFactory.SaveChanges();

                return true;
            }
        }
    }
}