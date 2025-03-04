﻿using System;
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
        private string Objet;
        private string Commentaire;

        private bool Prioritaire;
        DateTime Duree_debut;
        DateTime Duree_fin;

        public cDemande()
        {

        }
        public cDemande(string unObjet, string unCommetaire, bool unPrioritaire, DateTime uneDuree_debut, DateTime UneDuree_fin)
        {

            this.Objet = unObjet;
            this.Commentaire = unCommetaire;
            this.Prioritaire = unPrioritaire;
            this.Duree_debut = uneDuree_debut;
            this.Duree_fin = UneDuree_fin;

        }

        #region List 
        public DataTable listDemande(int id_user, int cbprioritaire)
        {
            string query = $"select id_demande, Prioritaire, statut, type_demande, Objet_demande, Commentaire, Duree_debut, Duree_fin from demande where Id_Utilisateur= '{id_user}' and Prioritaire = '{cbprioritaire}';";
            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public static DataTable listrequete(bool cbfinal)
        {
            int type = cUtilisateur.GetAccounType();
            string statut = "d.statut = 1 or d.statut = 3 ";
            if (cbfinal)
            {
                statut = "d.statut = 5";
            }
               string type_demande = $"d.type_demande = '{type}' and";
            if (cUtilisateur.isAdmin)
            {
                 type_demande = "";
            }
            string query = $" select d.id_demande,d.statut, u.nom,u.prenom, d.Objet_demande, d.duree_debut, d.duree_fin " +
             $"from demande d " +
             $"join utilisateur u on u.Id_Utilisateur = d.Id_Utilisateur " +
             $"where {type_demande} {statut} order by statut;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public DataTable listHistorique(int statut, int id_user)
        {

            string query = $"select Objet_demande, type_demande, duree_debut, duree_fin from demande where statut = '{statut}' and id_utilisateur= '{id_user}' ;";
            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }
        public static DataTable listservice()
        {

            string query = "select id_service, name_service from services;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public static DataTable listreunion()
        {

            string query = "select id_reunion, Nom_salle ,nb_place, numero from reunion;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public static DataTable listvehicule()
        {

            string query = "select id_vehicule, marque, modele,nb_place from vehicule;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public static DataTable listbackdemande(int demande_id)
        {

            string query = $"select objet_demande, Commentaire, type_demande, prioritaire, duree_debut, duree_fin from demande where id_demande = '{demande_id}';";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;

        }

        public static DataTable listbackcompletedemande(int demande_id)
        {
           
            string query = $" select type_demande, objet_demande, Commentaire, Prioritaire, duree_debut, duree_fin, motif_att  from demande d where Id_Demande =  '{demande_id}';";

            DataTable dt = cBdd.ExecuteSelectToDataTable(query);
            dt.Columns.Add("detailtype", typeof(string));
            DataTable dtDetail= null;
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int type = Convert.ToInt32(row["type_demande"]);
                
                switch (type)
                {
                    case 1:
                        string query2 = $"select name_service as detailtype from services s join demande_services ds on s.id_service = ds.id_service where ds.id_demande = '{demande_id}';";
                        dtDetail = cBdd.ExecuteSelectToDataTable(query2);
                        break;
                    case 2:
                        string query3 = $"select Nom_salle as detailtype from reunion r join demande_reunion dr on r.id_reunion = dr.id_reunion where dr.id_demande = '{demande_id}';";
                        dtDetail = cBdd.ExecuteSelectToDataTable(query3);
                        break;
                    case 3:
                        string query4 = $"select as detailtype modele from vehicule v join demande_vehicule dv on v.id_vehicule = dv.id_vehicule where dv.id_demande = '{demande_id}';";
                        dtDetail = cBdd.ExecuteSelectToDataTable(query4);
                        break;
                }
                dt.Rows[0]["detailtype"] = dtDetail.Rows[0]["detailtype"].ToString();
            }

            return dt;
        }

        #endregion


        #region Save
        public static void Demandesave(int untype_demande, string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user, int super_id)
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
                           $" values('{super_id}','{lastid()}');";

                    cBdd.ExecuteQuery(query2);
                    break;
                case 2:
                    string query3 = $"insert into demande_reunion (id_reunion, Id_demande) " +
                         $" values('{super_id}','{lastid()}');";

                    cBdd.ExecuteQuery(query3);
                    break;
                case 3:
                    string query4 = $"insert into demande_vehicule (id_vehicule, Id_demande) " +
                         $" values('{super_id}','{lastid()}');";

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


        public static void valide(int demande_id)
        {
            string query = $"update demande set statut = '2'  where id_demande ='{demande_id}';";

            cBdd.ExecuteQuery(query);

        }
        public static void attente(int demande_id, string mess_att)
        {
            string query = $"update demande set statut = '3',motif_att = '{mess_att}' where id_demande ='{demande_id}';";

            cBdd.ExecuteQuery(query);

        }
        public static void delete(int demande_id, string mess_refu)
        {
            string query = $"update demande set statut = '4', motif_refu = '{mess_refu}' where id_demande ='{demande_id}';";

            cBdd.ExecuteQuery(query);

        }

        public static void cloture(int demande_id, string mess_clo)
        {
            string query = $"update demande set statut = '6', motif_clo = '{mess_clo}' where id_demande ='{demande_id}';";

            cBdd.ExecuteQuery(query);

        }

        public static void valideRDV(int demande_id)
        {
            string query = $"update demande set statut = '5' where id_demande ='{demande_id}';";

            cBdd.ExecuteQuery(query);

        }



        #endregion
        public static int lastid()
        {

            string query = "select max(id_demande) as last_id from demande ;";
            int result = cBdd.ExecuteQuery2(query);
            id_demande = Convert.ToInt32(result);


            return id_demande;
        }
        

        public static void updatedemande(int id_demande, int untype_demande, string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user)
        {
            int statut = 1;


            string query = $"update demande set type_demande = '{untype_demande}' , Objet_demande = '{unObjet}',, Commentaire=  '{unCommetaire}', Prioritaire= '{unPrioritaire}',  Duree_debut= '{uneDuree_debut}', Duree_fin = '{UneDuree_fin}', statut='{statut}', where id_demande = '{id_demande}';";

            cBdd.ExecuteQuery(query);



        }


   
        public static void deletedemande(int demande_id)
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