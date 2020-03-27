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

        public List<Activity> GetActivitiesByLecturer(int lecturerId)
        {
            return activityDAO.GetActivitiesByLecturer(lecturerId);
        }
        public void ChangeActivityLecturer(int activityId, int newLecturer, int oldLecturer)
        {
            activityDAO.ChangeActivityLecturer(activityId, newLecturer, oldLecturer);
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
        public void AddActivity(string omschrijving, string studenten, string begeleiders)
        {
            int student_count = int.Parse(studenten);
            int begeleider_count = int.Parse(begeleiders);

            if (String.IsNullOrEmpty(omschrijving))
                throw new Exception("Omschrijving is nothing");

            if (activityDAO.CheckForDupes(omschrijving, -1))
                throw new Exception("Omschrijving already exists!");

            activityDAO.AddActivity(omschrijving, student_count, begeleider_count);
        }
    }
}
