using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class LecturersService
    {
        LecturersDAO lecturersDatabase = new LecturersDAO();

        public List<Lecturer> getLecturers()
        {
            try
            {
                List<Lecturer> Lecturer = lecturersDatabase.getAllLecturers();
                return Lecturer;
            }
            catch (Exception)
            {
                List<Lecturer> Lecturer = new List<Lecturer>();
                Lecturer a = new Lecturer
                {
                    name = "Mr. Test Lecturer",
                    number = 474791
                };
                Lecturer.Add(a);

                Lecturer b = new Lecturer
                {
                    name = "Mrs. Test Lecturer",
                    number = 197474
                };
                Lecturer.Add(b);

                return Lecturer;
            }
        }
    }
}
