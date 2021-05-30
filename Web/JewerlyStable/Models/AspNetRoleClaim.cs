using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

#nullable disable

namespace JewerlyStable
{
    public partial class AspNetRoleClaim : IdentityRoleClaim<string>
    {


        public virtual AspNetRole Role { get; set; }
    }
}
