﻿using Microsoft.EntityFrameworkCore;
using YemekKitabı.Models;

namespace YemekKitabı.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Image> Images { get; set; }  
        public DbSet<Cook> Cooks { get; set; }  
        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>()
            .HasOne(c => c.Cook)
            .WithMany(b => b.Images)
            .HasForeignKey(c => c.CookId);



        }
    }
}
