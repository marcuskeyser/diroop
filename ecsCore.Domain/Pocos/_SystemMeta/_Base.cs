using System;
using System.ComponentModel.DataAnnotations;
using ecsCore.System;

namespace ecsCore.Domain.POCO
{
    public partial class _Base : ClientChangeTracker
    {
        public _Base() {
            Guid = Guid.NewGuid();
            IsDeleted = false;
            LastEditUserId = System.Constants.USER_ID;
            CreateUserId = System.Constants.USER_ID;
            LastEditDate = DateTime.Now;
            CreateDate = DateTime.Now;
            SystemOwnerID = 1;
    }
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public Guid Guid { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public int LastEditUserId { get; set; }
        [Required]
        public int CreateUserId { get; set; }
        [Required]
        public DateTime LastEditDate { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public int SystemOwnerID { get; set; }
        public string DebugToken { get; set; }
    }
}
