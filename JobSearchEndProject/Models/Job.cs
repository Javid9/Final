using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Job
    {
        public int Id { get; set; }
      
        public string Title { get; set; }
        public int MaxSalary { get; set; }
        public int MinSalary { get; set; }
        public string Experience { get; set; }
        public string Website { get; set; }

        //[Required(ErrorMessage = "Email is missing."),
        //EmailAddress(ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Shift { get; set; }
       
        public string Description { get; set; }
        public string AllDescription { get; set; }

        public string JobType { get; set; }
        public DateTime CreateTime { get; set; }
        public string Image { get; set; }
       
        [NotMapped]
        public IFormFile Photo { get; set; }
        public int CategoryId { get; set; }
        
        public Category  Category { get; set; }
        public int CountryId { get; set; }
       
        public Country Country { get; set; }
        public int EducationLevelId { get; set; }
      
        public EducationLevel EducationLevel { get; set; }
       
        public int CityId { get; set; }
        public City City { get; set; }

        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public bool isActivated { get; set; }
        public bool featuredJob { get; set; }

        public ICollection<ApplyJob> ApplyJobs { get; set; }


    }
}
