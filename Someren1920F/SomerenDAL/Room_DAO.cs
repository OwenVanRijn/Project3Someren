using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class RoomDAO : Base
    {
        public List<Room> databaseGetAllRooms(bool deep)
        {
            string query = "SELECT id, capacity, teacher from room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readRoomTables(ExecuteSelectQuery(query, sqlParameters), deep);
        }

        private List<Student> databaseGetStudentsByRoom(int roomId)
        {
            string query = "SELECT id, first, last FROM [user] INNER JOIN user_room ON [user].id = user_room.[user] WHERE teacher = 0 AND user_room.room = " + roomId.ToString();
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readStudentTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> databaseGetLecturersByRoom(int roomId)
        {
            string query = "SELECT id, first, last FROM [user] INNER JOIN user_room ON [user].id = user_room.[user] WHERE teacher = 1 AND user_room.room = " + roomId.ToString();
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readLecturerTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> readRoomTables(DataTable dataTable, bool deep)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    number = (int)dr["id"],
                    capacity = (byte)dr["capacity"],
                    type = !(bool)dr["teacher"]
                };

                if (deep)
                {
                    room.students = databaseGetStudentsByRoom((int)dr["id"]);
                    room.lecturers = databaseGetLecturersByRoom((int)dr["id"]);
                }

                rooms.Add(room);
            }
            return rooms;
        }

        private List<Student> readStudentTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    number = (int)dr["id"],
                    name = (String)(dr["first"].ToString()) + " " + (String)(dr["last"].ToString())
                };
                students.Add(student);
            }
            return students;
        }

        private List<Lecturer> readLecturerTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    number = (int)dr["id"],
                    name = (String)(dr["first"].ToString()) + " " + (String)(dr["last"].ToString())
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
