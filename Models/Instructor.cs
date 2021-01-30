using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class Instructor
    {
        //InstructorId, First Name, Last Name, 
        //Email address, and the Course that they teach
        public int InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Course { get; set; }
    }
}
