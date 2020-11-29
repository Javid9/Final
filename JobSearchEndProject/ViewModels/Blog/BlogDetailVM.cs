using JobSearchEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels
{
    public class BlogDetailVM
    {
        public Blog Blog { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
