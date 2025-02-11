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


            ddltype.Items.Add("Sélectionnez une option");
            ddltype.Items.Add("Un Service");
            ddltype.Items.Add("Une Réunion");
            ddltype.Items.Add("Un Véhicule");
            ddltype.SelectedIndex = 0;

            DataTable dt = cDemande.listbackservice();
            dllservice.Items.Add("Sélectionnez une option");
            foreach (DataRow dr in dt.Rows)
            {
                dllservice.Items.Add(dr["name_service"].ToString());
            }
            dllservice.SelectedIndex = 0;


            gvlistreu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvlistreu.MultiSelect = false;

            gvvehi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvvehi.MultiSelect = false;
            


            Bindlist();
        }
        private void Bindlist()
        {

            switch (ddltype.SelectedIndex)
            {
                case 1:
                    pnlService.Visible = true;
                    break;
                case 2:
                    DataTable dt2 = cDemande.listbackreunion();
                    gvlistreu.DataSource = dt2;
                    break;
                case 3:
                    DataTable dt3 = cDemande.listvehicule();
                    gvvehi.DataSource = dt3;
                    break;
            }
           
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
            Bindlist();
        }

        private void btsave_Click(object sender, EventArgs e)
        {

            cDemande.Demandesave(dllservice.SelectedIndex, tbobjet.Text, tbcom.Text, cBdd.CbConvert(cbprioritaire.Checked), cBdd.DateConvert(tbdatedebut.Value), cBdd.DateConvert(tbdateend.Value), cUtilisateur.user_id);

            switch (ddltype.SelectedIndex)
            {
                case 1:
                    cDemande.Demandeservicesave(dllservice.SelectedIndex);
                    break;

                case 2:
                    if (gvlistreu.SelectedRows.Count == 1)
                    {
                        DataGridViewRow selectedRow = gvlistreu.SelectedRows[0];
                        cDemande.Demandereunionsave(Convert.ToInt32(selectedRow.Cells["id_reunion"].Value));

                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une réunion.");
                        
                    }
                    break;

                case 3:
                    if (gvvehi.SelectedRows.Count == 1)
                    {
                        DataGridViewRow selectedRow = gvvehi.SelectedRows[0];
                        cDemande.Demandevehiculesave(Convert.ToInt32(selectedRow.Cells["id_vehicule"].Value));
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une réunion.");
                    }
                    break;
            }
            popupdemande popup = new popupdemande();
            popup.Close();
        }

      
    }
}
