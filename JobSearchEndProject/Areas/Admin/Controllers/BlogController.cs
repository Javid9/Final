using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using JobSearchEndProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }



        public IActionResult Index()
        {
            
            return View(_context.Blogs.Include(x=>x.Category).ToList());

        }


        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();
            var blogdetail = _context.Blogs.FirstOrDefault(x =>x.Id==id);
            if (blogdetail == null) return NotFound();
            return View(blogdetail);
        }



        public IActionResult Create()
        {
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");

            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!blog.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (blog.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "blog");
            string fileName = await blog.Photo.SaveImg(_env.WebRootPath, path);

            Blog newBlog = new Blog
            {
                Title=blog.Title,
                AllDescription=blog.AllDescription,
                Description=blog.Description,
                CreateTime=blog.CreateTime,
                AuthorDesc=blog.AuthorDesc,
                Facebook=blog.Facebook,
                Instagram=blog.Instagram,
                Twitter=blog.Twitter,
                Whatsapp=blog.Whatsapp,
                AuthorName=blog.AuthorName,
                CategoryId=blog.CategoryId,

            };
            newBlog.Image = fileName;

           await _context.Blogs.AddAsync(newBlog);
          await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Blog");

        }


        public IActionResult Update(int? id)
        {
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
            if (id == null) return NotFound();
            Blog blog = _context.Blogs.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
            if (blog == null) return NotFound();
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(BlogUpdateVM blogUpdate)
        {
            ViewBag.Category = new SelectList(_context.Categories.ToList(), "Id", "CategoryName");
            if (!ModelState.IsValid) return NotFound();

            Blog blog = _context.Blogs.FirstOrDefault(x => x.Id == blogUpdate.Id);
            if (blog == null) return NotFound();

            blog.Title = blogUpdate.Title;
            blog.Description = blogUpdate.Description;
            blog.AllDescription = blogUpdate.AllDescription;
            blog.AuthorDesc = blogUpdate.AuthorDesc;
            blog.CreateTime = blogUpdate.CreateTime;
            blog.Facebook = blogUpdate.Facebook;
            blog.Twitter = blogUpdate.Twitter;
            blog.Instagram = blogUpdate.Instagram;
            blog.Whatsapp = blogUpdate.Whatsapp;
            blog.AuthorName = blogUpdate.AuthorName;
            blog.CategoryId= blogUpdate.CategoryId;


            if(blogUpdate.Photo != null)
            {
                IFormFileExtension.DeletePath(_env.WebRootPath, "images/blog", blog.Image);
                blog.Image = await blogUpdate.Photo.SaveImg(_env.WebRootPath, "images/blog");
            }


           await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }



      
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var blog = _context.Blogs.FirstOrDefault(x => x.Id == id);
            if (blog == null) return NotFound();
            _context.Blogs.Remove(blog);
           await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
