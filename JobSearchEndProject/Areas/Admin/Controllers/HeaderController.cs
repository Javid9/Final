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
    public class HeaderController : Controller
    {
        private readonly AppDbContext _context;
        public HeaderController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Headers.ToList());
        }


        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Header header)
        {
            if (ModelState.IsValid)
            {
                Header newHeader = new Header
                {
                    Title = header.Title,
                    Description = header.Description
                };
               await _context.Headers.AddAsync(newHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }



        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            Header header =  _context.Headers.FirstOrDefault(x=>x.Id==id);
            if (header == null) return NotFound();
            return View(header);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Header header)
        {
            if (id == null) return NotFound();
            Header dbHeader = _context.Headers.FirstOrDefault(x => x.Id == id);
            if (dbHeader == null) return NotFound();
            dbHeader.Description = header.Description;
            dbHeader.Title = header.Title;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var header = _context.Headers.FirstOrDefault(x => x.Id == id);
            if (header == null) return NotFound();
            _context.Headers.Remove(header);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));     
        }


    }
}
