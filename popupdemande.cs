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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace REL
{
    public partial class popupdemande : Form
    {
        private int globaluserid = 0;
        private int globaldemandeid = 0;
        public popupdemande(int userid, int demandeid, bool Isrequest)
        {
            globaluserid = userid;
            globaldemandeid = demandeid; 
            InitializeComponent();
            tbdatedebut.Value = DateTime.Now;
            tbdateend.Value = DateTime.Now;
            ddltype.Items.Add("Sélectionnez une option");
            ddltype.Items.Add("Un Service");
            ddltype.Items.Add("Une Réunion");
            ddltype.Items.Add("Un Véhicule");
            ddltype.SelectedIndex = 0;

            pnlrequest.Visible = false;
            cDemande cDemande = new cDemande(globaldemandeid);
            if (globaldemandeid != 0)
            {
                Bindedit(globaldemandeid);
                if (Isrequest)
                {
                    pnlrequest.Visible = true;

                }
            }
            Bindlist();
        }
        private void Bindlist()
        {

            cDemande cDemande = new cDemande(globaldemandeid);
            switch (ddltype.SelectedIndex)
            {
                case 1:
                    gvserv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvserv.MultiSelect = false;
                    DataTable dt = cDemande.ListService();
                    gvserv.DataSource = dt;
                    break;
                case 2:
                    gvreu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvreu.MultiSelect = false;
                    DataTable dt2 = cDemande.ListReunion();
                    gvreu.DataSource = dt2;
                    break;
                case 3:
                    gvvehi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    gvvehi.MultiSelect = false;
                    DataTable dt3 = cDemande.ListVehicule();
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

            cDemande cDemande = new cDemande(globaldemandeid);
            if (ddltype.SelectedIndex == 0)
            {
                MessageBox.Show("Veuillez selectionner le type de la demande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ddltype.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(tbobjet.Text))
            {
                MessageBox.Show("Veuillez saisir l'objet de la demande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbobjet.Focus();
                return;
            }
            if (tbdatedebut.Value >= tbdateend.Value)
            {
                MessageBox.Show("Veillez à ce que la date de début soit inférieur ou égale a la date de fin.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbobjet.Focus();
                return;
            }
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
            cDemande.DemandeSave(ddltype.SelectedIndex, tbobjet.Text, tbcom.Text, cBdd.CbConvertInt(cbprioritaire.Checked), cBdd.DateConvert(tbdatedebut.Value), cBdd.DateConvert(tbdateend.Value), globaluserid, super_id);
            Demande demande = new Demande(globaluserid);

            demande.Bindlist();
            this.Close();
        }

        private void Bindedit(int id)
        {

            cDemande cDemande = new cDemande(globaldemandeid);
            DataTable dt = cDemande.ListBackDemande();
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
            cDemande cDemande = new cDemande(globaldemandeid);
            int oldstatut = cDemande.Statut;
            popvalid popup = new popvalid(globaluserid, 1, globaldemandeid);
            popup.ShowDialog();

            cDemande newcDemande = new cDemande(globaldemandeid);
            if (oldstatut != newcDemande.Statut)
            {
                this.Close();

            }
        }

        private void btattente_Click(object sender, EventArgs e)
        {
            cDemande cDemande = new cDemande(globaldemandeid);
            int oldstatut = cDemande.Statut;
            popvalid popup = new popvalid(globaluserid, 2, globaldemandeid);
            popup.ShowDialog();
            cDemande newcDemande = new cDemande(globaldemandeid);
            if (oldstatut != newcDemande.Statut)
            {
                cDemande.UpdateNotif(true);
                this.Close();

            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            cDemande cDemande = new cDemande(globaldemandeid);
            int oldstatut = cDemande.Statut;
            popvalid popup = new popvalid(globaluserid,3, globaldemandeid);
            popup.ShowDialog();
            cDemande newcDemande = new cDemande(globaldemandeid);
            if (oldstatut != newcDemande.Statut)
            {
                cDemande.UpdateNotif(true);
                this.Close();

            }

        }


        
    }
}