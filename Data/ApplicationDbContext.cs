﻿using System;
using System.Collections.Generic;
using System.Text;
using W5Lab.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace W5Lab.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Province>().HasData(SampleData.GetProvinces());
            modelBuilder.Entity<City>().HasData(SampleData.GetCities());
        }
    }
}
