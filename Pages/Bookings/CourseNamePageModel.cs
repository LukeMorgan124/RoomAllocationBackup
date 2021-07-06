﻿using RoomAllocation3.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace RoomAllocation3.Pages.Bookings
{
    public class CourseNamePageModel : PageModel
    {
        public SelectList CourseNameSL { get; set; }

        public void PopulateCourseDropDownList(ApplicationDbContext _context, object selectedCourse = null)
        {
            var coursesQuery = from d in _context.Courses
                               orderby d.CourseYear
                               select d;

            CourseNameSL = new SelectList(coursesQuery.AsNoTracking(),
                        "CourseID", "CourseYear", selectedCourse);
        }
    }
}