using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1Assignment1.Models
{
    public class Student
    {
        //StudentId, First Name, Last Name, Email address, and Phone number.
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Course { get; set; }

    }
}
