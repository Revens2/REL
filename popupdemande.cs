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
    public partial class popupdemande : Form
    {
        public popupdemande()
        {
            InitializeComponent();
            tbdatedebut.Value = DateTime.Now;
            tbdateend.Value = DateTime.Now;
            DataTable dt = new DataTable();
            ddltype.Items.Add("Sélectionnez une option");
            ddltype.Items.Add("Un Service");
            ddltype.Items.Add("Une Réunion");
            ddltype.Items.Add("Un Véhicule");

            ddltype.SelectedIndex = 0;

            dt = cDemande.listbackservice();
            dllservice.Items.Add("Sélectionnez une option");
            foreach (DataRow dr in dt.Rows)
            {
                dllservice.Items.Add(dr["name_service"].ToString());
              
            }
       
            dllservice.SelectedIndex = 0;
        }

        private void ddltype_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlService.Visible = false;
            pnlReunion.Visible = false;
            pnlVehicule.Visible = false;

            switch (ddltype.SelectedIndex)
            {
                case 1:
                    pnlService.Visible = true;
                    break;

                case 2:
                    pnlReunion.Visible = true;
                    break;

                case 3:
                    pnlVehicule.Visible = true;
                    break;
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
      
           
            cDemande.Demandesave(dllservice.SelectedIndex,tbobjet.Text, tbcom.Text, cBdd.CbConvert(cbprioritaire.Checked), cBdd.DateConvert(tbdatedebut.Value), cBdd.DateConvert(tbdateend.Value), cUtilisateur.user_id);
            switch (ddltype.SelectedIndex)
            {
                case 1:
                    cDemande.Demandeservicesave(dllservice.SelectedIndex);
                    break;

                case 2:
                    cDemande.Demandereunionsave(dllservice.SelectedIndex);
                    break;

                case 3:
                    cDemande.Demandevehiculesave(dllservice.SelectedIndex);
                    break;
            }
        }
    }
}