using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ContactInformationId { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
