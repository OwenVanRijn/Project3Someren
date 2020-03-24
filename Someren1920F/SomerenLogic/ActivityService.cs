using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;
using System;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDAO activityDAO = new ActivityDAO();
        public List<Activity> GetActivities()
        {
            return activityDAO.GetActivities();
        }
        public void EditActivity(string omschrijving, string studenten, string begeleiders, string id)
        {
            int student_count = int.Parse(studenten);
            int begeleider_count = int.Parse(begeleiders);
            int id_parsed = int.Parse(id);
            Activity activity = new Activity()
            {
                Omschrijving = omschrijving,
                AantalStudenten = student_count,
                AantalBegeleiders = begeleider_count,
                Id = id_parsed
            };

            if (activityDAO.CheckForDupes(activity.Omschrijving, activity.Id))
                throw new Exception("Omschrijving already exists!");

            activityDAO.EditActivity(activity);
        }
        public void DeleteActivity(string activityId)
        {
            int id = int.Parse(activityId);
            activityDAO.DeleteActivity(id);
        }
    }
}
