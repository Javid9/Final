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
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Categories.ToList());
        }



        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid) return View();

            bool isValid = _context.Categories.Any(x => x.CategoryName.ToLower() == category.CategoryName);
            if (isValid)
            {
                ModelState.AddModelError("Name", $"{category.CategoryName} Bu adda kategoriya movcuddur");
                return View();
            }
                
   
             await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.FirstOrDefault(x=>x.Id==id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (!ModelState.IsValid) return View();
            if (id == null) return NotFound();
            Category dbCategory = _context.Categories.FirstOrDefault(x => x.Id== category.Id);
            if (dbCategory == null) return NotFound();

            Category checkCategory = _context.Categories.FirstOrDefault(x => x.CategoryName.ToLower() == category.CategoryName);

            if(checkCategory != null)
            {
                if(dbCategory.CategoryName != checkCategory.CategoryName)
                {
                    ModelState.AddModelError("Name", "Bu adda kategoriya movcuddur");
                    return View();
                }
            }

            dbCategory.CategoryName = category.CategoryName;
            dbCategory.IconClassName = category.IconClassName;

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var dbcategory = _context.Categories.FirstOrDefault(x => x.Id == id);
            if (dbcategory == null) return NotFound();
            _context.Categories.Remove(dbcategory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
