using JobSearchEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels
{
    public class JobVM
    {
        public List<Job> Jobs{ get; set; }
        public List<Category> Categories { get; set; }
    }
}
