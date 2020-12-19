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
    public class SuccessStorieController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public SuccessStorieController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public IActionResult Index()
        {
            return View(_context.SuccessStories.ToList());
        }


        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SuccessStorie successStorie)
        {
            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!successStorie.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (successStorie.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "testi");
            string fileName = await successStorie.Photo.SaveImg(_env.WebRootPath, path);

            SuccessStorie newSuccesStorie = new SuccessStorie
            {
               Desc=successStorie.Desc,
               FullName=successStorie.FullName,
               Postion=successStorie.Postion
            };
            newSuccesStorie.Image = fileName;

            await _context.SuccessStories.AddAsync(newSuccesStorie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var successStorie = _context.SuccessStories.FirstOrDefault(x => x.Id == id);
            if (successStorie == null) return NotFound();
            return View(successStorie);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(SuccessStorie successStorie)
        {
            //if (!ModelState.IsValid) return NotFound();
            SuccessStorie dbSuccessStorie = _context.SuccessStories.FirstOrDefault(x => x.Id == successStorie.Id);

            if (dbSuccessStorie == null) return NotFound();
            dbSuccessStorie.Desc = successStorie.Desc;
            dbSuccessStorie.FullName = successStorie.FullName;
            dbSuccessStorie.Postion = successStorie.Postion;

            if(successStorie.Photo != null)
            {
                IFormFileExtension.DeletePath(_env.WebRootPath, "images/testi", dbSuccessStorie.Image);
                dbSuccessStorie.Image = await successStorie.Photo.SaveImg(_env.WebRootPath, "images/testi");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var dbsuccessStorie = await _context.SuccessStories.FindAsync(id);
            if (dbsuccessStorie == null) return NotFound();
            _context.SuccessStories.Remove(dbsuccessStorie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
