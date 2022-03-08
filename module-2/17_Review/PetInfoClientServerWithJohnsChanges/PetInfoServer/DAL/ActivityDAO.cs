using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PetInfoServer.DAL
{
    public class ActivityDAO :IActivityDAO
    {

        private string connectionString;

        private string sqlGetActivities= "SELECT * FROM activity;";


        public ActivityDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Activity> GetActivities()
        {
            List<Activity> activities = new List<Activity>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlGetActivities, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Activity activity = new Activity();
                    activity.Id = Convert.ToInt32(reader["id"]);
                    activity.Name = Convert.ToString(reader["name"]);
                    activity.Date = Convert.ToDateTime(reader["date"]);
                    activity.Pet = Convert.ToInt32(reader["pet"]);
;
                    activities.Add(activity);
                }
            }

            return activities;
        }
    }
}
