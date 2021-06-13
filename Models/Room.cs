using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Room
    {

        public int RoomID { get; set; }
        public int BlockID{ get; set; }
        public string RoomNumber { get; set; }


        public Room(string roomNumber)
        {
            RoomNumber = roomNumber;
            
        }

        public ICollection<Room> Rooms { get; set; }
    }
}
