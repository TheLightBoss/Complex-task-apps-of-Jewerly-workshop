using System;
using System.Collections.Generic;
using JewerlyStable.Data;
using Microsoft.AspNetCore.Identity;

#nullable disable

namespace JewerlyStable
{
    public partial class AspNetUserLogin : IdentityUserLogin<string>
    {

        public virtual User User { get; set; }
    }
}
