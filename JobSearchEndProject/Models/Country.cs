using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string CountryName { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Apply> Applies { get; set; }
    }
}
