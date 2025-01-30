using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REL
{
    internal class cDemande
    {

        private string Objet;
        private string Commentaire;
        private int Type;
        private bool Prioritaire;
        DateTime Duree_debut;
        DateTime Duree_fin;

        public cDemande() {

        }
        public cDemande(string unObjet, string unCommetaire, int unType, bool unPrioritaire, DateTime uneDuree_debut, DateTime UneDuree_fin)
        {
            this.Objet = unObjet;
            this.Commentaire = unCommetaire;    
            this.Type = unType; 
            this.Prioritaire = unPrioritaire;
            this.Duree_debut = uneDuree_debut;
            this.Duree_fin = UneDuree_fin;

        }
        public DataTable listDemande(int id_user, bool cbprioritaire)
        {
            int priorité = 1;
            if (cbprioritaire)
            {
                priorité = 0;
            }

            string query = $"select Prioritaire, Objet_demande, Commentaire, type_demande, Duree_debut, Duree_fin, statut from demande where Id_Utilisateur= '{id_user}' and Prioritaire = '{priorité}';";
            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }
        public DataTable listHistorique(int statut , int id_user)
        {
           
            string query = $"select Objet_demande, type_demande, duree_debut, duree_fin from demande where statut = '{statut}' and id_utilisateur= '{id_user}' ;";
            DataTable result = cBdd.ExecuteSelectToDataTable(query);
            return result;
        }


     



    }
}
