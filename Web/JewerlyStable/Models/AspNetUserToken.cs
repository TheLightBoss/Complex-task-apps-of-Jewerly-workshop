using JewerlyStable.Data;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace JewerlyStable
{
    public partial class AspNetUserToken : IdentityUserToken<string>
    {


        public virtual User User { get; set; }
    }
}
