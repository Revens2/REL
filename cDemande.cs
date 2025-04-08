using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf.parser.clipper;
using Microsoft.VisualBasic.ApplicationServices;
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
        public DataTable listDemande(int user_id, int cbprioritaire)
        {
            return cBdd.SelectListDemande(user_id, cbprioritaire);
            
        }

        public DataTable listrequete(int userid)
        {
            cUtilisateur cUtilisateur = new cUtilisateur(userid);
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

        public DataTable listHistorique(int userid)
        {
            return cBdd.SelectHistorique(statut, userid);
            
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
            
            cBdd.InsertDemandeSave(untype_demande, unObjet, unCommetaire, unPrioritaire, uneDuree_debut, UneDuree_fin, id_user, statut, AdminNotif);

            switch (untype_demande)
            {
                case 1:
 
                    cBdd.InsertServiceSave(super_id);
                    break;
                case 2:
                    cBdd.InsertServiceSave(super_id);
                    break;
                case 3:
                    cBdd.InsertServiceSave(super_id);
                    break;
            }

        }

        #endregion

        #region Notif

        public static void UpdateNotif(bool SwitchNotif)
        {
            if (SwitchNotif)
            {

                cBdd.UpdateAdminNotif();

            }
            else
            {

                cBdd.UpdateUserNotif();

            }

        }

        public static void UpdateHistoNotif(bool on, int userid)
        {
            if (on)
            {

                cBdd.OnNotifHisto();
                 
            }
            else
            {

                cBdd.OffNotifHisto(userid);

            }
            cBdd.UpdateNoNotif();
        }

        public static int NotifGestion(int userid)
        {
            cUtilisateur cUtilisateur = new cUtilisateur(userid);
            int type = cUtilisateur.GetAccounType();

            return cBdd.CountNotifGestion(type);
        }

        public static int NotifDemande(int userid)
        {
            return cBdd.CountNotifDemande(userid);
        }

        public static int NotifHistorique(int userid)
        {
            return cBdd.CountNotifHisto(userid);
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
   
        public static void DeleteDemande(int demande_id)
        {

            int type = cBdd.SelectTypeDemande(demande_id);

            switch (type)
            {
                case 1:

                    cBdd.DeleteDemandeServices(demande_id);
                    break;
                case 2:
                    
                    cBdd.DeleteDemandeReunion(demande_id);
                    break;
                case 3:
                   
                    cBdd.DeleteDemandeVehicule(demande_id);
                    break;
            }

            cBdd.DeleteDemande(demande_id);
        }

        //public static string popupvalidinfo()
        //{

        //    string query = "select objet_demande from demande;";

        //    string result = cBdd.ExecuteQuery(query);
        //    return result;
        //}


    }
}