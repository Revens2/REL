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
    public partial class Historique : Form
    {
        private menucs menu;
        public Historique()
        {
            InitializeComponent();
            Bindlist();
            menu = new menucs();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
            cDemande.UpdateHistoNotif(false);
        }
        private void Bindlist()
        {
            cDemande dem = new cDemande();
            int statut = 6;
            if (cbstatut.Checked)
            {
                statut = 4;
            }
            gv_list.DataSource = dem.listHistorique(statut, cUtilisateur.user_id);

        }

        private void cbstatut_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion conn = new Connexion();
            conn.ShowDialog();
            cUtilisateur user = new cUtilisateur();
            cUtilisateur.User_id = -1;
        }

        private void btdemande_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demande dem = new Demande();
            dem.ShowDialog();
        }

        private void btaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account compte = new Account();
            compte.ShowDialog();
        }
    }
}
