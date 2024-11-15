using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace HotelDatabaseOpgave
{
    public class DBClient
    {
        string connectionString = //"INSERT Connection string here and uncomment";

        public void ReadFacility()
        {
            string queryString = "select * from Facility";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);

                    Console.WriteLine($"{id} - {name}");
                }
            }
        }

        public void ReadSpecificFacility()
        {
            string queryString2 = "select * from Facility where Facility_No = 5";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString2, connection);
                command.Connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);

                    Console.WriteLine($"{id} - {name}");
                }
            }
        }

        public void CreateFacility()
        {
            string queryString3 = "Insert into Facility Values ('5', 'Cykeludlejning')";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString3, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateFacility()
        {
            string queryString4 = "Update Facility set Name = 'Hundefrisør' Where Facility_No = '5'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString4, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteFacillity()
        {
            string queryString4 = "Delete from Facility where Facility_No = '5'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString4, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }     
    }
}
