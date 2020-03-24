using System.Collections.Generic;
using System.Data;
using System;
using SomerenModel;
using System.Data.SqlClient;

namespace SomerenDAL
{
    public class ActivityDAO : Base
    {
        public List<Activity> GetActivities()
        {
            string query = "select id, omschrijving, aantalstudenten, aantalbegeleiders from activity";
            return ActivityMapper(ExecuteSelectQuery(query));
        }
        public void EditActivity(Activity activity)
        {
            string query = "UPDATE activity SET omschrijving = @omsch, aantalBegeleiders = @begamnt, aantalStudenten = @sdntamnt WHERE id = @id";
            SqlParameter[] args =
            {
                new SqlParameter("@omsch", activity.Omschrijving),
                new SqlParameter("@begamnt", activity.AantalBegeleiders),
                new SqlParameter("@sdntamnt", activity.AantalStudenten),
                new SqlParameter("@id", activity.Id)
            };
            ExecuteEditQuery(query, args);
        }
        public void DeleteActivity(int activityId)
        {
            string query = "DELETE FROM activity WHERE id = @id";
            SqlParameter[] args =
            {
                new SqlParameter("@id", activityId)
            };
            ExecuteEditQuery(query, args);
        }
        public bool CheckForDupes(string Omschrijving, int id)
        {
            string query = "select COUNT(*) AS [count] from activity where omschrijving = @check AND id != @id";
            SqlParameter[] args =
            {
                new SqlParameter("@check", Omschrijving),
                new SqlParameter("@id", id)
            };
            int count = (int)ExecuteSelectQuery(query, args).Rows[0]["count"];

            return (count > 0);
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
