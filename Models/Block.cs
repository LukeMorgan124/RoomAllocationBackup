using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomAllocation3.Models
{
    public class Block
    {

        public int BlockID { get; set; }
        public string BlockName { get; set; }
        
        public ICollection<Room> Rooms { get; set; }
    }
}
