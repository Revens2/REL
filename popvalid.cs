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
    public partial class popvalid : Form
    {
        private int globaltype_valid = 0;
        private int globaluserid = 0;
        private int globaldemandeid = 0;
        public popvalid(int userid, int type_valid, int demandeid)
        {

            InitializeComponent();
            
            globaluserid = userid;
            globaltype_valid = type_valid;
            globaldemandeid = demandeid;
            BindList();
        }

        private void BindList()
        {
            switch (globaltype_valid)
            {

                case 1:
                    lbmess.Text = "Vous êtes sur le point de validé la demande";
                    tbmess.Visible = false;
                    break;

                case 2:
                    lbmess.Text = "Vous êtes sur le point de mettre en attente la demande veuillez laisser un message de justification";
                    tbmess.Visible = true;
                    break;
                case 3:
                    lbmess.Text = "Vous êtes sur le point d'annuler la demande veuillez laisser un message de justification";
                    tbmess.Visible = true;
                    break;
                case 4:
                    lbmess.Text = "Vous êtes sur le point de cloturer une demnade ";
                    tbmess.Visible = true;
                    break;
                case 5:
                    lbmess.Text = "Vous êtes sur le point de valider votre demande";
                    tbmess.Visible = false;
                    break;

            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            cDemande cDemande = new cDemande(globaldemandeid);
            switch (globaltype_valid)
            {


                case 1:
                    cDemande.Valide();
                    cDemande.UpdateNotif(false);
                    break;

                case 2:

                    cDemande.Attente(tbmess.Text);
                    
                    break;
                case 3:

                    cDemande.Delete(tbmess.Text);
                    cDemande.UpdateHistoNotif(false, globaluserid);

                    break;

                case 4:
                    cDemande.Cloture(tbmess.Text);
                    cDemande.UpdateHistoNotif(false, globaluserid);
                    break;

                case 5:
                    cDemande.ValideRDV();
                    cDemande.UpdateNotif(true);
                    break;
            }
            menucs menu = new menucs(globaluserid);
            menu.BindNotif();
            Requete requete = new Requete(globaluserid);
            requete.Invalidate();
            requete.Update();
            cDemande.Isnewstatut = true;
            this.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            cDemande cDemande = new cDemande(globaldemandeid);
            cDemande.Isnewstatut = false;
            this.Close();

        }
    }
}
