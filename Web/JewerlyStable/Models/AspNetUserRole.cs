using System;
using System.Collections.Generic;
using JewerlyStable.Data;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace JewerlyStable
{
    public partial class AspNetUserRole : IdentityUserRole<string>
    {


        public virtual AspNetRole Role { get; set; }
        public virtual User User { get; set; }
    }
}
