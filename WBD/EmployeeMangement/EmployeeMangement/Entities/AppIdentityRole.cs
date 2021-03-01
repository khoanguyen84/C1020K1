using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class AppIdentityRole : IdentityRole
    {
        public bool IsActive { get; set; }
    }
}
