using Berkshire.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Berkshire.DAL
{
    /// <summary>
    /// Quick persistence layer using EFCore/SQLite from https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli
    /// </summary>
    public class BerkshireContext : DbContext
    {
        public DbSet<BerkshireReasoning> BerkshireReasons { get; set; }
        
        public string DbPath { get; init; }

        public BerkshireContext()
        {
            // LocalApplicationData serves as a common repository for application-specific data
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);            
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}berkshire.db";
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Auto-increment primary key
            modelBuilder.Entity<BerkshireReasoning>().Property(m => m.Id).ValueGeneratedOnAdd();

            // Seed data to generate migrations data
            modelBuilder.Entity<BerkshireReasoning>().HasData(new BerkshireReasoning[] { 
                new BerkshireReasoning() { Id = 1, Reason = Reasons.First, Created = DateTime.UtcNow, Updated = DateTime.UtcNow },
                new BerkshireReasoning() { Id = 2, Reason = Reasons.Second, Created = DateTime.UtcNow, Updated = DateTime.UtcNow },
                new BerkshireReasoning() { Id = 3, Reason = Reasons.Third, Created = DateTime.UtcNow, Updated = DateTime.UtcNow },
                new BerkshireReasoning() { Id = 4, Reason = "Invalid Reason", Created = DateTime.UtcNow, Updated = DateTime.UtcNow }
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
