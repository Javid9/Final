using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string IconClassName { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Apply> Applies { get; set; }
        public ICollection<EmployerCategory> EmployerCategories { get; set; }
    }
}
