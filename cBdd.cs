using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace REL
{
    public static class cBdd
    {
        private static string connectionString = "server=localhost;database=REL;uid=root;pwd=root;";
        private static MySqlConnection connection = null;

        public static MySqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new MySqlConnection(connectionString);
            }
            return connection;
        }

        public static void OpenConnection()
        {
            if (connection == null)
                connection = GetConnection();

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static int ExecuteQuery(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int result = cmd.ExecuteNonQuery(); // exe update delete insert
            CloseConnection();
            return result;
        }

        public static int ExecuteQuery2(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader rdr = cmd.ExecuteReader(); // exe uniquement select
            if (rdr.Read())
            {
                int result = Convert.ToInt16(rdr.GetValue(0));
                CloseConnection();
                return result;
            }
            else
            {
                CloseConnection();
                return -10;
            }
        }
        public static DataTable ExecuteSelectToDataTable(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            CloseConnection();
            return dataTable;
        }


        public static MySqlDataReader ExecuteSelect(string query)
        {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            return cmd.ExecuteReader();
        }

        public static int CbConvert(bool cb)
        {
            int result = 0;
            if (cb)
            {
                result = 1;
            }
            return result;
        }

        public static string DateConvert(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }



        public static DataTable SelectOneUser(cUtilisateur cUtilisateur)
        {
            
            string query = $"SELECT Nom, Prenom, Date_de_naissance, Numero, Email, Adresse, Zip,Ville FROM utilisateur WHERE Id_Utilisateur = {cUtilisateur.user_id};";
            DataTable result = ExecuteSelectToDataTable(query);
            return result;
        }

       

















    }
}
