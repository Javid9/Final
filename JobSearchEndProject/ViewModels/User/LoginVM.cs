using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels.User
{
    public class LoginVM
    {
        [Required,EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name ="Remmeber me?")]
        public bool RemmeberMe { get; set; }
    }
}
