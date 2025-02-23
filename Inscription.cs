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

            string name = tbname.Text.Trim();
            string prenom = tbprenom.Text.Trim();
            string mail = tbmail.Text.Trim();
            string password = tbpass.Text.Trim();
            string adresse = tbadresse.Text.Trim();
            string zip = tbzip.Text.Trim();
            string ville = tbville.Text.Trim();
            string numero = tbnumero.Text.Trim();
            string dateDeNaissance = tbdate.Value.ToString("yyyy-MM-dd");

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Veuillez saisir votre nom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbname.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(prenom))
            {
                MessageBox.Show("Veuillez saisir votre prénom.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbprenom.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(mail))
            {
                MessageBox.Show("Veuillez saisir votre adresse email.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmail.Focus();
                return;
            }
            if (!IsValidEmail(mail))
            {
                MessageBox.Show("Veuillez saisir une adresse email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Veuillez saisir un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }
            if (password.Length < 6)
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


            if (string.IsNullOrWhiteSpace(adresse))
            {
                MessageBox.Show("Veuillez saisir votre adresse.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbadresse.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(zip))
            {
                MessageBox.Show("Veuillez saisir votre code postal.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbzip.Focus();
                return;
            }
            if (!int.TryParse(zip, out int zipCode))
            {
                MessageBox.Show("Le code postal doit être numérique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbzip.Focus();
                return;
            }
            if (zip.Length == 5)
            {
                MessageBox.Show("Le code postal  doit contenir exactement 5 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ville))
            {
                MessageBox.Show("Veuillez saisir votre ville.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbville.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Veuillez saisir votre numéro de téléphone.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnumero.Focus();
                return;
            }
            if (!long.TryParse(numero, out long tel))
            {
                MessageBox.Show("Le numéro de téléphone doit être numérique.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbnumero.Focus();
                return;
            }
            if (numero.Length == 10)
            {
                MessageBox.Show("Le numero doit contenir exactement 10 caractères.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbpass.Focus();
                return;
            }

            if (cUtilisateur.Validregister(name, prenom, dateDeNaissance, mail, password, adresse, zip, ville, numero) > 0)
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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

