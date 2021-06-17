using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class DayOfTheWeek
    {

        public int DayOfTheWeekID { get; set; }
        public string DayOfTheWeekName{ get; set; }
                
        public ICollection<Booking> Bookings { get; set; }
    }
}
