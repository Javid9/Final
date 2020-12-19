using JobSearchEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels
{
    public class CandidateVM
    {
        public ICollection<Apply> Applies { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }
}
