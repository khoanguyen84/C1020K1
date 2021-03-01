using EmployeeMangement.Entities;
using EmployeeMangement.Models.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMangement.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppIdentityUser> userManager;

        public AccountController(UserManager<AppIdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        //[AcceptVerbs("GET", "Post)]
        public IActionResult Login(LoginModel model)
        {
            //check user is exist
            //if exist => dashboard
            //else show error
            if(model.Email == "khoa.nguyen@codegym.vn" && model.Password == "123456")
            {
                return RedirectToAction(actionName: "Index", controllerName: "Dashboard");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new AppIdentityUser()
                {
                    Email = model.Email,
                    UserName = model.Email
                };
                var result =  await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return View();
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View();
            }
            return View();
        }

        public async Task<IActionResult> EmailInUse(string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
                return Json(true);
            return Json($"{email} already existing.");
        }
    }
}
