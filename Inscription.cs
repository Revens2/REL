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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }
        private void btinscri_Click(object sender, EventArgs e)
        {
            cUtilisateur cUtilisateur = new cUtilisateur();


            cUtilisateur.Name = tbname.Text.Trim();
            cUtilisateur.Prenom = tbprenom.Text.Trim();
            cUtilisateur.Mail = tbmail.Text.Trim();
            cUtilisateur.Password = tbpass.Text.Trim();
            cUtilisateur.Adresse = tbadresse.Text.Trim();
            cUtilisateur.Zip = Convert.ToInt16(tbzip.Text.Trim());
            cUtilisateur.Ville = tbville.Text.Trim();
            cUtilisateur.Numero = Convert.ToInt32(tbnumero.Text.Trim());
            cUtilisateur.DateDeNaissance = tbdate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(cUtilisateur.Name))
            {
                MessageBox.Show("Veuillez saisir votre nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cUtilisateur.Prenom))
            {
                MessageBox.Show("Veuillez saisir votre prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbprenom.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cUtilisateur.Mail))
            {
                MessageBox.Show("Veuillez saisir votre adresse email.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmail.Focus();
                return;
            }
            if (!cUtilisateur.IsValidEmail(cUtilisateur.Mail))
            {
                MessageBox.Show("Veuillez saisir une adresse email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cUtilisateur.Password))
            {
                MessageBox.Show("Veuillez saisir un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }
            if (cUtilisateur.Password.Length < 6)
            {
                MessageBox.Show("Le mot de passe doit contenir au moins 6 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }

            DateTime minimumDate = DateTime.Today.AddYears(-18);
            if (tbdate.Value > minimumDate)
            {
                MessageBox.Show("Vous devez avoir au moins 18 ans.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbdate.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(cUtilisateur.Adresse))
            {
                MessageBox.Show("Veuillez saisir votre adresse.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbadresse.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(cUtilisateur.Zip)))
            {
                MessageBox.Show("Veuillez saisir votre code postal.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbzip.Focus();
                return;
            }
            if (!int.TryParse(Convert.ToString(cUtilisateur.Zip), out int zipCode))
            {
                MessageBox.Show("Le code postal doit être numérique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbzip.Focus();
                return;
            }
            if (Convert.ToString(cUtilisateur.Zip).Length > 9999)
            {
                MessageBox.Show("Le code postal  doit contenir exactement 5 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cUtilisateur.Ville))
            {
                MessageBox.Show("Veuillez saisir votre ville.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbville.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(cUtilisateur.Numero)))
            {
                MessageBox.Show("Veuillez saisir votre numéro de téléphone.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnumero.Focus();
                return;
            }
            if (!long.TryParse(Convert.ToString(cUtilisateur.Numero), out long tel))
            {
                MessageBox.Show("Le numéro de téléphone doit être numérique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnumero.Focus();
                return;
            }
            if (Convert.ToString(cUtilisateur.Numero).Length == 10)
            {
                MessageBox.Show("Le numero doit contenir exactement 10 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }

            if (cUtilisateur.Validregister() > 0)
            {
                MessageBox.Show("Inscription réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Connexion page = new Connexion();
                page.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erreur lors de l'inscription.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Connexion conn = new Connexion();
            conn.ShowDialog();

        }
    }
}

