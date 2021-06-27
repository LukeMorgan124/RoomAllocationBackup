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
        public int TeacherID { get; set; }

        public Booking(int courseID, int roomID, int dayOfTheWeekID, int periodID, int teacherID)
        {
            CourseID = courseID;
            RoomID = roomID;
            DayOfTheWeekID = dayOfTheWeekID;
            PeriodID = periodID;
            TeacherID = teacherID;
        }


        public Course Courses { get; set; }
        public Room Rooms { get; set; }
        public DayOfTheWeek DaysOfTheWeek { get; set;}
        public Period Period { get; set; }
        public Teacher Teacher { get; set; }

    }
}
