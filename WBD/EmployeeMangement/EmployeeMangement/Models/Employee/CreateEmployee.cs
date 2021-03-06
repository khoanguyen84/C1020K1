﻿using EmployeeMangement.Models.Department;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Models.Employee
{
    public class CreateEmployee : ViewEmployee
    {
        public IFormFile Avatar { get; set; }
        public List<DepartmentView> Departments { get; set; }
    }
}
