using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class GeneralInformation
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string Genral { get; set; }
        public string Status { get; set; }
    }
}
