using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            DataGridViewButtonColumn Btnaction = new DataGridViewButtonColumn();
            Btnaction.HeaderText = "Modification";
            Btnaction.Name = "Btnaction";
            Btnaction.Text = "Action";
            Btnaction.UseColumnTextForButtonValue = true;

            gvrequest.Columns.Add(Btnaction);

        }

        private void Bindlist()
        {

            gvrequest.DataSource = cDemande.listrequete();
        }

        private void gvrequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gvrequest.Columns["Btnaction"].Index && e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(gvrequest.Rows[e.RowIndex].Cells["Id_demande"].Value);

               
                cDemande.isrequest = true;
                cDemande.id_demande = selectedId;
                popupdemande popup = new popupdemande();
                popup.ShowDialog();


            }
        }
    }
}
