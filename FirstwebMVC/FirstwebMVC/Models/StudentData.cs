using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstwebMVC.Models
{
    public class StudentData
    {
        public static List<string> GetStudent()
        {
            List<string> std = new List<string>();
            std.Add("Student-6");
            std.Add("Student-7");
            std.Add("Student-8");
            std.Add("Student-9");
            std.Add("Student-10");

            return std;
        }

        public List<StudentInfo> GetStdModel()
        {
            List<StudentInfo> students = new List<StudentInfo>
            {
                new StudentInfo(){StudentID=100,FirstName="Student-",LastName="11",Age=22,Gender=Gender.Male},
                new StudentInfo()
                {
                    StudentID=101,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Female
                },
                new StudentInfo()
                {
                    StudentID=101,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Female
                },
                new StudentInfo()
                {
                    StudentID=101,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Female
                },
                new StudentInfo()
                {
                    StudentID=102,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Female
                },
                new StudentInfo()
                {
                    StudentID=103,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Female
                },
                new StudentInfo()
                {
                    StudentID=104,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Male
                },new StudentInfo()
                {
                    StudentID=105,
                    FirstName="Student-",
                    LastName="12",
                    Age=23,
                    Gender=Gender.Female
                }
            };
            return students;
        }
    }
}
