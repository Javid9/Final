using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    public class JobController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        public JobController(AppDbContext context, IWebHostEnvironment env
            , UserManager<AppUser> userManager, RoleManager<IdentityRole> rolemanager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
            _rolemanager = rolemanager;
        }
       

        public IActionResult Index(int? page)
        {

            //ViewBag.Time = DateTime.Now.Minute;
            
            ViewBag.PageCount = Math.Ceiling((decimal)_context.Jobs.Count() / 5);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.Jobs.Where(x=>x.isActivated== true).OrderByDescending(p => p.Id).Take(5).Include(c => c.Category)
                .Include(c => c.Country).Include(c=>c.City).Include(x => x.AppUser).ToList());
            }
            else
            {
                return View(_context.Jobs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 4)
                 .Take(4).Include(c => c.Category)
                .Include(c => c.Country).Include(c => c.City).Include(x=>x.AppUser).ToList());
            }

            //if (page == null)
            //{
            //    return View(_context.Jobs.Include(p => p.Category).OrderByDescending(p => p.Id).Take(5).ToList());
            //}
            //else
            //{
            //    return View(_db.Products.Include(p => p.Category).OrderByDescending(p => p.Id).Skip(((int)page - 1) * 5).Take(5).ToList());
            //}
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index( string userId)
        {
            TempData["lorem"] = userId;
            return RedirectToAction(nameof(Apply));
        }



        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Apply()
        {
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "CityName");
            ViewBag.State = new SelectList(_context.States.ToList(), "Id", "StateName");
            ViewBag.Country = new SelectList(_context.Countries.ToList(), "Id", "CountryName");
            ViewBag.EducationLevel = new SelectList(_context.EducationLevels.ToList(), "Id", "Level");
            ViewBag.Location = new SelectList(_context.Loactions.ToList(), "Id", "Locationn");
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Apply(Apply apply, string General, string Status)
        {
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "CityName");
            ViewBag.State = new SelectList(_context.States.ToList(), "Id", "StateName");
            ViewBag.Country = new SelectList(_context.Countries.ToList(), "Id", "CountryName");
            ViewBag.EducationLevel = new SelectList(_context.EducationLevels.ToList(), "Id", "Level");
            ViewBag.Location = new SelectList(_context.Loactions.ToList(), "Id", "Locationn");
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!apply.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (apply.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "apply");
            string fileName = await apply.Photo.SaveImg(_env.WebRootPath, path);
           

            Apply newApply = new Apply
            {
                Firstname = apply.Firstname,
                MiddleName = apply.MiddleName,
                Surname = apply.Surname,
                Date = apply.Date,
                General = General,
                Status = Status,
                Phone = apply.Phone,
                Email = apply.Email,
                Website = apply.Website,
                Address = apply.Address,
                CityId = apply.CityId,
                StateId = apply.StateId,
                CountryId = apply.CountryId,
                GraduationDate = apply.GraduationDate,
                StartUniversity=apply.StartUniversity,
                UniversityName = apply.UniversityName,
                Degree = apply.Degree,
                CourseTitle = apply.CourseTitle,
                EducationInformation = apply.EducationInformation,
                EducationLevelId = apply.EducationLevelId,
                CompanyName = apply.CompanyName,
                JobPosition = apply.JobPosition,
                StartCompanyDate= apply.StartCompanyDate,
                EndCompanyDate = apply.EndCompanyDate,
                ExperienceInformation = apply.ExperienceInformation,
                LocationId = apply.LocationId,
                Skills = apply.Skills,
                AboutMe=apply.AboutMe,
                Instagram=apply.Instagram,
                Facebook=apply.Facebook,
                Twitter=apply.Twitter,
                Google=apply.Google,
                CategoryId=apply.CategoryId,
                AppUserId = TempData["lorem"].ToString(),
            };
            newApply.Image = fileName;
           
            await _context.Applies.AddAsync(newApply);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
            

        }


    }
}
