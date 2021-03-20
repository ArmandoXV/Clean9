using System;
using Microsoft.AspNetCore.Identity;

namespace Clean9.Web.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the Clean9WebUser class
    public class Clean9WebUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
