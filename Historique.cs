using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblio;

namespace REL
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            cDemande dem = new cDemande();
            int statut = 6;
            if (cbstatut.Checked)
            {
                statut = 5;
            }
            gv_list.DataSource = dem.listHistorique(statut, cUtilisateur.user_id);

        }

        private void cbstatut_CheckedChanged(object sender, EventArgs e)
        {
            BindDataGridView();
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
    }
}
