using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class StudentDAO : Base
    {
      
        public List<Student> databaseGetAllStudents()
        {
            string query = "SELECT id, first, last FROM [user] WHERE teacher = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return readTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> readTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    number = (int)dr["id"],
                    name = (string)(dr["first"].ToString()) + " " + (String)(dr["last"].ToString())
                };
                students.Add(student);
            }
            return students;
        }

    }
}
