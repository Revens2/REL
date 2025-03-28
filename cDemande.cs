using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REL
{
    internal class cDemande
    {

        private string objet;
        private string commentaire;
        

        private bool prioritaire;
        DateTime duree_debut;
        DateTime duree_fin;

        private int statut;

        private bool final;

        public static int id_demande;

        public static int Id_demande

        {
            get { return id_demande; }
            set { id_demande = value; }
        }

        public static bool isrequest;

        public static bool Isrequest

        {
            get { return isrequest; }
            set { isrequest = value; }
        }

        public static bool isnewstatut;
        public static bool Isnewstatut

        {
            get { return isnewstatut; }
            set { isnewstatut = value; }
        }

        public int Statut

        {
            get { return statut; }
            set { statut = value; }
        }
        public bool Final

        {
            get { return final; }
            set { final = value; }
        }
        public cDemande()
        {

        }
        public cDemande(string unObjet, string unCommetaire, bool unPrioritaire, DateTime uneDuree_debut, DateTime UneDuree_fin)
        {

            this.objet = unObjet;
            this.commentaire = unCommetaire;
            this.prioritaire = unPrioritaire;
            this.duree_debut = uneDuree_debut;
            this.duree_fin = UneDuree_fin;

        }

        #region List 
        public DataTable listDemande(int cbprioritaire)
        {
            return cBdd.SelectListDemande(cUtilisateur.user_id, cbprioritaire);
            
        }

        public DataTable listrequete()
        {
            int type = cUtilisateur.GetAccounType();
            string statut = "d.statut = 1 or d.statut = 3 ";
            if (final)
            {
                statut = "d.statut = 5";
            }
               string type_demande = $"d.type_demande = '{type}' and";
            if (cUtilisateur.isAdmin)
            {
                 type_demande = "";
            }

            DataTable result = cBdd.SelectRequete(type_demande, statut);
            return result;
        }

        public DataTable listHistorique()
        {
            return cBdd.SelectHistorique(statut, cUtilisateur.user_id);
            
        }
        public static DataTable ListService()
        {

            return cBdd.SelectService();

        }

        public static DataTable ListReunion()
        {

            return cBdd.SelectReunion();

        }

        public static DataTable ListVehicule()
        {

            return cBdd.SelectVehicule();

        }

        public static DataTable ListBackDemande(int demande_id)
        {

            return cBdd.SelectBackDemande(demande_id);

        }

        public static DataTable ListBackCompleteDemande(int demande_id)
        {
            DataTable dt = cBdd.SelectBackCompleteDemande(demande_id);
            dt.Columns.Add("detailtype", typeof(string));
            DataTable dtDetail= null;
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int type = Convert.ToInt32(row["type_demande"]);
                
                switch (type)
                {
                    case 1:
                        dtDetail = cBdd.SelectBackCompleteService(demande_id);
                        break;
                    case 2:
                        dtDetail = cBdd.SelectBackCompleteReunion(demande_id);
                        break;
                    case 3:
                        dtDetail = cBdd.SelectBackCompleteVehicule(demande_id);
                        break;
                }
                dt.Rows[0]["detailtype"] = dtDetail.Rows[0]["detailtype"].ToString();
            }

            return dt;
        }

        #endregion


        #region Save
        public static void DemandeSave(int untype_demande, string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user, int super_id)
        {
            int statut = 1;
            int AdminNotif = 1;

            string query = $"INSERT INTO demande (type_demande , Objet_demande , Commentaire, Prioritaire,  Duree_debut, Duree_fin, statut, Id_Utilisateur, Adminnotif) " +
                           $"VALUES ('{untype_demande}', '{unObjet}', '{unCommetaire}', '{unPrioritaire}','{uneDuree_debut}', '{UneDuree_fin}', '{statut}', '{id_user}', '{AdminNotif}');";


            cBdd.ExecuteQuery(query);

            switch (untype_demande)
            {
                case 1:
                    string query2 = $"insert into demande_services (id_service, Id_demande) " +
                           $" values('{super_id}','{Lastid()}');";

                    cBdd.ExecuteQuery(query2);
                    break;
                case 2:
                    string query3 = $"insert into demande_reunion (id_reunion, Id_demande) " +
                         $" values('{super_id}','{Lastid()}');";

                    cBdd.ExecuteQuery(query3);
                    break;
                case 3:
                    string query4 = $"insert into demande_vehicule (id_vehicule, Id_demande) " +
                         $" values('{super_id}','{Lastid()}');";

                    cBdd.ExecuteQuery(query4);
                    break;
            }

        }

        #endregion

        #region Notif

        public static void UpdateNotif(bool SwitchNotif)
        {
            if (SwitchNotif)
            {

                string query1 = $"update demande set Adminnotif = '1' where id_demande ='{cDemande.id_demande}';";

                cBdd.ExecuteQuery(query1);

                string query2 = $"update demande set Usernotif = '0' where id_demande ='{cDemande.id_demande}' ;";

                cBdd.ExecuteQuery(query2);
            }
            else
            {
                string query1 = $"update demande set Adminnotif = '0' where id_demande ='{cDemande.id_demande}';";

                cBdd.ExecuteQuery(query1);

                string query2 = $"update demande set Usernotif = '1' where id_demande ='{cDemande.id_demande}';";

                cBdd.ExecuteQuery(query2);
            }

        }

        public static void UpdateHistoNotif(bool on)
        {
            if (on)
            {

                string query1 = $"update demande set Histonotif = '1' where id_demande ='{cDemande.id_demande}';";

                cBdd.ExecuteQuery(query1);

            }
            else
            {
                string query1 = $"update demande set Histonotif = '0' where id_utilisateur ='{cUtilisateur.user_id}';";

                cBdd.ExecuteQuery(query1);

            }
            string query2 = $"update demande set Adminnotif = '0' where id_demande ='{cDemande.id_demande}';";

            cBdd.ExecuteQuery(query2);
            string query3 = $"update demande set Usernotif = '0' where id_demande ='{cDemande.id_demande}' ;";

            cBdd.ExecuteQuery(query3);

        }

        public static int NotifGestion()
        {
            int type = cUtilisateur.GetAccounType();
            string query = $"select count(Adminnotif) from demande where Adminnotif = 1 and type_demande = '{type}';";

            int result = cBdd.ExecuteQuery2(query);

            return result;
        }

        public static int NotifDemande()
        {
            string query = $"select count(Usernotif) from demande where Usernotif = 1 and id_utilisateur = '{cUtilisateur.user_id}';";

            int result = cBdd.ExecuteQuery2(query);

            return result;
        }

        public static int NotifHistorique()
        {
            int type = cUtilisateur.GetAccounType();
            string query = $"select count(Histonotif) from demande where Histonotif = 1 and id_utilisateur = '{cUtilisateur.user_id}';";

            int result = cBdd.ExecuteQuery2(query);

            return result;
        }

        #endregion

        #region Statut


        public static void Valide(int demande_id)
        {
            cBdd.ValideUpdate(demande_id);

        }
        public static void Attente(int demande_id, string mess_att)
        {

            cBdd.AttenteUpdate(demande_id, mess_att);
            
        }
        public static void Delete(int demande_id, string mess_refu)
        {

            cBdd.DeleteUpdate(mess_refu, demande_id);

        }

        public static void Cloture(int demande_id, string mess_clo)
        {

            cBdd.ClotureUpdate(mess_clo, demande_id);

        }

        public static void ValideRDV(int demande_id)
        {

            cBdd.ValideRDVUpdate(demande_id);

        }



        #endregion
        public static int Lastid()
        {

            string query = "select max(id_demande) as last_id from demande ;";
            int result = cBdd.ExecuteQuery2(query);
            id_demande = Convert.ToInt32(result);


            return id_demande;
        }
        

        public static void UpdateDemande(int id_demande, int untype_demande, string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user)
        {
            int statut = 1;


            string query = $"update demande set type_demande = '{untype_demande}' , Objet_demande = '{unObjet}',, Commentaire=  '{unCommetaire}', Prioritaire= '{unPrioritaire}',  Duree_debut= '{uneDuree_debut}', Duree_fin = '{UneDuree_fin}', statut='{statut}', where id_demande = '{id_demande}';";

            cBdd.ExecuteQuery(query);



        }


   
        public static void DeleteDemande(int demande_id)
        {


            string query = $"select type_demande from demande where id_demande = '{demande_id}';";


            int type = cBdd.ExecuteQuery(query);

            switch (type)
            {
                case 1:
                    string query2 = $"delete from demande_services where id_demande ='{demande_id}';";

                    cBdd.ExecuteQuery(query2);
                    break;
                case 2:
                    string query3 = $"delete from demande_reunion where id_demande ='{demande_id}';";

                    cBdd.ExecuteQuery(query3);
                    break;
                case 3:
                    string query4 = $"delete from demande_vehicule where id_demande ='{demande_id}';";

                    cBdd.ExecuteQuery(query4);
                    break;
            }
            string query5 = $"delete from demande where id_demande ='{demande_id}';";

            cBdd.ExecuteQuery(query5);
        }

        //public static string popupvalidinfo()
        //{

        //    string query = "select objet_demande from demande;";

        //    string result = cBdd.ExecuteQuery(query);
        //    return result;
        //}


    }
}