using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSearchEndProject.DAL;
using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly AppDbContext _context;
        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }



        [HttpPost]
        public async Task<IActionResult> Subscribe([FromForm] string email)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            bool existSubscription = _context.Subscriptions.Any(e => e.Email == email);
            if (existSubscription)
            {
                return Ok(existSubscription);
            }

            Subscription subscription = new Subscription { Email = email };
            await _context.Subscriptions.AddAsync(subscription);
            await _context.SaveChangesAsync();

            return Ok(existSubscription);
        }




    }
}
