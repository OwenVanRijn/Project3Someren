using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class Lecturers_DAO : Base
    {
        public List<Lecturer> Db_Get_All_Lecturers()
        {
            string query = "SELECT id, first, last FROM [user] WHERE teacher = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturer> ReadTables(DataTable dataTable)
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
