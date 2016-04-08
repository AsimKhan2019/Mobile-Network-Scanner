using System;

namespace jcMNS.Library.DataLayer {
    public class BaseTableObject {
        public Guid GUID { get; set; }

        public DateTimeOffset Modified { get; set; }

        public DateTimeOffset Created { get; set; }

        public bool Active { get; set; }
    }
}