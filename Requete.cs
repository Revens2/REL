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
    public partial class Requete : Form
    {
        public Requete()
        {
            InitializeComponent();
        }

        private void btdemande_Click(object sender, EventArgs e)
        {
            this.Hide();
            Demande dem = new Demande();
            dem.ShowDialog();
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

        private void btHistorique_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historique page = new Historique();
            page.ShowDialog();
        }
    }
}
