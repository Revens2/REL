using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblio;

namespace REL
{
    public partial class Historique : Form
    {
        public Historique()
        {
            InitializeComponent();
            BindDataGridView();
        }
        private void BindDataGridView()
        {
            cDemande histotique = new cDemande();
            gv_list.DataSource = histotique.listHistorique(cbstatut.Checked, Utilisateur.user_id);

        }

        private void cbstatut_CheckedChanged(object sender, EventArgs e)
        {
            BindDataGridView();
        }


    }
}
