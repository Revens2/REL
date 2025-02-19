using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace REL
{
    public partial class Demande : Form
    {
        private menucs menu;
        public Demande()
        {
            InitializeComponent();
            Bindlist();

            menu = new menucs();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Action";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Modifier";
            btnEdit.UseColumnTextForButtonValue = true;

            gv_list.Columns.Add(btnEdit);
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Action";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Supprimer";
            btnDelete.UseColumnTextForButtonValue = true;

            gv_list.Columns.Add(btnDelete);


        }

        private void Bindlist()
        {
            cDemande dem = new cDemande();
            gv_list.DataSource = dem.listDemande(cUtilisateur.user_id, cBdd.CbConvert(cbprioritaire.Checked));

            int compteur = 0;

            foreach (DataGridViewRow row in gv_list.Rows)
            {
                if (row.Cells["statut"].Value != null && row.Cells["statut"].Value.ToString() == "2") 
                {
                    compteur++;
                }
            }
            if (compteur != 0)
            {
                lbcompteur.Text = compteur.ToString();
                lbcompteur.Visible = true;
                btvalidate.Visible = true;
            }
            else
            {
                lbcompteur.Visible = false;
                btvalidate.Visible = false;
            }


        }

        private void btadd_Click(object sender, EventArgs e)
        {
            cDemande.id_demande = 0;
            popupdemande popup = new popupdemande();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.Show();
        }



        private void cbprioritaire_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }



        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_list.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(gv_list.Rows[e.RowIndex].Cells["Id_demande"].Value);

                cDemande.id_demande = selectedId;
                popupdemande popup = new popupdemande();
                popup.ShowDialog();


            }

            if (e.ColumnIndex == gv_list.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(gv_list.Rows[e.RowIndex].Cells["Id_demande"].Value);

                cDemande.deletedemande(selectedId);
                Bindlist();

            }
        }

        private void btvalidate_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gv_list.Rows)
            {
                if (row.Cells["statut"].Value != null && row.Cells["statut"].Value.ToString() == "2")

                {
                    cDemande.id_demande = Convert.ToInt32(row.Cells["id_demande"].Value);
                    popvalid popup = new popvalid(5);
                    popup.ShowDialog();
                    Bindlist();
                }
            }
        }
    }

}
