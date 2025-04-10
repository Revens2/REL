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
        private int id_demande;

        private string objet;

        private string commentaire;

        private bool prioritaire;

        private DateTime duree_debut;

        private DateTime duree_fin;

        private int statut;

        private bool final;

        private bool isnewstatut;
        public  int Id_demande

        {
            get { return id_demande; }
            set { id_demande = value; }
        }

        public string Objet
        {
            get { return objet; }
            set { objet = value; }
        }

        public string Commentaire
        {
            get { return commentaire; }
            set { commentaire = value; }
        }

        public bool Prioritaire
        {
            get { return prioritaire; }
            set { prioritaire = value; }
        }

        public DateTime Duree_debut
        {
            get { return duree_debut; }
            set { duree_debut = value; }
        }

        public DateTime Duree_fin
        {
            get { return duree_fin; }
            set { duree_fin = value; }
        }

       
        public bool Isnewstatut

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
        public cDemande(int Demandeid)
        {
           
            id_demande = Demandeid;

            if (id_demande > 0)
            {
                DataTable dt = cBdd.SelectOnedemande(id_demande);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    this.objet = Convert.ToString(row["Objet_demande"]);
                    this.commentaire = Convert.ToString(row["Commentaire"]);
                    this.Prioritaire = Convert.ToBoolean(row["Prioritaire"]);
                    this.duree_debut = Convert.ToDateTime(row["Duree_debut"]);
                    this.duree_fin = Convert.ToDateTime(row["Duree_fin"]);
                    this.statut = Convert.ToInt32(row["statut"]);

                }
            }

            

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
        public  DataTable ListService()
        {

            return cBdd.SelectService();

        }

        public  DataTable ListReunion()
        {

            return cBdd.SelectReunion();

        }

        public  DataTable ListVehicule()
        {

            return cBdd.SelectVehicule();

        }

        public  DataTable ListBackDemande()
        {

            return cBdd.SelectBackDemande(id_demande);

        }

        public  DataTable ListBackCompleteDemande()
        {
            DataTable dt = cBdd.SelectBackCompleteDemande(id_demande);
            dt.Columns.Add("detailtype", typeof(string));
            DataTable dtDetail= null;
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                int type = Convert.ToInt32(row["type_demande"]);
                
                switch (type)
                {
                    case 1:
                        dtDetail = cBdd.SelectBackCompleteService(id_demande);
                        break;
                    case 2:
                        dtDetail = cBdd.SelectBackCompleteReunion(id_demande);
                        break;
                    case 3:
                        dtDetail = cBdd.SelectBackCompleteVehicule(id_demande);
                        break;
                }
                dt.Rows[0]["detailtype"] = dtDetail.Rows[0]["detailtype"].ToString();
            }

            return dt;
        }

        #endregion


        #region Save
        public void DemandeSave(int untype_demande, string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user, int super_id)
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

        public void UpdateNotif(bool SwitchNotif)
        {
            if (SwitchNotif)
            {

                cBdd.UpdateAdminNotif(id_demande);

            }
            else
            {

                cBdd.UpdateUserNotif(id_demande);

            }

        }

        public void UpdateHistoNotif(bool on, int userid)
        {
            if (on)
            {

                cBdd.OnNotifHisto(id_demande);
                 
            }
            else
            {

                cBdd.OffNotifHisto(userid);

            }
            cBdd.UpdateNoNotif(id_demande);
        }

        public int NotifGestion(int userid)
        {
            cUtilisateur cUtilisateur = new cUtilisateur(userid);
            int type = cUtilisateur.GetAccounType();

            return cBdd.CountNotifGestion(type);
        }

        public int NotifDemande(int userid)
        {
            return cBdd.CountNotifDemande(userid);
        }

        public int NotifHistorique(int userid)
        {
            return cBdd.CountNotifHisto(userid);
        }

        #endregion

        #region Statut


        public void Valide()
        {
            cBdd.ValideUpdate(id_demande);

        }
        public void Attente(string mess_att)
        {

            cBdd.AttenteUpdate(id_demande, mess_att);
            
        }
        public void Delete(string mess_refu)
        {

            cBdd.DeleteUpdate(mess_refu, id_demande);

        }

        public void Cloture(string mess_clo)
        {

            cBdd.ClotureUpdate(mess_clo, id_demande);

        }

        public void ValideRDV()
        {

            cBdd.ValideRDVUpdate(id_demande);

        }



        #endregion
   
        public void DeleteDemande(int demande_id)
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

        //public string popupvalidinfo()
        //{

        //    string query = "select objet_demande from demande;";

        //    string result = cBdd.ExecuteQuery(query);
        //    return result;
        //}


    }
}