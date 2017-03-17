using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecsCore.Domain.POCO
{
    public partial class EntityCreditCard  :  _Meta
    {
        [ForeignKey("EntityId")]
        public Entity Entity { get; set; }
        [Required]
        public int EntityId { get; set; }
        [Required]
        [StringLength(50)]
        public string CC { get; set; }
        [Required]
        [StringLength(2)]
        public string ExpirationMonth { get; set; }
        [Required]
        [StringLength(4)]
        public string ExpirationYear { get; set; }
        [Required]
        [StringLength(10)]
        public int Code { get; set; }
    }
}
