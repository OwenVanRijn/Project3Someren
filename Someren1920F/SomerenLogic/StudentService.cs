using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class StudentService
    {
        StudentDAO studentDAO = new StudentDAO();

        public List<Student> getStudents()
        {
            List<Student> students = studentDAO.getAllStudents();
            return students;

            // TODO: Add check and notification for zero results
        }
    }
}
