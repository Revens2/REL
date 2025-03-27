using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace REL
{
    public partial class Requete : Form
    {
        private menucs menu;
        public Requete()
        {
            InitializeComponent();
            menu = new menucs();
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
            gvrequest.DataBindingComplete += gvrequest_DataBindingComplete;     
            Bindlist();
           

        }

        private void Bindlist()
        {
            gvrequest.Columns.Clear();
            cDemande cDemande = new cDemande();
            cDemande.Final = cBdd.CbConvert(cbfinal.Checked);
            gvrequest.DataSource = cDemande.listrequete();
            gvrequest.Columns["id_demande"].Visible = false;
            if (cbfinal.Checked)
            {
                DataGridViewButtonColumn Btnclo = new DataGridViewButtonColumn();
                Btnclo.HeaderText = "Cloture";
                Btnclo.Name = "Btnclo";
                Btnclo.Text = "Cloturer la demande";
                Btnclo.UseColumnTextForButtonValue = true;

                gvrequest.Columns.Add(Btnclo);
                
            }
            else
            {
                DataGridViewButtonColumn Btndem = new DataGridViewButtonColumn();
                Btndem.HeaderText = "Modification";
                Btndem.Name = "Btndem";
                Btndem.Text = "Gerer la demande";
                Btndem.UseColumnTextForButtonValue = true;

                gvrequest.Columns.Add(Btndem);
            }

        }

        private void gvrequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbfinal.Checked)
            {
                if (e.ColumnIndex == gvrequest.Columns["Btnclo"].Index && e.RowIndex >= 0)
                {
                    int selectedId = Convert.ToInt32(gvrequest.Rows[e.RowIndex].Cells["Id_demande"].Value);
                    cDemande.id_demande = selectedId;
                    popvalid popup = new popvalid(4);
                    popup.ShowDialog();

                }
            }
            else
            {

                if (e.ColumnIndex == gvrequest.Columns["Btndem"].Index && e.RowIndex >= 0)
                {
                    int selectedId = Convert.ToInt32(gvrequest.Rows[e.RowIndex].Cells["Id_demande"].Value);

                    cDemande.isrequest = true;
                    cDemande.id_demande = selectedId;
                    popupdemande popup = new popupdemande();
                    popup.ShowDialog();

                }
            }
        
            Bindlist();
        }

        private void gvrequest_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in gvrequest.Rows)
            {
                if (row.Cells["statut"].Value != null && row.Cells["statut"].Value.ToString() == "1")
                {
                    row.DefaultCellStyle.BackColor = Color.SkyBlue;
                }

                if (row.Cells["statut"].Value != null && row.Cells["statut"].Value.ToString() == "3")
                {
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                }
            }
        }


        private void cbfinal_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }
    }
}
