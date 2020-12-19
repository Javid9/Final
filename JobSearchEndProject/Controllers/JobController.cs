using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using JobSearchEndProject.Services.Dto;
using JobSearchEndProject.ViewModels;
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
        private readonly IMapper _mapper;

        public JobController(AppDbContext context,
                            IWebHostEnvironment env,
                           UserManager<AppUser> userManager,
                           RoleManager<IdentityRole> rolemanager,
                           IMapper mapper)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
            _rolemanager = rolemanager;
            _mapper = mapper;
        }
       

        public IActionResult Index(int? page)
        {
            //ViewBag.Time = DateTime.Now.Minute;
            ViewBag.PageCount = Math.Ceiling((decimal)_context.Jobs.Count() / 4);
            ViewBag.Page = page;
            JobVM jobVM = new JobVM();
            if (page == null)
            {
                jobVM.Categories = _context.Categories.ToList();
                jobVM.Jobs = _context.Jobs.Where(x => x.isActivated).OrderByDescending(p => p.Id).Take(4)
                    .Include(c => c.Category)
                    .Include(c => c.Country)
                    .Include(c => c.City)
                    .Include(x => x.AppUser)
                    .ToList();
                return View(jobVM);
            }
            else
            {
                jobVM.Categories = _context.Categories.ToList();
                jobVM.Jobs = _context.Jobs.Where(x=>x.isActivated).OrderByDescending(p => p.Id).Skip(((int)page - 1) * 4).Take(4)
                    .Include(c => c.Category)
                    .Include(c => c.Country)
                    .Include(c => c.City)
                    .Include(x => x.AppUser)
                    .ToList();
                return View(jobVM);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index( string userId, string jobTitle, int jobId)
        {
            TempData["userId"] = userId;
            TempData["jobTitle"] = jobTitle;
            TempData["jobId"] = jobId;
            return RedirectToAction(nameof(Apply));
        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return RedirectToAction("Index","ErrorPage");
            var jobdetail = _context.Jobs.Include(x => x.AppUser).Include(x => x.Category).Include(x => x.Country).Include(x => x.City).FirstOrDefault(x => x.Id == id);
            if (jobdetail == null) return RedirectToAction("Index", "ErrorPage");
            return View(jobdetail);
        }





        [Authorize(Roles = "Admin, Employee")]
        public IActionResult Apply()
        {
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "CityName").Take(3);
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
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "CityName").Take(3);
            ViewBag.State = new SelectList(_context.States.ToList(), "Id", "StateName");
            ViewBag.Country = new SelectList(_context.Countries.ToList(), "Id", "CountryName");
            ViewBag.EducationLevel = new SelectList(_context.EducationLevels.ToList(), "Id", "Level");
            ViewBag.Location = new SelectList(_context.Loactions.ToList(), "Id", "Locationn");
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
            if (!ModelState.IsValid) return View();


        
            var user = await _userManager.FindByNameAsync(User.Identity.Name);


            ApplyJob applyJob = new ApplyJob
            {
                JobId = Convert.ToInt32(TempData["jobId"].ToString()),
                AppUserId = user.Id,
            };

            _context.ApplyJobs.Add(applyJob);





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
                AppUserId = TempData["userId"].ToString(),
                JobTitle = TempData["jobTitle"].ToString(),

            };
            newApply.Image = fileName;
           
            await _context.Applies.AddAsync(newApply);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
            

        }



        public IActionResult Search([FromForm] SearchVM searchVm)
        {
            if (searchVm.Keyword != null && searchVm.CategoryId != 0)
            {
                var jobs = _context.Jobs.Where(x => x.Title.ToLower().Contains(searchVm.Keyword.ToLower()) && x.CategoryId == searchVm.CategoryId && x.isActivated).Take(5)
                    .Include(c => c.Category)
                    .Include(c => c.City)
                    .Include(c => c.AppUser)
                    .Include(c => c.Country)
                    .ToList();
                var mapJobs = _mapper.Map<List<JobsReturnDto>>(jobs);

                return Ok(mapJobs);
            }
            return Ok("");
        }


        public IActionResult CategorySelect([FromForm] CategorySelectVM categorySelectVM)
        {
            if(categorySelectVM.CategoryId != 0)
            {
                
                var jobs = _context.Jobs.Where(x=>x.CategoryId == categorySelectVM.CategoryId && x.isActivated).Take(3)
                    .Include(c => c.Category)
                    .Include(c => c.City)
                    .Include(c => c.AppUser)
                    .Include(c => c.Country)
                    .ToList();

                var mapJobs = _mapper.Map<List<JobsReturnDto>>(jobs);

                return Ok(mapJobs);
            }

            return Ok("");
        }




        public async Task<IActionResult> Applied()
        {

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var applyJobs = _context.ApplyJobs.Where(x => x.AppUserId == user.Id);
            var jobs = _context.Jobs.Where(x=>x.isActivated)
                .Include(x=>x.AppUser)
                .Include(x=>x.Category)
                .Include(x=>x.City)
                .Include(x=>x.Country)
                .ToList();

            List<Job> jobss = new List<Job>();
            foreach (var applyjob in applyJobs)
            {
                foreach (var item in jobs)
                {
                    if(item.Id == applyjob.JobId)
                    {
                        jobss.Add(item);
                    }
                }
            }

            return View(jobss);
        }

    }
}
