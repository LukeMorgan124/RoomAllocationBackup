using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoomAllocation3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomAllocation3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<DayOfTheWeek> DaysOfTheWeek { get; set; }
        public DbSet<Period> Periods { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().ToTable("Courses");
            modelBuilder.Entity<DayOfTheWeek>().ToTable("DayOfTheWeek");
            modelBuilder.Entity<Period>().ToTable("Periods");
            modelBuilder.Entity<Block>().ToTable("Blocks");
            modelBuilder.Entity<Room>().ToTable("Rooms");
            modelBuilder.Entity<Booking>().ToTable("Bookings");
        }
    }
}
