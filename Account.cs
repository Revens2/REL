using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace REL
{
    public partial class Account : Form
    {
        private menucs menu;
        public Account()
        {
            InitializeComponent();
            BindList();
            menu = new menucs();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
        }


        private void btmaj_Click(object sender, EventArgs e)
        {
            cUtilisateur cUtilisateur = new cUtilisateur();

            cUtilisateur.Name = tbname.Text.Trim();
            cUtilisateur.Prenom = tbprenom.Text.Trim();
            cUtilisateur.Mail = tbmail.Text.Trim();
            cUtilisateur.Adresse = tbadresse.Text.Trim();
            cUtilisateur.Zip = Convert.ToInt32(tbzip.Text.Trim());
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
            if (!cUtilisateur.IsValidEmail())
            {
                MessageBox.Show("Veuillez saisir une adresse email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmail.Focus();
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
                tbzip.Focus();
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
                tbnumero.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cUtilisateur.GetUserInfo()))
            {
                MessageBox.Show("remplie tout");
                return;
            }
            else
            {
                cUtilisateur.MajUser();
                MessageBox.Show("Vos modifications ont été prises en compte");
                return;
            }

        }
        private void BindList()
        {
            cUtilisateur user = new cUtilisateur();
            DataTable dt = user.getAccount(cUtilisateur.user_id);
            DataRow row = dt.Rows[0];

            tbname.Text = row["Nom"].ToString();
            tbprenom.Text = row["Prenom"].ToString();
            tbdate.Value = Convert.ToDateTime(row["date_de_naissance"]);
            tbnumero.Text = row["Numero"].ToString();
            tbmail.Text = row["Email"].ToString();
            tbadresse.Text = row["Adresse"].ToString();
            tbzip.Text = row["Zip"].ToString();
            tbville.Text = row["Ville"].ToString();
        }



    }
}

