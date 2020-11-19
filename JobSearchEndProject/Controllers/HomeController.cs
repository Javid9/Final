using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobSearchEndProject.Controllers
{
    [Authorize(Roles = "Employer,Employee,Admin")]
   
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
