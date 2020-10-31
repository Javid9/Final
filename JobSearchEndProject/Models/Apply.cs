using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Apply
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public DateTime Date { get; set; }
        public string General { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }


        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }


        public string Graduation { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public string CourseTitle { get; set; }
        public string EducationInformation { get; set; }
        public int EducationLevelId { get; set; }


        public string CompanyName { get; set; }
        public string JobPosition { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string ExperienceInformation { get; set; }
        public int LocationId { get; set; }



        public string Skills { get; set; }
        public int SkillProficiency { get; set; }


      




    }
}
