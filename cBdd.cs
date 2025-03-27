﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public static int CbConvertInt(bool cb)
        {
            int result = 0;
            if (cb)
            {
                result = 1;
            }
            return result;
        }
        public static bool CbConvertBool(int cb)
        {
            int result = false;
            if (cb)
            {
                result = true;
            }
            return result;
        }

        public static string DateConvert(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }


        #region cUtilisateur
        public static DataTable SelectOneUser(int user_id)
        {
            return ExecuteSelectToDataTable($"SELECT Nom, Prenom, Date_de_naissance, Numero, Email, Adresse, Zip,Ville FROM utilisateur WHERE Id_Utilisateur = {user_id};");
        }
        public static MySqlDataReader SelectLogin(string username, string password)
        {
            return ExecuteSelect($"SELECT Id_Utilisateur FROM utilisateur WHERE Email = '{username}' AND Mot_de_passe = '{password}' ;");
        }


        public static DataTable SelectRole(int id_user)
        {
            return cBdd.ExecuteSelectToDataTable($"SELECT isAdmin, isService, isRh, IsInfo, IsPaie, IsReunion, IsVehicule FROM Role WHERE Id_Utilisateur = {id_user};");
        }

        public static int InsertNewUser(string Name, string Prenom, string dateDeNaissance, string uneAdresse, int unZip, string uneVille, int unNumero ,string unMail, string unPassword)
        {
           
            int result = ExecuteQuery($"INSERT INTO utilisateur (Nom, Prenom, Date_de_naissance,  Adresse, Zip, Ville, Numero, Email, Mot_de_passe) " +
                           $"VALUES ('{Name}', '{Prenom}', '{dateDeNaissance}','{uneAdresse}', '{unZip}', '{uneVille}', '{unNumero}', '{unMail}', '{unPassword}')");
            int isUser = 1;

            int lastid = ExecuteQuery2($"SELECT LAST_INSERT_ID() from utilisateur;");

            ExecuteQuery($"INSERT INTO Role (Id_utilisateur, IsUser) VALUES ('{lastid}', '{isUser}')");

            return result;
        }

        
          public static int UpdateUser(string Name, string Prenom, string dateDeNaissance, string uneAdresse, int unZip, string uneVille, int unNumero, string unMail, int id_user)
        {

            return ExecuteQuery($"UPDATE utilisateur set Nom = '{Name}', Prenom = '{Prenom}', Date_de_naissance =  '{dateDeNaissance}',  Adresse = '{uneAdresse}', Zip = '{unZip}', " +
                $"Ville = '{uneVille}', Numero = '{unNumero}', Email = '{unMail}' where Id_Utilisateur= '{id_user}';");

        }



        #endregion


        #region cDemande

        public static DataTable SelectListDemande(int id_user, int cbprioritaire)
        {
            return ExecuteSelectToDataTable($"select id_demande, Prioritaire, statut, type_demande, Objet_demande, Commentaire, Duree_debut," +
                $" Duree_fin from demande where Id_Utilisateur= '{id_user}' and Prioritaire = '{cbprioritaire}';");


        }


        public static DataTable SelectHistorique(int statut, int id_user)
        {
            return ExecuteSelectToDataTable($"select Objet_demande, type_demande, duree_debut, duree_fin from demande where statut = '{statut}' and id_utilisateur= '{id_user}' ;");


        }
#endregion
    }
}
