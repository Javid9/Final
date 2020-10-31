using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class EducationLevel
    {
        public int Id { get; set; }
        [Required]
        public string Level { get; set; }
        public ICollection<Job> Job { get; set; }
        public ICollection<Apply> Applies { get; set; }

    }
}
