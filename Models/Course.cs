using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Course
    {

        public int CourseID { get; set; }
        public string CourseCode{ get; set; }
        public int YearLevel { get; set; }

        public Course(string courseCode, int yearLevel)
        {
            CourseCode = courseCode;
            YearLevel = yearLevel;
        }

        public ICollection<Booking> Bookings { get; set; }
    }
}
