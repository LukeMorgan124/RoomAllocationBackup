using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RoomAllocation3.Data;
using RoomAllocation3.Models;

namespace RoomAllocation3.Pages.Rooms
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly RoomAllocation3.Data.ApplicationDbContext _context;

        public IndexModel(RoomAllocation3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string RoomNumberSort { get; set; }
        public string BlockSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public IList<Room> Room { get; set; }

        public class RoomPlusBlock
        {
            public Room Room { get; set; }
            public Block Block { get; set; }
        }
        public PaginatedList<RoomPlusBlock> Rooms { get; set; }

        public async Task OnGetAsync(string sortOrder, int? pageIndex)
        {
            CurrentSort = sortOrder;
            RoomNumberSort = sortOrder == "Rnumber" ? "Rnumber_desc" : "Rnumber";
            BlockSort = String.IsNullOrEmpty(sortOrder) ? "Block_desc" : "";


            IQueryable<RoomPlusBlock> roomsIQ = from r in _context.Rooms
                                                         join b in _context.Blocks on r.BlockID equals b.BlockID
                                                         select new RoomPlusBlock() { Room = r, Block = b };




            switch (sortOrder)
            {
                case "Rnumber":
                    roomsIQ = roomsIQ.OrderBy(r => r.Room.RoomNumber);
                    break;
                case "Rnumber_desc":
                    roomsIQ = roomsIQ.OrderByDescending(r => r.Room.RoomNumber);
                    break;
                case "Block_desc":
                    roomsIQ = roomsIQ.OrderByDescending(r => r.Block.BlockName);
                    break;
                default:
                    roomsIQ = roomsIQ.OrderBy(r => r.Block.BlockName);
                    break;
            }

            int pageSize = 10;
            Rooms = await PaginatedList<RoomPlusBlock>.CreateAsync(
                roomsIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}