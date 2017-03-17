using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecsCore.Domain.POCO
{
    public partial class EntityAddress  :  _Meta
    {
        [ForeignKey("EntityId")]
        public Entity Entity { get; set; }
        [Required]
        public int EntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string Address1 { get; set; }
        [StringLength(255)]
        public string Address2 { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string State { get; set; }
        [Required]
        [StringLength(50)]
        public string Country { get; set; }
        [Required]
        [StringLength(50)]
        public string PostalCode { get; set; }
    }
}
