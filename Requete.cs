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
            Bindlist();
           

        }

        private void Bindlist()
        {
            gvrequest.Columns.Clear();
            gvrequest.DataSource = cDemande.listrequete(cbfinal.Checked);
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

        private void cbfinal_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }
    }
}
