using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Teacher
    {

        public int TeacherID { get; set; }
        public string TeacherCode{ get; set; }

        
        public Teacher(string teacherCode)
        {
            TeacherCode = teacherCode;
        }
        public Teacher()
        {

        }
        public ICollection<Booking> Bookings { get; set; }
    }
}
