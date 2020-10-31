using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Apply> Applies { get; set; }
    }
}
