using JobSearchEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels
{
    public class ApplyVM
    {
        public GeneralInformation GeneralInformation { get; set; }
        public ContactInformation ContactInformation { get; set; }
        public EducationDetail EducationDetail { get; set; }
        public WorkExperience WorkExperience { get; set; }
        public Skill Skill { get; set; }
    }
}
