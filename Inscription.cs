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
    public partial class tbuser : Form
    {
        public tbuser()
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

            Utilisateur monUser = new Utilisateur(name, prenom, mail, password, adresse, zip, ville, numero);

            if (string.IsNullOrEmpty(monUser.GetUserInfo()))
            {
                MessageBox.Show("remplie tout");
                return;
            }

            if (Bdd.Validregister(name, prenom, mail, password, adresse, zip, ville, numero) > 0)
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
    }
}

