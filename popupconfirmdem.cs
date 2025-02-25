using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REL
{
    public partial class popupconfirmdem : Form
    {
        public popupconfirmdem()
        {
            InitializeComponent();
            Bindlist();
        }
        private void Bindlist()
        {
            DataTable dtdata = cDemande.listbackcompletedemande(cDemande.id_demande);
            DataRow row = dtdata.Rows[0];

            lbtypedata.Text = row["type_demande"].ToString();
            lbobjetdata.Text = row["objet_demande"].ToString();
            cbprio.Checked = Convert.ToBoolean(row["Prioritaire"]);
            lbcomdata.Text = row["Commentaire"].ToString();
            lbdebutdata.Text = row["duree_debut"].ToString();
            lbfindata.Text = row["duree_fin"].ToString();
            lbservicedata.Text = row["detailtype"].ToString();
            lbmotifdata.Text = row["motif_att"].ToString();
        }
        

        private void btcancel_Click(object sender, EventArgs e)
        {
            cDemande.id_demande = 0;
            this.Close();

        }

        private void btsave_Click(object sender, EventArgs e)
        {
            cDemande.valideRDV(cDemande.id_demande);
            cDemande.UpdateNotif(true);
            menucs menu = new menucs();
            menu.BindNotif();
            Requete requete = new Requete();
            requete.Invalidate();
            requete.Update();
            this.Close();
        }
    }
}
