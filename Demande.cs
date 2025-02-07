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
    public partial class Demande : Form
    {
        public Demande()
        {
            InitializeComponent();
            Bindlist();
            if (cUtilisateur.isAdmin || cUtilisateur.isRh || cUtilisateur.isInfo || cUtilisateur.isPaie || cUtilisateur.isReunion || cUtilisateur.isVehicule)
            {
                btrequete.Visible = true;
            }
            else
            {
                btrequete.Visible = false;
            }
        }
        private void Bindlist()
        {
            cDemande dem = new cDemande();
            gv_list.DataSource = dem.listDemande(cUtilisateur.user_id, cBdd.CbConvert(cbprioritaire.Checked));

        }
        private void btadd_Click(object sender, EventArgs e)
        {

            popupdemande popup = new popupdemande();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.Show();

        }

        private void btHistorique_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historique page = new Historique();
            page.ShowDialog();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion conn = new Connexion();
            conn.ShowDialog();
            cUtilisateur user = new cUtilisateur();
            cUtilisateur.User_id = -1;
        }

        private void btaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account compte = new Account();
            compte.ShowDialog();
        }

        private void cbprioritaire_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }

        private void btrequete_Click(object sender, EventArgs e)
        {
            this.Hide();
            Requete request = new Requete();
            request.ShowDialog();
        }
    }

}
