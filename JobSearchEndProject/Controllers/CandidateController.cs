﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    
    public class CandidateController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly IWebHostEnvironment _env;
        public CandidateController(AppDbContext context, UserManager<AppUser>
                                        userManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _env = env;
        }

        //[Authorize(Roles = "Admin, Employer")]
        public async Task<IActionResult> Index()
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            var applies = _context.Applies.Where(x => x.AppUserId == user.Id).Include(x=>x.City).ToList();
            return View(applies);
        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Apply dbapply = _context.Applies.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
            if (dbapply == null) return NotFound();
            return View(dbapply);
        }




    }
}
