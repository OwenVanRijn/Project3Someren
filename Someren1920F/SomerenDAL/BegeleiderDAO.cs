using System.Collections.Generic;
using System.Data;
using System;
using SomerenModel;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class BegeleiderDAO : Base
    {
        public List<Begeleider> GetBegeleiders()
        {
            string query = "select DocentId from begeleiders";
            return BegeleiderMapper(ExecuteSelectQuery(query));
        }
        public void DeleteBegeleider(int begeleiderId)
        {
            string query = "DELETE FROM begeleiders WHERE DocentId = @id";
            SqlParameter[] args =
            {
                new SqlParameter("@id", begeleiderId)
            };
            ExecuteEditQuery(query, args);
        }
        public void AddBegeleider(int id)
        {
            string query = "INSERT INTO begeleiders (DocentId) VALUES (@id)";
            SqlParameter[] args =
            {
                new SqlParameter("@id", id)
            };
            ExecuteEditQuery(query, args);
        }
        private List<Begeleider> BegeleiderMapper(DataTable table)
        {
            List<Begeleider> begeleiders = new List<Begeleider>();

            foreach (DataRow row in table.Rows)
            {
                Begeleider begeleider = new Begeleider()
                {
                    DocentId = (int)row["DocentId"], 
                };
                begeleiders.Add(begeleider);
            }

            return begeleiders;
        }
    }
}
