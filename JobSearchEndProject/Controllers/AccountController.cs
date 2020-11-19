using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.Helpers;
using JobSearchEndProject.Models;
using JobSearchEndProject.ViewModels;
using JobSearchEndProject.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
namespace JobSearchEndProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager,
                                  SignInManager<AppUser> signInManager,
                                  RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

       
       

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) return View();

            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
            if(loginUser == null)
            {
                ModelState.AddModelError("", "Email or password wrong!!");
                return View(login);
            }

            if (!loginUser.isActivated)
            {
                ModelState.AddModelError("", "Your transaction has been blocked");
                return View(login);
            }

            var signInResult = await _signInManager.PasswordSignInAsync(loginUser,login.Password,login.RemmeberMe,true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "The account is locked out!");
                return View(login);
            }

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!");
                return View(login);
            }

            var role = await _userManager.GetRolesAsync(loginUser);

            foreach (var item in role)
            {
                if(item == "Admin")
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });

                }
            }

            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }



        public  IActionResult Register()
        {
            List<IdentityRole> allroles = _roleManager.Roles.ToList();
            List<IdentityRole> roles = new List<IdentityRole>();
            foreach (var item in allroles)
            {
                if (item.Name != "Admin")
                {
                    roles.Add(item);
                }
            }

            ViewBag.allRoles = new SelectList(roles, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM, string role)
        {
            List<IdentityRole> allroles = _roleManager.Roles.ToList();
            List<IdentityRole> roles = new List<IdentityRole>();
            foreach (var item in allroles)
            {
                if (item.Name != "Admin")
                {
                    roles.Add(item);
                }
            }

            ViewBag.allRoles = new SelectList(roles, "Id", "Name");



            if (!ModelState.IsValid) return View();
            AppUser newUser = new AppUser
            {
                FullName = registerVM.Fullname,
                UserName = registerVM.Username,
                Email = registerVM.Email,
            };
            
            IdentityResult identityResult = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
                return View(registerVM);
            }
            newUser.isActivated = true;
            IdentityRole dbRole = await _roleManager.FindByIdAsync(role);
            //await _userManager.AddToRoleAsync(newUser, Helper.Role.Admin.ToString());
            //await _userManager.AddToRoleAsync(newUser, "Employer");
            //await _userManager.AddToRoleAsync(newUser, "Employe
            
   
            await _userManager.AddToRoleAsync(newUser, dbRole.Name);
           

            await _signInManager.SignInAsync(newUser, true);

            if (dbRole.ToString() == "Employee")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Create", "Employer");
            }

            
            
        }


        //public async Task CreateRole()
        //{
        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    }
        //    if (!await _roleManager.RoleExistsAsync("Employer"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Employer" });
        //    }
        //    if (!await _roleManager.RoleExistsAsync("Employee"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Employee" });
        //    }
        //}



    }
}
