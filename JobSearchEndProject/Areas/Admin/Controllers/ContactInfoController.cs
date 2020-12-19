using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactInfoController : Controller
    {
        public readonly AppDbContext _context;
        public ContactInfoController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.ContactInfos.ToList());
        }


        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var contactInfo = _context.ContactInfos.FirstOrDefault(x => x.Id == id);
            if (contactInfo == null) return NotFound();
            return View(contactInfo);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ContactInfo contactInfo)
        {
            var dbcontactInfo = _context.ContactInfos.FirstOrDefault(x => x.Id == contactInfo.Id);
            if (dbcontactInfo == null) return NotFound();

            dbcontactInfo.Address = contactInfo.Address;
            dbcontactInfo.Callus = contactInfo.Callus;
            dbcontactInfo.Email = contactInfo.Email;
            dbcontactInfo.Website = contactInfo.Website;
            dbcontactInfo.Facebook = contactInfo.Facebook;
            dbcontactInfo.Instagram = contactInfo.Instagram;
            dbcontactInfo.Tweeter = contactInfo.Tweeter;
            dbcontactInfo.Wahtsapp = contactInfo.Wahtsapp;
            dbcontactInfo.Linkedin = contactInfo.Linkedin;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



    }
}
