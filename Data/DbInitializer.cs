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
            context.Database.EnsureCreated();


            // Look for any courses.
            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

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
                new Period { PeriodTime = "09:15 - 10:10" },
                new Period { PeriodTime = "10:15 - 11:10" },
                new Period { PeriodTime = "11:35 - 12:30" },
                new Period { PeriodTime = "13:20 - 14:10" },
                new Period { PeriodTime = "14:20 - 15:15" },
            };
            context.Periods.AddRange(periods);
            context.SaveChanges();


            List<String> TeacherCodes = new List<String>() { "KHO", "PHS", "FRA", "LIS", "SVH", "CLK" };

            List<String> Classes = new List<String>() { "PHY", "SOS", "MAT"};


            List<Course> courses = new List<Course>();
            {
                for (int CurrentYearLevel = 9; CurrentYearLevel <= 13; CurrentYearLevel++)
                {
                    for (int CurrentTeacher = 1; CurrentTeacher <= TeacherCodes.Count; CurrentTeacher++)
                    {
                        int OddCheck = (CurrentTeacher % 2);
                        for (int CurrentClass = ((CurrentTeacher + OddCheck) / 2); CurrentClass <= 2; CurrentClass++)
                        {
                            string CurrentTeacherString = TeacherCodes[CurrentTeacher - 1];
                            string CurrentClassString = Classes[CurrentClass - 1];
                            courses.Add(new Course(CurrentClassString, CurrentTeacherString, CurrentYearLevel));
                        }
                    }
                }
            }
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
            for (int CurrentBlock = 1; CurrentBlock <= blocks.Length; CurrentBlock++)
            {
                for (int CurrentRoomNumber = 1; CurrentRoomNumber <= 10; CurrentRoomNumber++)
                {
                    rooms.Add(new Room(CurrentBlock, CurrentRoomNumber));
                }
            }
            context.Rooms.AddRange(rooms);
            context.SaveChanges();


            List<Booking> bookings = new List<Booking>();
            for (int CurrentRoomNumber = 1; CurrentRoomNumber <= rooms.Count; CurrentRoomNumber++)
            {
                for (int CurrentDay = 1; CurrentDay <= daysOfTheWeek.Length; CurrentDay++)
                {
                    for (int CurrentPeriod = 1; CurrentPeriod <= periods.Length; CurrentPeriod++)
                    {
                        Random rd = new Random();
                        int RandomCourse = rd.Next(1, courses.Count);
                        bookings.Add(new Booking(RandomCourse, CurrentRoomNumber, CurrentDay, CurrentPeriod));
                    }
                }
            }           
            context.Bookings.AddRange(bookings);
            context.SaveChanges();

        }
    }
}
