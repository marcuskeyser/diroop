using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecsCore.Domain.POCO
{
    public partial class EntitySocialMedia :  _Meta
    {
        [ForeignKey("EntityId")]
        public Entity Entity { get; set; }
        [Required]
        public int EntityId { get; set; }
        [Required]
        [StringLength(255)]
        public string Url { get; set; }
        [Required]
        [StringLength(255)]
        public string Login { get; set; }
        [Required]
        [StringLength(255)]
        public string PW { get; set; }

    }
}
