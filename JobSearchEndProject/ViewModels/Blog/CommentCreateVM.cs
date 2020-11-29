using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels
{
    public class CommentCreateVM
    {
        public string Message { get; set; }
        public int BlogId { get; set; }
    }
}
