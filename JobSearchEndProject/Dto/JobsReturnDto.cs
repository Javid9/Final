using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Services.Dto
{
    public class JobsReturnDto
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

        public string JobType { get; set; }
        public DateTime CreateTime { get; set; }
        public string Image { get; set; }


        public string Category { get; set; }

        public string Country { get; set; }

        public string EducationLevel { get; set; }
        public string City { get; set; }

        public string AppUserId { get; set; }
        public string AppUser { get; set; }

        public bool isActivated { get; set; }
        public bool featuredJob { get; set; }
       

    }
}
