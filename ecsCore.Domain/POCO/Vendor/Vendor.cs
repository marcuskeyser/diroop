using System;
using System.Collections.Generic;
using System.Text;

namespace ecsCore.Domain.POCO
{
    public partial class Vendor: _Meta
    {
        public int VendorId { get; set; }
        public int EntityId { get; set; }
        public Entity Entity { get; set; } = new Entity ();
    }
}
