using System;
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
            bool result = false;
            if (cb == 1)
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
            return ExecuteSelectToDataTable($"SELECT isAdmin, isService, isRh, IsInfo, IsPaie, IsReunion, IsVehicule FROM Role WHERE Id_Utilisateur = {id_user};");
        }

        public static int InsertNewUser(string Name, string Prenom, string dateDeNaissance, string uneAdresse, int unZip, string uneVille, int unNumero, string unMail, string unPassword)
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


        public static DataTable SelectAccount(int id_user)
        {
            return ExecuteSelectToDataTable($"select Nom, Prenom, date_de_naissance, Numero, Email, Adresse, Zip, Ville from Utilisateur where Id_Utilisateur = '{id_user}' ;");
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

        public static DataTable SelectRequete(string type_demande, string statut)
        {
            string query = $" select d.id_demande,d.statut, u.nom,u.prenom, d.Objet_demande, d.duree_debut, d.duree_fin " +
             $"from demande d " +
             $"join utilisateur u on u.Id_Utilisateur = d.Id_Utilisateur " +
             $"where {type_demande} {statut} order by statut;";

            return ExecuteSelectToDataTable(query);



        }

        public static DataTable SelectService()
        {

            return ExecuteSelectToDataTable("select id_service, name_service from services;");

        }
        public static DataTable SelectReunion()
        {

            return ExecuteSelectToDataTable("select id_reunion, Nom_salle ,nb_place, numero from reunion;");

        }

        public static DataTable SelectVehicule()
        {

            return ExecuteSelectToDataTable("select id_vehicule, marque, modele,nb_place from vehicule;");

        }


        public static DataTable SelectBackDemande(int demande_id)
        {

            return ExecuteSelectToDataTable($"select objet_demande, Commentaire, type_demande, prioritaire, duree_debut, duree_fin from demande where id_demande = '{demande_id}';");

        }

        public static DataTable SelectBackCompleteDemande(int demande_id)
        {

            return ExecuteSelectToDataTable($" select type_demande, objet_demande, Commentaire, Prioritaire, duree_debut, duree_fin, motif_att  from demande d where Id_Demande =  '{demande_id}';");

        }
        public static DataTable SelectBackCompleteService(int demande_id)
        {

            return ExecuteSelectToDataTable($"select name_service as detailtype from services s join demande_services ds on s.id_service = ds.id_service where ds.id_demande = '{demande_id}';");

        }
        public static DataTable SelectBackCompleteReunion(int demande_id)
        {

            return ExecuteSelectToDataTable($"select Nom_salle as detailtype from reunion r join demande_reunion dr on r.id_reunion = dr.id_reunion where dr.id_demande = '{demande_id}';");

        }
        public static DataTable SelectBackCompleteVehicule(int demande_id)
        {

            return ExecuteSelectToDataTable($"select modele as detailtype  from vehicule v join demande_vehicule dv on v.id_vehicule = dv.id_vehicule where dv.id_demande = '{demande_id}';");

        }

        public static void ValideUpdate(int demande_id)
        {
            ExecuteQuery($"update demande set statut = '2'  where id_demande ='{demande_id}';");

        }
        public static void ValideRDVUpdate(int demande_id)
        {
            ExecuteQuery($"update demande set statut = '5' where id_demande ='{demande_id}';");

        }

        public static void AttenteUpdate(int demande_id, string mess_att)
        {

            ExecuteQuery($"update demande set statut = '3',motif_att = '{mess_att}' where id_demande ='{demande_id}';");

        }
        public static void DeleteUpdate(string mess_refu, int demande_id)
        {

            ExecuteQuery($"update demande set statut = '4', motif_refu = '{mess_refu}' where id_demande ='{demande_id}';");

        }
        public static void ClotureUpdate(string mess_clo, int demande_id)
        {

            ExecuteQuery($"update demande set statut = '6', motif_clo = '{mess_clo}' where id_demande ='{demande_id}';");

        }

        public static void InsertDemandeSave(int untype_demande, string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user, int statut, int AdminNotif)
        {

            ExecuteQuery($"INSERT INTO demande (type_demande , Objet_demande , Commentaire, Prioritaire,  Duree_debut, Duree_fin, statut, " +
                         $"Id_Utilisateur, Adminnotif) VALUES ('{untype_demande}', '{unObjet}', '{unCommetaire}', '{unPrioritaire}','{uneDuree_debut}'," +
                         $"'{UneDuree_fin}', '{statut}', '{id_user}', '{AdminNotif}');");

        }

        public static void InsertServiceSave(int super_id)
        {

            ExecuteQuery($"INSERT INTO demande_services (id_service, Id_demande) " +
                           $" values('{super_id}','{LastidDemande()}');");

        }

        public static void InsertReunionSave(int super_id)
        {

            ExecuteQuery($"INSERT INTO demande_reunion (id_reunion, Id_demande) " +
                         $" values('{super_id}','{LastidDemande()}');");

        }

        public static void InsertVehiculeSave(int super_id)
        {

            ExecuteQuery($"INSERT INTO demande_vehicule (id_vehicule, Id_demande) " +
                         $" values('{super_id}','{LastidDemande()}');");

        }



        public static int LastidDemande()
        {

            return Convert.ToInt32(ExecuteQuery2("select max(id_demande) as last_id from demande ;"));

        }

        public static void UpdateAdminNotif()
        {

            ExecuteQuery($"update demande set Adminnotif = '1' where id_demande ='{cDemande.id_demande}';");


            ExecuteQuery($"update demande set Usernotif = '0' where id_demande ='{cDemande.id_demande}' ;");

        }

        public static void UpdateUserNotif()
        {

            ExecuteQuery($"update demande set Adminnotif = '0' where id_demande ='{cDemande.id_demande}';");


            ExecuteQuery($"update demande set Usernotif = '1' where id_demande ='{cDemande.id_demande}' ;");

        }

        public static int SelectTypeDemande(int demande_id)
        {

            return ExecuteQuery($"select type_demande from demande where id_demande = '{demande_id}';");

        }

        public static void DeleteDemandeServices(int demande_id)
        {

            ExecuteQuery($"delete from demande_services where id_demande ='{demande_id}' ;");
        }


        public static void DeleteDemandeReunion(int demande_id)
        {

            ExecuteQuery($"delete from demande_reunion where id_demande ='{demande_id}';");
        }


          public static void DeleteDemandeVehicule(int demande_id)
        {

            ExecuteQuery($"delete from demande_services where id_demande ='{demande_id}';");
        }


        public static void DeleteDemande(int demande_id)
        {

            ExecuteQuery($"delete from demande where id_demande ='{demande_id}';");
        }


        public static void UpdateNoNotif()
        {

            ExecuteQuery($"update demande set Adminnotif = '0' where id_demande ='{cDemande.id_demande}';");


            ExecuteQuery($"update demande set Usernotif = '0' where id_demande ='{cDemande.id_demande}' ;");

        }
        public static void OnNotifHisto()
        {

            ExecuteQuery($"update demande set Histonotif = '1' where id_demande ='{cDemande.id_demande}';");

        }


        public static void OffNotifHisto()
        {

            ExecuteQuery($"update demande set Histonotif = '0' where id_utilisateur ='{cUtilisateur.user_id}';");

        }

        public static int CountNotifGestion(int type)
        {

            return ExecuteQuery2($"select count(Adminnotif) from demande where Adminnotif = 1 and type_demande = '{type}';");

        }
        public static int CountNotifDemande()
        {

            return ExecuteQuery2($"select count(Usernotif) from demande where Usernotif = 1 and id_utilisateur = '{cUtilisateur.user_id}';");

        }

        public static int CountNotifHisto()
        {

            return ExecuteQuery2($"select count(Histonotif) from demande where Histonotif = 1 and id_utilisateur = '{cUtilisateur.user_id}';");

        }









        #endregion


    }
}