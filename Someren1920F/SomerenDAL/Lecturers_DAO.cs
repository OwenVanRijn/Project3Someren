using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Lecturers_DAO : Base
    {
        public List<Student> Db_Get_All_Lecturers()
        {
            string query = "SELECT id FIRST from [user] WHERE teacher = 1";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["id"],
                    Name = (String)(dr["first"].ToString())
                };
                students.Add(student);
            }
            return students;
        }
    }
}
