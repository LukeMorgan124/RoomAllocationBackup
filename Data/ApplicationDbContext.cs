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

            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<DayOfTheWeek>().ToTable("DayOfTheWeek");
            modelBuilder.Entity<Period>().ToTable("Period");
            modelBuilder.Entity<Block>().ToTable("Block");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Booking>().ToTable("Booking");
        }
    }
}
