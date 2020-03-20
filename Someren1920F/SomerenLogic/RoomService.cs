using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class RoomService
    {
        RoomDAO roomDAO = new RoomDAO();

        public List<Room> getRooms(bool deep)
        {
            List<Room> rooms = roomDAO.getAllRooms(deep);
            return rooms;

            // TODO: Add check and notification for zero results
        }
    }
}
