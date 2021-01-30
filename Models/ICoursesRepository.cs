using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public interface ICoursesRepository
    {
        Course GetCourses(int Id);
        IEnumerable<Course> AllCourse();
    }
}
