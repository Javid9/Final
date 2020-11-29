using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JobsController : Controller
    {
        private readonly AppDbContext _context;
        public JobsController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Jobs.Where(x=>x.featuredJob==false).Include(c => c.Category).Include(c => c.City).Include(c => c.AppUser).Include(c => c.Country).ToList());
        }


        public IActionResult FeaturedJobList()
        {
            return View(_context.Jobs.Where(x=>x.featuredJob== true).Include(c => c.Category).Include(c => c.City).Include(c => c.AppUser).Include(c => c.Country).ToList());
        }


        public IActionResult FeaturedJob(int? id)
        {
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            job.featuredJob = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public IActionResult Unselected(int? id)
        {
            if (id == null) return NotFound();
            var job = _context.Jobs.FirstOrDefault(x => x.Id == id);
            if (job == null) return NotFound();
            job.featuredJob = false;
            _context.SaveChanges();
            return RedirectToAction(nameof(FeaturedJobList));
        }




    }
}
