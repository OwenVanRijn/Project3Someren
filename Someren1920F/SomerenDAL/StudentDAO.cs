using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDAO : Base
    {
        public List<Student> getAllStudents()
        {
            string query = "SELECT id, first, last FROM [user] WHERE teacher = 0";
            return studentsMapper(ExecuteSelectQuery(query));
        }

        public List<Student> getStudentsByRoom(int roomId)
        {
            string query = "SELECT id, first, last FROM [user] INNER JOIN user_room ON [user].id = user_room.[user] WHERE teacher = 0 AND user_room.room = " + roomId.ToString();
            return studentsMapper(ExecuteSelectQuery(query));
        }

        private List<Student> studentsMapper(DataTable studentsTable)
        {
            List<Student> students = new List<Student>();

            if (studentsTable == null)
            {
                MessageBox.Show("There are no students in the database", "No students found",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return students;
            }

            foreach (DataRow studentRow in studentsTable.Rows)
            {
                Student student = new Student()
                {
                    name = studentRow["first"] + " " + studentRow["last"],
                    number = (int)studentRow["id"]
                };

                students.Add(student);
            }

            return students;
        }
    }
}
