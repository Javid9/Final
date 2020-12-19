using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.Models
{
    public class ApplyJob
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public bool IsActivated { get; set; }
    }
}
