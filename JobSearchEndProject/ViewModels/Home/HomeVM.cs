using JobSearchEndProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.ViewModels.Home
{
    public class HomeVM
    {
        public Header Header { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public ICollection<Job> JobsTypes { get; set; }
        public ICollection<HowToWork> HowToWorks { get; set; }
        public ICollection<SuccessStorie> SuccessStories { get; set; }
        public ICollection<OurClient> OurClients { get; set; }
        public ICollection<CareerAdvice> CareerAdvices { get; set; }

    }
}
