using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    public class JobController : Controller
    {
        private readonly AppDbContext _context;
        public JobController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            //ViewBag.Time = DateTime.Now.Minute;
            ViewBag.PageCount = Math.Ceiling((decimal)_context.Jobs.Count() / 6);
            ViewBag.Page = page;
            if (page == null)
            {
                return View(_context.Jobs.OrderByDescending(p => p.Id).Take(6).Include(c => c.Category).Include(c => c.Country).Include(c=>c.City).ToList());
            }
            else
            {
                return View(_context.Jobs.OrderByDescending(p => p.Id).Skip(((int)page - 1) * 6).Take(6).Include(c => c.Category).Include(c => c.Country).Include(c => c.City).ToList());
            }
            //return View(_context.Jobs.OrderByDescending(x=>x.Id).Include(c=>c.Category).Include(c=>c.Country));
        }


        public IActionResult Apply()
        {
            return View();
        }
    }
}
