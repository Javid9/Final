using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Employer
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string  Address { get; set; }    
        public string CompanyName { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CompanyOverview { get; set; }
        public int Rate { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string Google { get; set; }
        public string Image { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
        public ICollection<EmployerCategory> EmployerCategories { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
