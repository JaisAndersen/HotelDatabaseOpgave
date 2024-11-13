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
        public void ReadFacility()
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            string queryString2 = "select * from Facility where Facility_No = 4";
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
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HotelDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
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
