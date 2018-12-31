using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTaa.Areas.Identity.Data
{
    public class ProjectTaaUser : IdentityUser
    {
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime DOB { get; set; }

        [PersonalData]
        public string State { get; set; }

        [PersonalData]
        public string LocalGovernment { get; set; }

        [PersonalData]
        public string PhoneNumber { get; set; }


    }
}
