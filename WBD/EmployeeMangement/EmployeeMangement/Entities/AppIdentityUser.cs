using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Entities
{
    public class AppIdentityUser : IdentityUser
    {
        [MaxLength(300)]
        public string Address { get; set; }
        public bool Gender { get; set; }
    }
}
