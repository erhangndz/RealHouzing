using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = ERHAN\\SQLEXPRESS;database=RealHouzingDb;integrated security=true");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BuyLease> BuyLeases { get; set; }
        public DbSet<Posting> Postings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<VideoandAbout> VideoandAbouts { get; set; }
    }
}

