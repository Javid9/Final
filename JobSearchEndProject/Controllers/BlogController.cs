using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Models;
using JobSearchEndProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.Category = _context.Categories.ToList();
            List<Blog>  blog =  _context.Blogs.Include(x => x.Category).Include(x=>x.Comments).ToList();
            return View(blog);
        }



        public IActionResult Detail(int? id)
        {
            ViewBag.Category = _context.Categories.ToList();
            Blog blog = _context.Blogs.Include(x => x.Category).FirstOrDefault(x => x.Id == id);
            var comments = _context.Comments.Where(x => x.BlogId == id).Include(x=>x.AppUser).ToList();
            if (blog == null) return NotFound();

            BlogDetailVM blogDetailVM = new BlogDetailVM
            {
                Blog=blog,
                Comments =comments
            };
            return View(blogDetailVM);
        }





        [HttpPost]
        public async Task<IActionResult> CreateComment([FromForm] CommentCreateVM commentVM)
        {
            ViewBag.Category = _context.Categories.ToList();
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            Comment comment = new Comment();
            comment.Message = commentVM.Message;
            comment.BlogId = commentVM.BlogId;
            comment.AppUserId = appUser.Id;
            //comment.Image= appUser.Image
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

            
            return Ok(new { Id = comment.Id , Message = comment.Message, BlogId=comment.BlogId, User = appUser.FullName, Time= comment.CreateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss") });
        }

        public async Task<IActionResult> DeleteComment(int? id)
        {
            if (id == null) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null) return NotFound();
            _context.Comments.Remove(comment);
            await _context.SaveChangesAsync();
            return RedirectToAction("Detail",new { Id=comment.BlogId });

        }


        public IActionResult Search(string search)
        {
            var blog = _context.Blogs.Where(x => x.Title.ToLower().Contains(search.ToLower())).OrderByDescending(x => x.Id).Take(3)
            .Include(x => x.Category)
            .ToList();
            return PartialView("_partialSearchBlog", blog);
        }



    }
}
