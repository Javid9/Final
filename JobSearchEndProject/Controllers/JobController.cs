﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Extensions;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace JobSearchEndProject.Controllers
{
    public class JobController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public JobController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
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
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "CityName");
            ViewBag.State = new SelectList(_context.States.ToList(), "Id", "StateName");
            ViewBag.Country = new SelectList(_context.Countries.ToList(), "Id", "CountryName");
            ViewBag.EducationLevel = new SelectList(_context.EducationLevels.ToList(), "Id", "Level");
            ViewBag.Location = new SelectList(_context.Loactions.ToList(), "Id", "Locationn");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Apply(Apply apply, string General, string Status)
        {
            ViewBag.City = new SelectList(_context.Cities.ToList(), "Id", "Name");
            ViewBag.State = new SelectList(_context.States.ToList(), "Id", "Name");
            ViewBag.Country = new SelectList(_context.Countries.ToList(), "Id", "Name");
            ViewBag.EducationLevel = new SelectList(_context.EducationLevels.ToList(), "Id", "Level");
            ViewBag.Location = new SelectList(_context.Loactions.ToList(), "Id", "Locationn");

            if (!ModelState.IsValid) return View();

            if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }

            if (!apply.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            if (apply.Photo.MaxLength(1000))
            {
                ModelState.AddModelError("Photo", "Shekilin olchusu max 1mg ola biler");
                return View();
            }

            string path = Path.Combine("images", "apply");
            string fileName = await apply.Photo.SaveImg(_env.WebRootPath, path);


            Apply newApply = new Apply
            {
                Firstname=apply.Firstname,
                MiddleName=apply.MiddleName,
                Surname=apply.Surname,
                Date=apply.Date,
                General=General,
                Status=Status,
                Phone=apply.Phone,
                Email=apply.Email,
                Website=apply.Website,
                Address=apply.Address,
                CityId=apply.CityId,
                StateId=apply.StateId,
                CountryId=apply.CountryId,
                Graduation=apply.Graduation,
                University=apply.University,
                Degree=apply.Degree,
                CourseTitle=apply.CourseTitle,
                EducationInformation=apply.EducationInformation,
                EducationLevelId=apply.EducationLevelId,
                CompanyName=apply.CompanyName,
                JobPosition=apply.JobPosition,
                DateFrom=apply.DateFrom,
                DateTo=apply.DateTo,
                ExperienceInformation=apply.ExperienceInformation,
                LocationId=apply.LocationId,
                Skills=apply.Skills,
                SkillProficiency=apply.SkillProficiency
            };
            newApply.Image = fileName;
          await  _context.AddAsync(newApply);
           await _context.SaveChangesAsync();
            return Ok("yes");


            //newApplyVm.GeneralInformation.Image = fileName;

        }


    }
}
