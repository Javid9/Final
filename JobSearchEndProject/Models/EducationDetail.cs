using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class EducationDetail
    {
        public int Id { get; set; }
        public string Graduation { get; set; }
        public string University { get; set; }
        public string Degree { get; set; }
        public string CourseTitle { get; set; }
        public string AdditionInformation { get; set; }
        public ICollection<EducationLevel> EducationLevels { get; set; }

    }
}
