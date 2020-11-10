using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Utmaning;

namespace DbDemo
{
    class Context : DbContext
    {
        public DbSet<Platform> Platforms { get; set; }

        public DbSet<Game> Games { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.\SQLEXPRESS;" +
                "Database=Utmaning;" +
                "Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
