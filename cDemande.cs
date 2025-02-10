using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string Objet;
        private string Commentaire;
     
        private bool Prioritaire;
        DateTime Duree_debut;
        DateTime Duree_fin;

        public cDemande() {

        }
        public cDemande(string unObjet, string unCommetaire, bool unPrioritaire, DateTime uneDuree_debut, DateTime UneDuree_fin)
        {
            
            this.Objet = unObjet;
            this.Commentaire = unCommetaire;    
            this.Prioritaire = unPrioritaire;
            this.Duree_debut = uneDuree_debut;
            this.Duree_fin = UneDuree_fin;

        }

   
        public DataTable listDemande(int id_user, int cbprioritaire)
        {
            string query = $"select Prioritaire, Objet_demande, Commentaire, type_demande, Duree_debut, Duree_fin, statut from demande where Id_Utilisateur= '{id_user}' and Prioritaire = '{cbprioritaire}';";
            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }
        public DataTable listHistorique(int statut , int id_user)
        {
           
            string query = $"select Objet_demande, type_demande, duree_debut, duree_fin from demande where statut = '{statut}' and id_utilisateur= '{id_user}' ;";
            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }
        

        public static void Demandesave(int untype_demande,string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user)
        {
            int statut = 1;


            string query = $"INSERT INTO demande (type_demande , Objet_demande , Commentaire, Prioritaire,  Duree_debut, Duree_fin, statut, Id_Utilisateur) " +
                           $"VALUES ('{untype_demande}', '{unObjet}', '{unCommetaire}', '{unPrioritaire}','{uneDuree_debut}', '{UneDuree_fin}', '{statut}', '{id_user}');";


            cBdd.ExecuteQuery(query);
            


        }

        public static void Demandeservicesave(int idserv)
        {
           


            string query = $"insert into demande_services (id_service, Id_demande) " +
                           $" values('{idserv}','{lastid()}');";

            cBdd.ExecuteQuery(query);

        }
        public static void Demandereunionsave(int idreu)
        {



            string query = $"insert into demande_reunion (id_reunion, Id_demande) " +
                         $" values('{idreu}','{lastid()}');";

            cBdd.ExecuteQuery(query);


        }
        public static void Demandevehiculesave(int idvehi)
        {



            string query = $"insert into demande_vehicule (id_vehicule, Id_demande) " +
                         $" values('{idvehi}','{lastid()}');";

            cBdd.ExecuteQuery(query);


        }
        public static int lastid()
        {

            string query = "Select last_insert_id() from demande;";

            DataTable dt = cBdd.ExecuteSelectToDataTable(query);
            id_demande = dt.Rows.Count;

            return id_demande;
        }

        public static DataTable listbackservice()
        {

            string query = "select id_service, name_service from services;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public static DataTable listbackreunion()
        {

            string query = "select id_reunion, name_salle, name_service from reunion;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }

        public static DataTable listvehicule()
        {

            string query = "select id_vehicule, name_salle, name_service from vehicule;";

            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }


    }
}
