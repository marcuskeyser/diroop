using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ecsCore.Domain.POCO
{
    public partial class Entity :  _Meta
    {
        [Required]
        public int SecurityType { get; set; }

        public List<EntityAddress> Addresses { get; set; } = new List<EntityAddress>();
        public List<EntityCreditCard> CreditCards { get; set; } = new List<EntityCreditCard>();
        public List<EntityEmail> Emails { get; set; } = new List<EntityEmail>();
        public List<EntityName> Names { get; set; } = new List<EntityName>();
        public List<EntityPhone> Phones { get; set; } = new List<EntityPhone>();
        public List<EntitySocialMedia> SocialMedia { get; set; } = new List<EntitySocialMedia>();
        public List<EntityRelationship> Relationships { get; set; } = new List<EntityRelationship>();

    }
}
