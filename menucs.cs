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
    public partial class menucs : UserControl
    {
        private int globaluserid = 0;
        public menucs(int userid)
        {
            InitializeComponent();

            globaluserid = userid;
            cUtilisateur cUtilisateur = new cUtilisateur(globaluserid);
            btrequete.Visible = (cUtilisateur.isAdmin || cUtilisateur.istypeService || cUtilisateur.isRh || cUtilisateur.isInfo || cUtilisateur.isPaie || cUtilisateur.istypeReunion || cUtilisateur.istypeVehicule);

            lbinfo.Text = $"{cUtilisateur.Name} {cUtilisateur.Prenom}";
            BindNotif();
        }


        public void BindNotif()
        {
            lbnotifdemande.Text = Convert.ToString(cDemande.NotifDemande(globaluserid));
            lbnotifgestion.Text = Convert.ToString(cDemande.NotifGestion(globaluserid));
            lbnotifhisto.Text = Convert.ToString(cDemande.NotifHistorique(globaluserid)); 
            if (lbnotifdemande.Text == "0")
            {
                lbnotifdemande.Visible = false;
            }else
            {
                lbnotifdemande.Visible = true;
            }

            if (lbnotifgestion.Text == "0")
            {
                lbnotifgestion.Visible = false;
            }
            else
            { 
                lbnotifgestion.Visible = true;
                    
            }
            if (lbnotifhisto.Text == "0")
            {
                lbnotifhisto.Visible = false;
            }
            else
            {
                lbnotifhisto.Visible = true;

            }
        }

        private void btHistorique_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Historique page = new Historique(globaluserid);
            page.ShowDialog();
        }

        private void btaccount_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Account compte = new Account(globaluserid);
            compte.ShowDialog();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Connexion conn = new Connexion();
            conn.ShowDialog();
        }

        private void btrequete_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Requete request = new Requete(globaluserid);
            request.ShowDialog();
        }

        private void btdemande_Click(object sender, EventArgs e)
        {
            this.FindForm().Hide();
            Demande dem = new Demande(globaluserid);
            dem.ShowDialog();
        }
    }
}
