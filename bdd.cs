using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace REL
{
    public static class Bdd
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
            int result = cmd.ExecuteNonQuery();
            CloseConnection();
            return result;
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
        
        public static bool validLogin(string username, string password)
        {

            string query = $"SELECT * FROM utilisateur WHERE Email = '{username}' AND Mot_de_passe = '{password}'";

            try
            {
                MySqlDataReader reader = Bdd.ExecuteSelect(query);

                if (reader.HasRows)
                {
                    reader.Close();
                    return true;

                }
                else
                {

                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
                return false;
            }
        }
        public static int Validregister(string unName, string unPrenom, string dateDeNaissance,string unMail, string unPassword, string uneAdresse, string unZip, string uneVille, string unNumero)
        {
            int isClientValue =  1;


            string query = $"INSERT INTO utilisateur (Nom, Prenom, Date_de_naissance,  Adresse, Zip, Ville, Numero, IsClient, Email, Mot_de_passe) " +
                           $"VALUES ('{unName}', '{unPrenom}', '{dateDeNaissance}','{uneAdresse}', '{unZip}', '{uneVille}', '{unNumero}', {isClientValue}, '{unMail}', '{unPassword}')";

            int result = Bdd.ExecuteQuery(query);
            return result;
        }



    }
}
