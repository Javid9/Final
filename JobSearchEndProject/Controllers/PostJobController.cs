using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Controllers
{

    public class PostJobController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public PostJobController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
    

        public IActionResult Create()
        {
            ViewBag.Categorys = _context.Categories.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.EduLevel = _context.EducationLevels.ToList();
            ViewBag.City = _context.Cities.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Job job,string JobType,string Gender,string Shift)
        {
            ViewBag.Categorys = _context.Categories.ToList();
            ViewBag.Country = _context.Countries.ToList();
            ViewBag.EduLevel = _context.EducationLevels.ToList();
            ViewBag.City = _context.Cities.ToList();

            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!job.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Zehmet olmasa shekil formati sechin");
                return View();
            }

            if (job.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images");
            string fileName = await job.Photo.SaveImg(_env.WebRootPath, path);

            Job newJob = new Job
            {
                Title = job.Title,
                MaxSalary = job.MaxSalary,
                MinSalary = job.MinSalary,
                Experience = job.Experience,
                Website = job.Website,
                Email = job.Email,
                Phone = job.Phone,
                Gender = Gender,
                Shift = Shift,
                Description = job.Description,
                JobType = JobType,
                CategoryId = job.CategoryId,
                CountryId = job.CountryId,
                EducationLevelId = job.EducationLevelId,
                CityId = job.CityId,
                CreateTime = DateTime.Now
            };
            newJob.Image = fileName;
            await _context.AddAsync(newJob);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Job");
        }
    }
}
