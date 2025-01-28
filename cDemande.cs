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


        public DataTable listHistorique(bool cbstatut, int id_user)

        {
            int statut = 6;
            if (cbstatut)
            {
                statut = 5;
            }
            string query = $"select Objet_demande, type_demande, duree_debut, duree_fin from demande where statut = '{statut}' and id_utilisateur= '{id_user}' ;";
            DataTable result = Bdd.ExecuteSelectToDataTable(query);
            return result;
        }


     



    }
}
