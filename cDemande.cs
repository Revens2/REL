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
        

        public static void Demandesave(string unObjet, string unCommetaire, int unPrioritaire, string uneDuree_debut, string UneDuree_fin, int id_user)
        {
            int statut = 1;


            string query = $"INSERT INTO demande (Objet_demande , Commentaire, Prioritaire,  Duree_debut, Duree_fin, statut, Id_Utilisateur) " +
                           $"VALUES ('{unObjet}', '{unCommetaire}', '{unPrioritaire}','{uneDuree_debut}', '{UneDuree_fin}', '{statut}', '{id_user}');";


            cBdd.ExecuteQuery(query);


        }

        public static void Demandeservicesave(int typeserv)
        {
           


            string query = $"insert into Services (Type_service, Id_demande) " +
                           $" values('{typeserv}','{lastid()}');";

            cBdd.ExecuteQuery(query);

        }
        public static void Demandereunionsave(string unObjet, string unCommetaire, bool unPrioritaire, DateTime uneDuree_debut, DateTime UneDuree_fin)
        {
           


            string query = $"INSERT INTO demande (Objet_demande , Commentaire, Prioritaire,  Duree_debut, Duree_fin, statut) " +
                           $"VALUES ('{unObjet}', '{unCommetaire}', '{unPrioritaire}','{uneDuree_debut}', '{UneDuree_fin}')";


        }
        public static void Demandevehiculesave(string unObjet, string unCommetaire, bool unPrioritaire, DateTime uneDuree_debut, DateTime UneDuree_fin)
        {
           


            string query = $"INSERT INTO demande (Objet_demande , Commentaire, Prioritaire,  Duree_debut, Duree_fin, statut) " +
                           $"VALUES ('{unObjet}', '{unCommetaire}', '{unPrioritaire}','{uneDuree_debut}', '{UneDuree_fin}')";


        }

        public static int lastid()
        {

            string query = "SELECT LAST_INSERT_ID() from demande;";

            id_demande = Convert.ToInt32(cBdd.ExecuteQuery(query));
            return id_demande;
        }
    }
}
