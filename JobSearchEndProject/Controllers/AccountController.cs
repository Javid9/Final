using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.Models;
using JobSearchEndProject.ViewModels;
using JobSearchEndProject.ViewModels.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager,SignInManager<AppUser>
                                    signInManager, RoleManager<IdentityRole> roleManager)
        {

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
                    return RedirectToAction("Index", "Job");
                }
            }


            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid) return View();
            AppUser appUser = new AppUser
            {
                FullName = registerVM.Fullname,
                UserName = registerVM.Username,
                Email = registerVM.Email,

            };

            IdentityResult identityResult = await _userManager.CreateAsync(appUser, registerVM.Password);
            return View();
        }
    }
}
