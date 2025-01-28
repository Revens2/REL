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

           Utilisateur monUser = new Utilisateur();
       

            if (monUser.validLogin(username, password))
            {
                MessageBox.Show("bv t co ");

                this.Hide();
                Historique page = new Historique();
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
            tbuser inscription = new tbuser();
            inscription.ShowDialog();
            
        }
    }
}

