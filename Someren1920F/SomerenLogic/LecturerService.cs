using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class LecturerService
    {
        LecturerDAO lecturerDAO = new LecturerDAO();

        public List<Lecturer> getLecturers()
        {
            List<Lecturer> lecturers = lecturerDAO.getAllLecturers();
            return lecturers;

            // TODO: Add check and notification for zero results
        }
    }
}
