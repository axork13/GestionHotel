using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace GestionHotel.Classes
{
    public class Database
    {
        private static DataSet _instance = null;
        private static object _lock = new object();
        private static SqlDataAdapter adapterClient;
        private static SqlDataAdapter adapterReservation;

        public static DataSet Instance
        {
            get
            {
                lock(_lock)
                {
                    if (_instance == null)
                        _instance = new DataSet();
                    return _instance;
                }
            }
        }

        private Database()
        {

        }

        public static void Init()
        {
            adapterClient = new SqlDataAdapter("SELECT * FROM Client", Connection.Instance);
            adapterReservation = new SqlDataAdapter("SELECT * FROM Reservation", Connection.Instance);

            Connection.Instance.Open();
            adapterClient.Fill(Instance, "Clients");
            adapterReservation.Fill(Instance, "Reservations");
            Connection.Instance.Close();
        }

        public static void Update()
        {
            SqlCommand commandInsertClient = new SqlCommand("INSERT INTO Client (Nom, Adresse, Tel) VALUES (@n, @a, @t)", Connection.Instance);
            commandInsertClient.Parameters.Add("@n", SqlDbType.VarChar, 50, "Nom");
            commandInsertClient.Parameters.Add("@a", SqlDbType.VarChar, 100, "Adresse");
            commandInsertClient.Parameters.Add("@t", SqlDbType.VarChar, 10, "Tel");
            adapterClient.InsertCommand = commandInsertClient;

            SqlCommand commandInsertReservation = new SqlCommand("INSERT INTO Reservation (Code, IDClient, Statut) VALUES (@c, @i, @s)", Connection.Instance);
            commandInsertReservation.Parameters.Add("@c", SqlDbType.VarChar, 36, "Code");
            commandInsertReservation.Parameters.Add("@i", SqlDbType.Int, 10, "IDClient");
            commandInsertReservation.Parameters.Add("@s", SqlDbType.VarChar, 6, "Statut");
            adapterReservation.InsertCommand = commandInsertReservation;

            SqlCommand commandUpdateReservation = new SqlCommand("UPDATE Reservation set Statut = @s WHERE Code = @c", Connection.Instance);
            commandUpdateReservation.Parameters.Add("@s", SqlDbType.VarChar, 6, "Statut");
            commandUpdateReservation.Parameters.Add("@c", SqlDbType.VarChar, 36, "Code");
            adapterReservation.UpdateCommand = commandUpdateReservation;
        }
    }
}
