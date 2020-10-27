using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Loaction
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public int WorkExperienceId { get; set; }
        public WorkExperience WorkExperience { get; set; }
    }
}
