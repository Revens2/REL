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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        private void btinscri_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string prenom = tbprenom.Text;
            string mail = tbmail.Text;
            string password = tbpass.Text;
            string adresse = tbadresse.Text;
            string zip = tbzip.Text;
            string ville = tbville.Text;
            string numero = tbnumero.Text;
            string dateDeNaissance = tbdate.Value.ToString("yyyy-MM-dd");

            cUtilisateur monUser = new cUtilisateur(name, prenom, dateDeNaissance, numero, mail, password, adresse, zip, ville);

            if (string.IsNullOrEmpty(monUser.GetUserInfo()))
            {
                MessageBox.Show("remplie tout");
                return;
            }

            if (cUtilisateur.Validregister(name, prenom, dateDeNaissance, mail, password, adresse, zip, ville, numero) > 0)
            {
                MessageBox.Show("bv t inscri");
                this.Close();
                this.Hide();
                Connexion page = new Connexion();
                page.ShowDialog();
            }

            else
            {
                MessageBox.Show("nan tu pue");
            }

        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void lbnewuser_Click(object sender, EventArgs e)
        {

        }
  

        private void btreturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Demande dem = new Demande();
            dem.ShowDialog();

        }
    }
}

