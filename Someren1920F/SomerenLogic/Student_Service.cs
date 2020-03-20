using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class StudentService
    {
        StudentDAO studentDatabase = new StudentDAO();

        public List<Student> getStudents()
        {
            try
            {
                List<Student> student = studentDatabase.getAllStudents();
                return student;
            }
            catch (Exception)
            {
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Student> student = new List<Student>();
                Student a = new Student
                {
                    name = "Mr. Test Student",
                    number = 474791,
                    birthDate = DateTime.Parse("1990-07-04")
                };
                student.Add(a);

                Student b = new Student
                {
                    name = "Mrs. Test Student",
                    number = 197474,
                    birthDate = DateTime.Parse("2019-03-04")
                };
                student.Add(b);
                return student;
                //throw new Exception("Someren couldn't connect to the database");
            }

        }
    }
}
