using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecsCore.Domain.POCO
{
    public partial class EntityName  :  _Meta
    {
        [ForeignKey("EntityId")]
        public Entity Entity { get; set; }
        [Required]
        public int EntityId { get; set; }
        [Required]
        public int NameType { get; set; }

        [Required]
        [StringLength(255)]
        public string Last { get; set; }

        [StringLength(255)]
        public string First { get; set; }

        [StringLength(50)]
        public string Middle { get; set; }

        [StringLength(5)]
        public string Salutation { get; set; }

        [StringLength(5)]
        public string Prefix { get; set; }

        [StringLength(5)]
        public string Suffix { get; set; }

        [StringLength(50)]
        public string Title { get; set; }
    }
}
