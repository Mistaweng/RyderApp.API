﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyderApp.Domain.Enitities
{
	public class AppUser : IdentityUser<Guid>
	{
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public Address Address { get; set; }
    }
}
