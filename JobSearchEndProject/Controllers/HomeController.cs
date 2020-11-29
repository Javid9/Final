using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    [Authorize(Roles = "Employer,Employee,Admin")]
   
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(string keywordInput,int selectCategory, int id)
        {
            HomeVM modelVM = new HomeVM();
            modelVM.Header = _context.Headers.FirstOrDefault();
            modelVM.Categories = _context.Categories.Include(x => x.Jobs).ToList();
            modelVM.JobsTypes = _context.Jobs.Include(x => x.Category).Include(c => c.City).ToList();
            if (keywordInput!=null&&selectCategory!=0)
            {
               modelVM.Jobs= _context.Jobs.Where(x=>x.Title.ToLower().Contains(keywordInput.ToLower().ToLower()) && x.CategoryId == selectCategory).Take(5)
                   .Include(c => c.Category)
                   .Include(c => c.City)
                   .Include(c => c.AppUser)
                   .Include(c => c.Country)
                   .ToList();
                return View(modelVM);
            }
            return View(modelVM);
           
        }







    }
}
