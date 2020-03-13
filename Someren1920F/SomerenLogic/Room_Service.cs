using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class Room_Service
    {
        Room_DAO room_DAO = new Room_DAO();

        public List<Lecturers> GetRooms()
        {
            try
            {
                List<Lecturers> rooms = room_DAO.Db_Get_All_Rooms();
                return rooms;
            }
            catch (Exception)
            {
                List<Lecturers> rooms = new List<Lecturers>();
                Lecturers a = new Lecturers();
                a.Number = 0;
                a.Capacity = 0;
                a.Type = false;
                return rooms;
            }
        }
    }
}
