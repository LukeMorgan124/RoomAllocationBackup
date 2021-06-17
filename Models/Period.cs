using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Period
    {

        public int PeriodID { get; set; }
        public string PeriodTime{ get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
