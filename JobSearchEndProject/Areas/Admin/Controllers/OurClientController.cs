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
    public class OurClientController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public OurClientController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }



        public IActionResult Index()
        {
            return View(_context.OurClients.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OurClient ourClient)
        {
            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!ourClient.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (ourClient.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "clients");
            string fileName = await ourClient.Photo.SaveImg(_env.WebRootPath, path);


            OurClient newClient = new OurClient
            {
                Image = fileName
            };
           

             await _context.OurClients.AddAsync(newClient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var ourClient = _context.OurClients.FirstOrDefault(x => x.Id == id);
            if (ourClient == null) return NotFound();
            return View(ourClient);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(OurClient ourClient)
        {
            if (!ModelState.IsValid) return NotFound();
            OurClient dbourclient = _context.OurClients.FirstOrDefault(x => x.Id == ourClient.Id);
           
            if(ourClient != null)
            {
                IFormFileExtension.DeletePath(_env.WebRootPath, "images/clients", dbourclient.Image);
                dbourclient.Image = await ourClient.Photo.SaveImg(_env.WebRootPath, "images/clients");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var ourClient = _context.OurClients.Find(id);
            if (ourClient == null) return NotFound();
            _context.OurClients.Remove(ourClient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }




    }
}
