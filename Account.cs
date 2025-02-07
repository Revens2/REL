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
            InitializeComponent();
            menu = new menucs();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
        }
           
        
        private void btmaj_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string prenom = tbprenom.Text;
            string mail = tbmail.Text;

            string adresse = tbadresse.Text;
            string zip = tbzip.Text;
            string ville = tbville.Text;
            string numero = tbnumero.Text;
            string dateDeNaissance = tbdate.Value.ToString("yyyy-MM-dd");

            cUtilisateur monUser = new cUtilisateur();

            if (string.IsNullOrEmpty(monUser.GetUserInfo()))
            {
                MessageBox.Show("remplie tout");
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

 
  

        private void btreturn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Demande dem = new Demande();
            dem.ShowDialog();

        }
    }
}

