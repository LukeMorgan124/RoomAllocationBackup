using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Booking
    {

        public int BookingID { get; set; }
        public int CourseID { get; set; }
        public int RoomID { get; set; }
        public int DayOfTheWeekID { get; set; }
        public int PeriodID { get; set; }
        public string TeacherCode { get; set; }

        public Course Courses { get; set; }
        public Room Rooms { get; set; }
        public DayOfTheWeek DayOfTheWeek { get; set;}
        public Period Period { get; set; }

    }
}
