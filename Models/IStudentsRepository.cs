using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public interface IStudentsRepository
    {
        IEnumerable<Student> GetStudent(string Course);
        IEnumerable<Student> AllStudent();
    }
}
