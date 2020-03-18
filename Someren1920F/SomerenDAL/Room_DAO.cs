using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Room_DAO : Base
    {
        public List<Room> Db_Get_All_Rooms(bool deep)
        {
            string query = "SELECT id, capacity, teacher from room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadRoomTables(ExecuteSelectQuery(query, sqlParameters), deep);
        }

        private List<Student> Db_Get_Students_By_Room(int roomId)
        {
            string query = "SELECT id, first, last FROM [user] INNER JOIN user_room ON [user].id = user_room.[user] WHERE teacher = 0 AND user_room.room = " + roomId.ToString();
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadStudentTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> Db_Get_Lecturers_By_Room(int roomId)
        {
            string query = "SELECT id, first, last FROM [user] INNER JOIN user_room ON [user].id = user_room.[user] WHERE teacher = 1 AND user_room.room = " + roomId.ToString();
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadLecturerTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadRoomTables(DataTable dataTable, bool deep)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (int)dr["id"],
                    Capacity = (byte)dr["capacity"],
                    Type = !(bool)dr["teacher"]
                };

                if (deep)
                {
                    room.Students = Db_Get_Students_By_Room((int)dr["id"]);
                    room.Lecturers = Db_Get_Lecturers_By_Room((int)dr["id"]);
                }

                rooms.Add(room);
            }
            return rooms;
        }

        private List<Student> ReadStudentTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["id"],
                    Name = (String)(dr["first"].ToString()) + " " + (String)(dr["last"].ToString())
                };
                students.Add(student);
            }
            return students;
        }

        private List<Lecturer> ReadLecturerTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    Number = (int)dr["id"],
                    Name = (String)(dr["first"].ToString()) + " " + (String)(dr["last"].ToString())
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
