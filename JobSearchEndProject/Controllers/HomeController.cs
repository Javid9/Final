using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AutoMapper;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Services.Dto;
using JobSearchEndProject.ViewModels;
using JobSearchEndProject.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace JobSearchEndProject.Controllers
{
    [Authorize(Roles = "Employer,Employee,Admin")]
   
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _env;
        public HomeController(AppDbContext context,IMapper mapper, IWebHostEnvironment env)
        {
            _context = context;
            _mapper = mapper;
            _env = env;
        }
        public IActionResult Index()
        {
            HomeVM modelVM = new HomeVM();
            modelVM.Header = _context.Headers.FirstOrDefault();
            modelVM.Categories = _context.Categories.Include(x => x.Jobs).ToList();
            modelVM.JobsTypes = _context.Jobs.Include(x => x.Category).Include(c => c.City).ToList();
            modelVM.HowToWorks = _context.HowToWorks.ToList();
            modelVM.SuccessStories = _context.SuccessStories.ToList();
            modelVM.OurClients = _context.OurClients.ToList();
            modelVM.CareerAdvices = _context.CareerAdvices.ToList();

            return View(modelVM);
           
        }

        public IActionResult Search([FromForm] SearchVM searchVm)
        {
            if (searchVm.Keyword != null && searchVm.CategoryId != 0)
            {
                var jobs=_context.Jobs.Where(x => x.Title.ToLower().Contains(searchVm.Keyword.ToLower()) && x.CategoryId == searchVm.CategoryId).Take(5)
                    .Include(c => c.Category)
                    .Include(c => c.City)
                    .Include(c => c.AppUser)
                    .Include(c => c.Country)
                    .ToList();
              var mapJobs =  _mapper.Map<List<JobsReturnDto>>(jobs);
               
                return Ok(mapJobs);
            }
            return Ok("");
        }







    }
}
