﻿using RoomAllocation3.Data;
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

            
            List<String> Classes = new List<String>() { "PHY", "SOS", "MAT", "ENG", "SCI", "MUS", "DRA", "ART", "TPI", "TVC", "TPD", "BIO", "CEM", "HIS", "GEO", "PSY", "STA", "HPE", "FRE", "SPA", "JAP", "SAO", "N/A"};

            List<Course> courses = new List<Course>();
            {
                for (int CurrentYearLevel = 9; CurrentYearLevel <= 13; CurrentYearLevel++)
                {
                        for (int CurrentClass = 1; CurrentClass <= Classes.Count; CurrentClass++)
                        {
                            string CurrentClassString = Classes[CurrentClass - 1];
                            if (CurrentClassString == "N/A")
                            {
                                int EmptyYearLevel = 0;
                                courses.Add(new Course(CurrentClassString, EmptyYearLevel));
                            }
                            else
                            {
                                courses.Add(new Course(CurrentClassString, CurrentYearLevel));
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

            
            List<String> TeacherCodes = new List<String>() { "BID", "ROA", "TRC", "PNR", "TBU", "LKT", "YER", "TUV", "KHT", "REY", "NHT", "URE", "HNP", "DRE", "HWC", "JUT", "GRE", "KUT", "STR", "VAK", "KRY", "GHO", "IGP", "UYC", "FER", "JOH", "VIK", "OPT", "CYI", "RDY", "SER", "OHI", "YUI", "TXR", "MBO", "PTO", "CGO", "OHR", "JOX", "RYP", "BKH", "FOM", "HEA", "BTR", "N/A" };

            List<Teacher> teachers = new List<Teacher>();
            for (int CurrentTeacher = 1; CurrentTeacher <= TeacherCodes.Count; CurrentTeacher++)
            {
                string CurrentTeacherString = TeacherCodes[CurrentTeacher - 1];
                teachers.Add(new Teacher(CurrentTeacherString));
            }
            context.Teachers.AddRange(teachers);
            context.SaveChanges();

            List<String> DaysOfTheWeek = new List<String>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            List<String> PeriodTimes = new List<String>() { "09:15 - 10:10", "10:15 - 11:10", "11:35 - 12:30", "13:20 - 14:15", "14:20 - 15:15"};
            List<Booking> bookings = new List<Booking>();
            for (int CurrentRoomNumber = 1; CurrentRoomNumber <= rooms.Count; CurrentRoomNumber++)
            {
                for (int CurrentDay = 1; CurrentDay <= DaysOfTheWeek.Count; CurrentDay++)
                {
                    string CurrentDayString = DaysOfTheWeek[CurrentDay - 1];
                    for (int CurrentPeriod = 1; CurrentPeriod <= PeriodTimes.Count; CurrentPeriod++)
                    {
                        string CurrentPeriodString = PeriodTimes[CurrentPeriod - 1];
                        Random rd = new Random();
                        int Empty = rd.Next(1, 5);                     
                        if (Empty == 4)
                        {
                            int EmptyCourse = courses.Count;
                            int EmptyTeacher = 1;
                            bool Booked = false;
                            bookings.Add(new Booking(EmptyCourse, CurrentRoomNumber, CurrentDayString, CurrentPeriodString, EmptyTeacher, Booked));
                        }
                        else
                        {
                            int RandomTeacher = rd.Next(1, teachers.Count);
                            int OddCheck = (RandomTeacher % 2);
                            int RandomCourse = ((RandomTeacher + OddCheck) / 2);
                            bool Booked = true;
                            bookings.Add(new Booking (RandomCourse, CurrentRoomNumber, CurrentDayString, CurrentPeriodString, RandomTeacher, Booked));
                        }
                    }
                }
            }           
            context.Bookings.AddRange(bookings);
            context.SaveChanges();
            
        }
    }
}
