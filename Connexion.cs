using System;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace REL
{
    public partial class Connexion : Form
    {
        

        
        public Connexion()
        {
            InitializeComponent();
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            
            string username = tbusername.Text;
            string password = tbmdp.Text;

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
            cUtilisateur monUser = new cUtilisateur();
       

            if (monUser.validLogin(username, password))
            {
                MessageBox.Show("bv t co ");

                this.Hide();
                Demande page = new Demande();
                page.ShowDialog();
            }
            else
            {
                MessageBox.Show("gro naz");
            }
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btisncri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription inscri = new Inscription();
            inscri.ShowDialog();
            
        }
    }
}

