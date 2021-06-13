using RoomAllocation3.Data;
using RoomAllocation3.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace RoomAllocation3.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();
            

            // Look for any courses.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            //var users = new User[]
            //{
            //    new User {Username = "ac107242", Password = "123", Admin = true}
 
            //};

            //context.Users.AddRange(users);
            //context.SaveChanges();

            

            var daysOfTheWeek = new DayOfTheWeek[]
            {
                new DayOfTheWeek { DayOfTheWeekName = "Monday" },
                new DayOfTheWeek { DayOfTheWeekName = "Tuesday" },
                new DayOfTheWeek { DayOfTheWeekName = "Wednesday" },
                new DayOfTheWeek { DayOfTheWeekName = "Thursday" },
                new DayOfTheWeek { DayOfTheWeekName = "Friday" }
            };
            context.DaysOfTheWeek.AddRange(daysOfTheWeek);
            context.SaveChanges();

            var periods = new Period[]
            {
                new Period { PeriodName = "09:15 - 10:10" },
                new Period { PeriodName = "10:15 - 11:10" },
                new Period { PeriodName = "11:35 - 12:30" },
                new Period { PeriodName = "13:20 - 14:14" },
                new Period { PeriodName = "14:20 - 15:15" },
            };
            context.Periods.AddRange(periods);
            context.SaveChanges();

            var courses = new Course[]
           {
                new Course { CourseCode = "12MAT" },
                new Course { CourseCode = "12SCI" },
                new Course { CourseCode = "12ENG" },
                new Course { CourseCode = "12PHY" },

           };
            context.Courses.AddRange(courses);
            context.SaveChanges();

            var blocks = new Block[]
           {
                new Block { BlockName = "A" },
                new Block { BlockName = "B" },
                new Block { BlockName = "C" },
                new Block { BlockName = "D" },
                new Block { BlockName = "E" },
                new Block { BlockName = "F" },


           };
            context.Blocks.AddRange(blocks);
            context.SaveChanges();

            List<Room> rooms = new List<Room>();
            foreach (Block b in blocks)
            {
                for (int loop = 1; loop <= 10; loop++)
                {
                rooms.Add(new Room(b.BlockName + loop.ToString("00")));
                }
            }
            context.Rooms.AddRange(rooms);
            context.SaveChanges();

            var bookings = new Booking[]
            {
                new Booking { CourseID = 1, RoomID = 1, DayOfWeekID = 1, PeriodID = 1, TeacherID = 1 }
                
            };
            context.Bookings.AddRange(bookings);
            context.SaveChanges();
            

        }
    }
}
