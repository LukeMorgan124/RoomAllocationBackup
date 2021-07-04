using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Room
    {
        
        public int RoomID { get; set; }
        public char Block { get; set; }
        public int RoomNumber { get; set; }

        public Room(char block, int roomNumber) 
        {
            Block = block;
            RoomNumber = roomNumber; 
        }
        public Room()
        {

        }

        public ICollection<Booking> Bookings { get; set; }

    }
}
