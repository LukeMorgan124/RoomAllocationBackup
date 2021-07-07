using RoomAllocation3.Data;
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
        public SelectList TeacherCodeSL { get; set; }

        public void PopulateTeacherDropDownList(ApplicationDbContext _context, object selectedTeacher = null)
        {
            var teachersQuery = from t in _context.Teachers
                               orderby t.TeacherCode
                               select t;

            TeacherCodeSL = new SelectList(teachersQuery.AsNoTracking(),
                        "TeacherID", "TeacherCode", selectedTeacher);
        }
    }
}