using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class AspNetUser : IdentityUser
    {
        public AspNetUser()
        {
            Zakazs = new HashSet<Zakaz>();
        }


        public string Address { get; set; }
        public string Passport { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<Zakaz> Zakazs { get; set; }
    }
}
