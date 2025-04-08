using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace REL
{
    public partial class Connexion : BaseForm
    {



        public Connexion()
        {
            InitializeComponent();

        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            cUtilisateur cUtilisateur = new cUtilisateur();

            cUtilisateur.Mail = tbusername.Text;
            cUtilisateur.Password = tbmdp.Text;

            // remettre ça avant d'envoyer pour l'exam et modif les données utilisateur en base
            //if (string.IsNullOrWhiteSpace(username))
            //{
            //    MessageBox.Show("Veuillez saisir votre adresse email.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbusername.Focus();
            //    return;
            //}
            //if (!cUtilisateur.IsValidEmail(username))
            //{
            //    MessageBox.Show("Veuillez saisir une adresse email valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbusername.Focus();
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(password))
            //{
            //    MessageBox.Show("Veuillez saisir un mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    tbmdp.Focus();
            //    return;
            //}



            if (cUtilisateur.ValidLogin())
            {
                MessageBox.Show("Connexion réussi !");

                this.Hide();
                Demande page = new Demande(cUtilisateur.User_id);
                page.ShowDialog();
            }
            else
            {
                MessageBox.Show("Connexion refusée !");
            }
        }

        private void btisncri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription inscri = new Inscription();
            inscri.ShowDialog();

        }

    }
}

