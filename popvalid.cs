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
        private int type_valid;
        public popvalid(int type_valid)
        {

            InitializeComponent();
            BindList(type_valid);
            this.type_valid = type_valid;
        }

        private void BindList(int type_valid)
        {
            switch (type_valid)
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
            switch (type_valid)
            {


                case 1:
                    cDemande.Valide(cDemande.id_demande);
                    cDemande.UpdateNotif(false);
                    break;

                case 2:

                    cDemande.Attente(cDemande.id_demande, tbmess.Text);
                    
                    break;
                case 3:

                    cDemande.Delete(cDemande.id_demande, tbmess.Text);
                    cDemande.UpdateHistoNotif(false);

                    break;

                case 4:
                    cDemande.Cloture(cDemande.id_demande, tbmess.Text);
                    cDemande.UpdateHistoNotif(false);
                    break;

                case 5:
                    cDemande.ValideRDV(cDemande.id_demande);
                    cDemande.UpdateNotif(true);
                    break;
            }
            menucs menu = new menucs();
            menu.BindNotif();
            Requete requete = new Requete();
            requete.Invalidate();
            requete.Update();
            cDemande.isnewstatut = true;
            this.Close();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            cDemande.isnewstatut = false;
            this.Close();

        }
    }
}
