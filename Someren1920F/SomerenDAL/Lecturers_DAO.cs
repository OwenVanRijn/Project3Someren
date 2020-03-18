using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class LecturersDAO : Base
    {
        public List<Lecturer> databaseGetAllLecturers()
        {
            string query = "SELECT id, first, last FROM [user] WHERE teacher = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> readTables(DataTable dataTable)
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturer lecturer = new Lecturer()
                {
                    number = (int)dr["id"],
                    name = (string)(dr["first"].ToString()) + " " + (String)(dr["last"].ToString())
                };
                lecturers.Add(lecturer);
            }
            return lecturers;
        }
    }
}
