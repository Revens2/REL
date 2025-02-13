﻿using System;
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

            
           


        }
        private void btadd_Click(object sender, EventArgs e)
        {

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

                popupdemande popup = new popupdemande(selectedId,false);
                popup.ShowDialog();


            }

            if (e.ColumnIndex == gv_list.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(gv_list.Rows[e.RowIndex].Cells["Id_demande"].Value);

                cDemande.deletedemande(selectedId);
                Bindlist();

            }
        }
        
    }

}
