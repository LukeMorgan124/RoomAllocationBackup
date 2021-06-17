using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Room
    {
        
        public int RoomID { get; set; }
        public int BlockID { get; set; }
        public int RoomNumber { get; set; }

        public Room(int blockID, int roomNumber) 
        {
            BlockID = blockID;
            RoomNumber = roomNumber; 
        }

        public ICollection<Booking> Bookings { get; set; }
        public Block Blocks { get; set; }

    }
}
