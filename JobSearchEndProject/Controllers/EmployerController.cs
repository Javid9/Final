using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    public class EmployerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        public EmployerController(AppDbContext context, IWebHostEnvironment env, UserManager<AppUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }



        public IActionResult Index()
        {
            var dbemployer = _context.Employers.Include(x => x.EmployerCategories).ThenInclude(x => x.Category);
            return View(dbemployer);
        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Employer employer = _context.Employers.Include(x => x.EmployerCategories).
            ThenInclude(x => x.Category).FirstOrDefault(x => x.Id == id);
            return View(employer);
        }



        public IActionResult Create()
        {
            ViewBag.Category = _context.Categories.ToList();
            return View();
        }


       


     
        public async Task<IActionResult> JobList(int? id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var jobs = _context.Jobs.Where(x => x.AppUserId == user.Id && x.isActivated == true).
            Include(x => x.Category).Include(x => x.City).Include(x => x.Country).ToList();

            return View(jobs);
        }


        public async Task<IActionResult> DeletedJobList(int? id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            var jobs = _context.Jobs.Where(x => x.AppUserId == user.Id && x.isActivated == false).
            Include(x => x.Category).Include(x => x.City).Include(x => x.Country).ToList();


            return View(jobs);
        }



        public async Task<IActionResult> DeactivateJob(int? id)
        {
            if (id == null) return NotFound();
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            job.isActivated = false;
           await _context.SaveChangesAsync();

            return RedirectToAction("JobList", new { id = id });
        }


        public async Task<IActionResult> ActivateJob(int? id)
        {
            if (id == null) return NotFound();
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            job.isActivated = true;
            await _context.SaveChangesAsync();

            return RedirectToAction("DeletedJobList", new { id = id });
        }





        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employer employer, List<int> List)
        {
            ViewBag.Category = _context.Categories.ToList();

            var existEmployer = await _context.Employers.FirstOrDefaultAsync(x => x.Email == employer.Email);
            if (existEmployer != null)
            {
                ModelState.AddModelError("", "User Exist");
                return View();
            }

            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!employer.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (employer.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "employers");
            string fileName = await employer.Photo.SaveImg(_env.WebRootPath, path);



            if (List.Count() == 0)
            {
                TempData["error"] = "please select category";
                return View();
            }

            
            
            Employer newEmployer = new Employer
            {
                Fullname=employer.Fullname,
                Address=employer.Address,
                CompanyName=employer.CompanyName,
                Website=employer.Website,
                CompanyOverview=employer.CompanyOverview,
                Email=employer.Email,
                Phone=employer.Phone,

            };
            newEmployer.Image = fileName;

            //if(newEmployer.Email != null)
            //{
            //    ModelState.AddModelError("", "Employer Details succesfully accepted");
            //    return View();
            //}
          


            List<EmployerCategory> employerCategories = new List<EmployerCategory>();

            foreach (var item in List)
            {
                EmployerCategory employerCategory = new EmployerCategory
                {
                    EmployerId = newEmployer.Id,
                    CategoryId = item
                };
                employerCategories.Add(employerCategory);
            }

            newEmployer.EmployerCategories = employerCategories;

            await _context.Employers.AddAsync(newEmployer);
            await _context.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }


      



    }
}
