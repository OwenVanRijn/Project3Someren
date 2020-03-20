using System.Collections.Generic;
using System.Data;
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
                    LecturersDAO lecturersDAO = new LecturersDAO();

                    room.students = studentDAO.getStudentsByRoom((int)roomRow["id"]);
                    room.lecturers = lecturersDAO.getLecturersByRoom((int)roomRow["id"]);
                }

                rooms.Add(room);
            }

            return rooms;
        }
    }
}
