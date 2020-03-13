using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class Room_Service
    {
        Room_DAO room_DAO = new Room_DAO();

        public List<Room> GetRooms()
        {
            try
            {
                List<Room> rooms = room_DAO.Db_Get_All_Rooms();
                return rooms;
            }
            catch (Exception)
            {
                List<Room> rooms = new List<Room>();
                Room a = new Room();
                a.Number = 0;
                a.Capacity = 0;
                a.Type = false;
                return rooms;
            }
        }
    }
}
