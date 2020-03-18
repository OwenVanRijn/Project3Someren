using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class RoomService
    {
        RoomDAO roomDAO = new RoomDAO();

        public List<Room> getRooms(bool deep)
        {
            try
            {
                List<Room> rooms = roomDAO.getAllRooms(deep);
                return rooms;
            }
            catch (Exception)
            {
                List<Room> rooms = new List<Room>();
                Room a = new Room();
                a.number = 0;
                a.capacity = 0;
                a.type = false;
                return rooms;
            }
        }
    }
}
