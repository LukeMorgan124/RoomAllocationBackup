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
        public int TeacherID { get; set; }
        public string Period { get; set; }
        public string Day { get; set; }
        public bool Booked { get; set; }
        
        public Booking(int courseID, int roomID, string day, string period, int teacherID, bool booked)
        {
            CourseID = courseID;
            RoomID = roomID;
            Day = day;
            Period = period;
            TeacherID = teacherID;
            Booked = booked;
        }

        public Booking()
        {           
        }

        public Course Courses { get; set; }
        public Room Rooms { get; set; }
        public Teacher Teacher { get; set; }

    }
}
