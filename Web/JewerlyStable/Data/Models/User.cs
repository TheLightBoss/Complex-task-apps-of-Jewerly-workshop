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

        }


        public string Address { get; set; }
        public string Passport { get; set; }

    }
}
