using PetInfoServer.DAL.Interfaces;
using PetInfoServer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PetInfoServer.DAL
{
    public class OwnerDAO :IOwnerDAO
    {

        private string connectionString;

        private string sqlGetOwners = "SELECT * FROM owner;";


        public OwnerDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Owner> GetOwners()
        {
            List<Owner> owners = new List<Owner>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(sqlGetOwners, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Owner owner = new Owner();
                    owner.Id = Convert.ToInt32(reader["id"]);
                    owner.Name = Convert.ToString(reader["name"]);
                    owner.Email = Convert.ToString(reader["email"]);
                    owner.Address = Convert.ToString(reader["address"]);
                    owner.Phone = Convert.ToString(reader["phone"]);
                    owners.Add(owner);
                }
            }

            return owners;
        }
    }
}
