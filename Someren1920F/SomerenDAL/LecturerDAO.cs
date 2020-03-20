using System.Collections.Generic;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class LecturerDAO : Base
    {
        public List<Lecturer> getAllLecturers()
        {
            string query = "SELECT id, first, last FROM [user] WHERE teacher = 1";
            return lecturersMapper(ExecuteSelectQuery(query));
        }

        public List<Lecturer> getLecturersByRoom(int roomId)
        {
            string query = "SELECT id, first, last FROM [user] INNER JOIN user_room ON [user].id = user_room.[user] WHERE teacher = 1 AND user_room.room = " + roomId.ToString();
            return lecturersMapper(ExecuteSelectQuery(query));
        }

        private List<Lecturer> lecturersMapper(DataTable lecturersTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow lecturerRow in lecturersTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    name = lecturerRow["first"] + " " + lecturerRow["last"],
                    number = (int)lecturerRow["id"]
                };

                lecturers.Add(lecturer);
            }

            return lecturers;
        }
    }
}
