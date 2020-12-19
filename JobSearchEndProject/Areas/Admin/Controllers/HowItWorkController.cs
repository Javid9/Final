using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using JobSearchEndProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HowItWorkController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public HowItWorkController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public IActionResult Index()
        {
            return View(_context.HowToWorks.ToList());
        }




        public IActionResult Create()
        {
            return View();
        }




        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(HowToWork howItWork)
        {


            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!howItWork.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (howItWork.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "how-it-work");
            string fileName = await howItWork.Photo.SaveImg(_env.WebRootPath, path);


            HowToWork newHowToWork = new HowToWork
            {
                Title=howItWork.Title,
                Desc=howItWork.Desc,
            };

            newHowToWork.Image = fileName;

           await _context.HowToWorks.AddAsync(newHowToWork);
          await _context.SaveChangesAsync();

           // var callbackUrl = Url.Action(
           // "Index",
           // "Home",
           //new { Id = howItWork.Id },
           //protocol: HttpContext.Request.Scheme);
           // EmailSubscribe email = new EmailSubscribe();
           // List<string> e = _context.Subscriptions.Select(x => x.Email).ToList();
           // await email.SendEmailAsync(e, "Yeni course",
           //        "Yeni Course: <a href=https://localhost:44341/Home/Index" + $"{newHowToWork.Id}" + ">link</a>");

            return RedirectToAction(nameof(Index));

        }




        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var howToWork = _context.HowToWorks.FirstOrDefault(x => x.Id == id);
            if (howToWork == null) return NotFound();
            return View(howToWork);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(HowToWork howToWork)
        {
            if (!ModelState.IsValid) return NotFound();
            HowToWork dbhowtowork = _context.HowToWorks.FirstOrDefault(x => x.Id == howToWork.Id);
            if (dbhowtowork == null) return NotFound();

            dbhowtowork.Title = howToWork.Title;
            dbhowtowork.Desc = howToWork.Desc;

            if(howToWork.Photo != null)
            {
                IFormFileExtension.DeletePath(_env.WebRootPath, "images/how-it-work", dbhowtowork.Image);
                dbhowtowork.Image = await howToWork.Photo.SaveImg(_env.WebRootPath, "images/how-it-work");
            }


             await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            HowToWork dbhowToWork = _context.HowToWorks.FirstOrDefault(x => x.Id == id);
            if (dbhowToWork == null) return NotFound();
            _context.HowToWorks.Remove(dbhowToWork);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }





    }
}
