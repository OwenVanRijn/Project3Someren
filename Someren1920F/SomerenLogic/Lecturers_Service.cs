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
        Lecturers_DAO Lecturers_db = new Lecturers_DAO();

        public List<Lecturer> GetLecturers()
        {
            try
            {
                List<Lecturer> Lecturer = Lecturers_db.Db_Get_All_Lecturers();
                return Lecturer;
            }
            catch (Exception)
            {
                List<Lecturer> Lecturer = new List<Lecturer>();
                Lecturer a = new Lecturer();
                a.Name = "Mr. Test Lecturer";
                a.Number = 474791;
                Lecturer.Add(a);

                Lecturer b = new Lecturer();
                b.Name = "Mrs. Test Lecturer";
                b.Number = 197474;
                Lecturer.Add(b);

                return Lecturer;
            }
        }
    }
}
