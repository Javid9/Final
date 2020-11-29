using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactsController : Controller
    {
        private readonly AppDbContext _context;
        public ContactsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Contacts.Where(x=>x.isactivated==false).ToList());
        }


        public IActionResult Archive()
        {
            var contact = _context.Contacts.Where(x=>x.isactivated==true).ToList();
            return View(contact);
        }



        public IActionResult Delete(int? id)
        {
            var contact = _context.Contacts.FirstOrDefault(x => x.Id == id);
            contact.isactivated = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Activated(int? id)
        {
            var contact = _context.Contacts.FirstOrDefault(x => x.Id == id);
            contact.isactivated = false;
            _context.SaveChanges();
            return RedirectToAction(nameof(Archive));

        }
       
    }
}
