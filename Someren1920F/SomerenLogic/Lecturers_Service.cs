using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Lecturers_Service
    {
        Student_DAO student_db = new Student_DAO();

        public List<Student> GetLecturers()
        {
            try
            {
                List<Student> Lecturer = student_db.Db_Get_All_Students();
                return Lecturer;
            }
            catch (Exception)
            {
                List<Student> Lecturer = new List<Student>();
                Student a = new Student();
                a.Name = "Mr. Test Student";
                a.Number = 474791;
                a.BirthDate = DateTime.Parse("1990-07-04");
                Lecturer.Add(a);

                Student b = new Student();
                b.Name = "Mrs. Test Student";
                b.Number = 197474;
                b.BirthDate = DateTime.Parse("2019-03-04");
                Lecturer.Add(b);

                return Lecturer;
            }
        }
    }
}
