using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoomAllocation3.Data;
using RoomAllocation3.Models;

namespace RoomAllocation3.Pages.Bookings
{
    [Authorize]
    public class EditModel : CourseNamePageModel
    {
        private readonly RoomAllocation3.Data.ApplicationDbContext _context;

        public EditModel(RoomAllocation3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Booking = await _context.Bookings
                .Include(b => b.Courses)
                .Include(b => b.Teacher)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.BookingID == id);

            if (Booking.Booked == true)
            {
                return RedirectToPage("/RoomBooked");
            }

            if (Booking == null)
            {
                return NotFound();
            }
            PopulateCourseDropDownList(_context, Booking.CourseID);
            PopulateTeacherDropDownList(_context, Booking.TeacherID);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var BookingToUpdate = await _context.Bookings.FindAsync(id);

            if (BookingToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Booking>(BookingToUpdate, "Booking", b => b.CourseID, b => b.TeacherID))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("/Rooms/Index");
            }
            PopulateCourseDropDownList(_context, BookingToUpdate.CourseID);
            PopulateTeacherDropDownList(_context, BookingToUpdate.TeacherID);
            return Page();
        }
    }
}
