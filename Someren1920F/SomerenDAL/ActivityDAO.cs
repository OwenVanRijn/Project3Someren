using System.Collections.Generic;
using System.Data;
using SomerenModel;

namespace SomerenDAL
{
    public class ActivityDAO : Base
    {
        public List<Activity> GetActivities()
        {
            string query = "select id, omschrijving, aantalstudenten, aantalbegeleiders from activity";
            return ActivityMapper(ExecuteSelectQuery(query));
        }
        private List<Activity> ActivityMapper(DataTable table)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow row in table.Rows)
            {
                Activity activity = new Activity()
                {
                    Id = (int)row["id"],
                    Omschrijving = (string)row["omschrijving"],
                    AantalStudenten = (int)row["aantalstudenten"],
                    AantalBegeleiders = (int)row["aantalbegeleiders"]
                };
                activities.Add(activity);
            }

            return activities;
        }
    }
}
