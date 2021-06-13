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
        public int DayOfWeekID { get; set; }
        public int PeriodID { get; set; }
        public int TeacherID { get; set; }
        
        public ICollection<Booking> Bookings { get; set; }
    }
}
