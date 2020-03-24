using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenLogic
{
    public class ActivityService
    {
        ActivityDAO activityDAO = new ActivityDAO();
        public List<Activity> GetActivities()
        {
            return activityDAO.GetActivities();
        }
    }
}
