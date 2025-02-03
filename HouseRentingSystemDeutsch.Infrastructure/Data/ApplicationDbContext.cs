﻿using HouseRentingSystemDeutsch.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystemDeutch.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<House>().
                HasOne(h => h.Category).
                WithMany(c => c.Houses).
                HasForeignKey(h => h.CategoryId).
                OnDelete(DeleteBehavior.Restrict);

            builder.Entity<House>().
                HasOne(h => h.Agent).
                WithMany(a => a.House).
                HasForeignKey(h => h.AgentId).
                OnDelete(DeleteBehavior.Restrict);

            builder.Entity<House>().
                Property(h => h.PricePerMonth)
                .HasColumnType("decimal(18,2)");


            base.OnModelCreating(builder);
        }
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<House> Houses { get; set; } = null!;
        public DbSet<Agent> Agents { get; set; } = null!;
    }
}
