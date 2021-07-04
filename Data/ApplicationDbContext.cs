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
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<Booking>().ToTable("Booking");
            modelBuilder.Entity<Teacher>().ToTable("Teacher");
        }
    }
}
