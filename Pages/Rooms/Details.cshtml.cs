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
    public class DetailsModel : PageModel
    {
        private readonly RoomAllocation3.Data.ApplicationDbContext _context;

        public DetailsModel(RoomAllocation3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.Rooms
                .Include(r => r.Bookings)
                .ThenInclude(b => b.Courses)
                .Include(r => r.Bookings)
                .ThenInclude(r => r.Teacher)         
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.RoomID == id);

            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
