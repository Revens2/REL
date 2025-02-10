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

            LoadRoomData();

        }
        // Chargement des données dans le DataGridView
        private void LoadRoomData()

        {
            DataGridViewCheckBoxColumn radioButtonColumn = new DataGridViewCheckBoxColumn();
            radioButtonColumn.HeaderText = "Sélectionner";
            radioButtonColumn.Name = "radioButtonColumn";
            radioButtonColumn.Width = 50;
            gvlistvehi.Columns.Add(radioButtonColumn);
            string query = "SELECT id_reunion, nom_salle, nb_place FROM reunion";
            DataTable dt = cBdd.ExecuteSelectToDataTable(query);
            gvlistvehi.DataSource = dt;
        

        }
        private void gv_list_vehi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gvlistvehi.Columns["radioButtonColumn"].Index && e.RowIndex >= 0)
            {
                foreach (DataGridViewRow row in gvlistvehi.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = (DataGridViewCheckBoxCell)row.Cells["radioButtonColumn"];
                    checkBox.Value = row.Index == e.RowIndex;
                }
            }
        }
        private void gv_list_vehi_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (gvlistvehi.CurrentCell is DataGridViewCheckBoxCell)
            {
                gvlistvehi.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }


        private List<int> GetSelectedRooms()
        {
            List<int> selectedRoomIds = new List<int>();
            foreach (DataGridViewRow row in gvlistvehi.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["SelectColumn"].Value);
                if (isSelected)
                {
                    int roomId = Convert.ToInt32(row.Cells["id_reunion"].Value);
                    selectedRoomIds.Add(roomId);
                }
            }
            return selectedRoomIds;
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
                    foreach (DataGridViewRow row in gvlistvehi.Rows)
                    {
                        bool isSelected = Convert.ToBoolean(row.Cells["radioButtonColumn"].Value);
                        if (isSelected)
                        {
                            int id = Convert.ToInt32(row.Cells["id_reunion"].Value); 
                            cDemande.Demandereunionsave(id);
                            
                        }
                    }
                    break;

                case 3:
                    cDemande.Demandevehiculesave(dllservice.SelectedIndex);
                    break;
            }
        }
    }
}