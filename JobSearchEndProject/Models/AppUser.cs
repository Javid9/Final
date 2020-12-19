using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class AppUser:IdentityUser
    {
        [Required,MaxLength(150)]
        public string FullName { get; set; }
        public bool isActivated { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Apply> Applies { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<ApplyJob> ApplyJobs { get; set; }
        public ICollection<Employer> Employers { get; set; }
        //public ICollection<Subcomment> Subcomments { get; set; }

    }
}
