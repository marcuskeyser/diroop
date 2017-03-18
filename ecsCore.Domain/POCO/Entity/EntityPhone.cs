using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecsCore.Domain.POCO
{
    public partial class EntityPhone  :  _Meta
    {
        [ForeignKey("EntityId")]
        public Entity Entity { get; set; }
        [Required]
        public int EntityId { get; set; }
        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
    }
}
