using JobSearchEndProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Location> Loactions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Bio> Bios { get; set; }
        public DbSet<Apply> Applies { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<EmployerCategory> EmployerCategories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        //public DbSet<Subcomment> Subcomments { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<SuccessStorie> SuccessStories { get; set; }
        public DbSet<HowToWork> HowToWorks { get; set; }
        public DbSet<CareerAdvice> CareerAdvices { get; set; }
        public DbSet<OurClient> OurClients { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<ApplyJob> ApplyJobs { get; set; }

    }
}
