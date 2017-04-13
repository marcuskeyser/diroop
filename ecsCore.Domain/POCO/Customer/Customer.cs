using System;
using System.Collections.Generic;
using System.Text;

namespace ecsCore.Domain.POCO
{
    public partial class Customer : _Meta
    {
        public int CustomerId { get; set; }
        public int EntityId { get; set; }
        public Entity Entity { get; set; } = new Entity();
    }
}
