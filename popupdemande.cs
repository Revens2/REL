using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Org.BouncyCastle.Asn1.Ocsp;

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

            pnlrequest.Visible = false;



            if (cDemande.id_demande != 0)
            {
                Bindedit(cDemande.id_demande);
                if (cDemande.isrequest)
                {
                    pnlrequest.Visible = true;

                }
            }




            Bindlist();
        }
        private void Bindlist()
        {

            switch (ddltype.SelectedIndex)
            {
                case 1:
                    gvserv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvserv.MultiSelect = false;
                    DataTable dt = cDemande.listservice();
                    gvserv.DataSource = dt;
                    break;
                case 2:
                    gvreu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvreu.MultiSelect = false;
                    DataTable dt2 = cDemande.listreunion();
                    gvreu.DataSource = dt2;
                    break;
                case 3:
                    gvvehi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvvehi.MultiSelect = false;
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
            int super_id = 0;

            switch (ddltype.SelectedIndex)
            {

                case 1:
                    if (gvserv.SelectedRows.Count == 1)
                    {
                        DataGridViewRow selectedRow = gvserv.SelectedRows[0];
                        super_id = Convert.ToInt32(selectedRow.Cells["id_service"].Value);

                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner un service.");

                    }
                    break;

                case 2:
                    if (gvreu.SelectedRows.Count == 1)
                    {
                        DataGridViewRow selectedRow = gvreu.SelectedRows[0];
                        super_id = Convert.ToInt32(selectedRow.Cells["id_reunion"].Value);

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
                        super_id = Convert.ToInt32(selectedRow.Cells["id_vehicule"].Value);
                    }
                    else
                    {
                        MessageBox.Show("Veuillez sélectionner une réunion.");
                    }
                    break;
            }
            cDemande.Demandesave(ddltype.SelectedIndex, tbobjet.Text, tbcom.Text, cBdd.CbConvert(cbprioritaire.Checked), cBdd.DateConvert(tbdatedebut.Value), cBdd.DateConvert(tbdateend.Value), cUtilisateur.user_id, super_id);
            Demande demande = new Demande();

            demande.Bindlist();
            this.Close();
        }

        private void Bindedit(int id)
        {
            DataTable dt = cDemande.listbackdemande(id);
            DataRow row = dt.Rows[0];

            ddltype.SelectedIndex = Convert.ToInt32(row["type_demande"]);
            tbobjet.Text = row["objet_demande"].ToString();
            cbprioritaire.Checked = Convert.ToBoolean(row["prioritaire"]);
            tbcom.Text = row["Commentaire"].ToString();
            tbdatedebut.Value = Convert.ToDateTime(row["duree_debut"].ToString());
            tbdateend.Value = Convert.ToDateTime(row["duree_fin"].ToString());


        }

        private void btvalid_Click(object sender, EventArgs e)
        {
            popvalid popup = new popvalid(1);
            popup.ShowDialog();

            if (cDemande.isnewstatut)
            {
                this.Close();

            }
        }

        private void btattente_Click(object sender, EventArgs e)
        {

            popvalid popup = new popvalid(2);
            popup.ShowDialog();
            if (cDemande.isnewstatut)
            {
                cDemande.UpdateNotif(true);
                this.Close();

            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {

            popvalid popup = new popvalid(3);
            popup.ShowDialog();
            if (cDemande.isnewstatut)
            {
                cDemande.UpdateNotif(true);
                this.Close();

            }

        }


        
    }
}