using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace JewerlyStable.Data
{
    public partial class User : IdentityUser
    {
        public User()
        {
            //Zakazs = new HashSet<Zakaz>();
        }


        public string Address { get; set; }
        public string Passport { get; set; }
        //public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        //public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        //public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        //public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        //public virtual ICollection<Zakaz> Zakazs { get; set; }

    }
}
//public partial class AspNetUser
//{
//    public AspNetUser()
//    {
//        AspNetUserClaims = new HashSet<AspNetUserClaim>();
//        AspNetUserLogins = new HashSet<AspNetUserLogin>();
//        AspNetUserRoles = new HashSet<AspNetUserRole>();
//        AspNetUserTokens = new HashSet<AspNetUserToken>();
//        Zakazs = new HashSet<Zakaz>();
//    }

//    public string Address { get; set; }
//    public string Passport { get; set; }

//    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
//    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
//    public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
//    public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
//    public virtual ICollection<Zakaz> Zakazs { get; set; }
//}
//}

