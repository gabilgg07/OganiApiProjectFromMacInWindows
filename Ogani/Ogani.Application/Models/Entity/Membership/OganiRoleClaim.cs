using System;
using Microsoft.AspNetCore.Identity;

namespace Ogani.Application.Models.Entity.Membership
{
	public class OganiRoleClaim: IdentityRoleClaim<int>
    {
        public DateTime? CreatedDate { get; set; } = DateTime.Now;

        public DateTime? DeletedDate { get; set; }
    }
}

