using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDAO : Base
    {
        public List<Room> getAllRooms(bool deep)
        {
            string query = "SELECT id, capacity, teacher from room";
            return roomsMapper(ExecuteSelectQuery(query), deep);
        }

        private List<Room> roomsMapper(DataTable roomsTable, bool deepProperties)
        {
            List<Room> rooms = new List<Room>();


            if (roomsTable == null)
            {
                MessageBox.Show("There are no rooms in the database", "No rooms found",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return rooms;
            }

            foreach (DataRow roomRow in roomsTable.Rows)
            {
                Room room = new Room()
                {
                    type = !(bool)roomRow["teacher"],
                    number = (int)roomRow["id"],
                    capacity = (byte)roomRow["capacity"]
                };

                if (deepProperties)
                {
                    StudentDAO studentDAO = new StudentDAO();
                    LecturerDAO lecturersDAO = new LecturerDAO();

                    room.students = studentDAO.getStudentsByRoom((int)roomRow["id"]);
                    room.lecturers = lecturersDAO.getLecturersByRoom((int)roomRow["id"]);
                }

                rooms.Add(room);
            }

            return rooms;
        }
    }
}
