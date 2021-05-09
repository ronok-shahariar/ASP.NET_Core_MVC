using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstwebMVC.Models
{
    public enum Gender
    {
        Male,Female
    }
    public class StudentInfo
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fullname
        {
            get { return (FirstName + " " + LastName); }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
