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

namespace JobSearchEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CareerAdviceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public CareerAdviceController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public IActionResult Index()
        {
            return View(_context.CareerAdvices.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CareerAdvice career)
        {
            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!career.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (career.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine(_env.WebRootPath, "images", "blog");
            string fileName = await career.Photo.SaveImg(_env.WebRootPath, path);


            CareerAdvice newCareer = new CareerAdvice
            {
                Title= career.Title,
                Desc= career.Desc,
                CreateTime = career.CreateTime,
                Image = fileName
            };

            await _context.CareerAdvices.AddAsync(newCareer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var career = _context.CareerAdvices.Find(id);
            if (career == null) return NotFound();
            return View(career);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(CareerAdvice career)
        {
            if (!ModelState.IsValid) return View();
            var dbcareer = _context.CareerAdvices.FirstOrDefault(x=>x.Id==career.Id);
            if (dbcareer == null) return View();

            dbcareer.Title = career.Title;
            dbcareer.Desc = career.Desc;
            dbcareer.CreateTime = career.CreateTime;

            if(career.Photo != null)
            {
                IFormFileExtension.DeletePath(_env.WebRootPath, "images/blog", dbcareer.Image);
                dbcareer.Image = await career.Photo.SaveImg(_env.WebRootPath, "images/blog");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var dbcareer = _context.CareerAdvices.Find(id);
            if (dbcareer == null) return NotFound();
            _context.CareerAdvices.Remove(dbcareer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
