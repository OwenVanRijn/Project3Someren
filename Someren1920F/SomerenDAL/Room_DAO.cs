﻿using System;
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
    public class Room_DAO : Base
    {
        public List<Lecturers> Db_Get_All_Rooms()
        {
            string query = "SELECT id, capacity, teacher from room";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Lecturers> ReadTables(DataTable dataTable)
        {
            List<Lecturers> rooms = new List<Lecturers>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Lecturers room = new Lecturers()
                {
                    Number = (int)dr["id"],
                    Capacity = (byte)dr["capacity"],
                    Type = !(bool)dr["teacher"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
