using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ecsCore.Domain.POCO
{
    public partial class _Meta : _Base
    {
        public _Meta()
        {
            IsDefault = false;
            IsPrimary = false;
            IsLocked = false;
            SortOrder = 0;
            Type = 0;
            SubType1 = 0;
            SubType2 = 0;
        }

        [Required]
        public bool IsDefault { get; set; }
        [Required]
        public bool IsPrimary { get; set; }
        [Required]
        public bool IsLocked { get; set; }
        [Required]
        public int SortOrder { get; set; }
        [Required]
        public int Type { get; set; }
        public int SubType1 { get; set; }
        public int SubType2 { get; set; }

    }
}
