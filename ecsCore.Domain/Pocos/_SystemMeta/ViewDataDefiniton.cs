using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecsCore.Domain.POCO
{
    public class ViewDataDefiniton
    {
        [Required]
        public bool IsViewable { get; set; }
        [Required]
        public bool IsEnabled { get; set; }
        [Required]
        public bool IsSearchable { get; set; }
        [Required]
        public bool IsEditable { get; set; }
        [Required]
        public bool IsDeleteable { get; set; }
        [Required]
        [StringLength(255)]
        public string NameInternal { get; set; }
        [Required]
        [StringLength(255)]
        public string NameUser { get; set; }
        [Required]
        [StringLength(255)]
        public string NameDisplay { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Expression { get; set; }
        [Required]
        public int ListsID { get; set; }
        [Required]
        public int ListItemsID { get; set; }
    }
}
