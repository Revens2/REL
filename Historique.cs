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
    public partial class Historique : Form
    {
        private menucs menu;
        private int globaluserid = 0;
        public Historique(int userid)
        {
            globaluserid = userid;
            InitializeComponent();
            Bindlist();
            menu = new menucs(userid);
            menu.Dock = DockStyle.Top;
            this.Controls.Add(menu);
            cDemande.UpdateHistoNotif(false, globaluserid);
        }
        private void Bindlist()
        {
            cDemande dem = new cDemande();
            dem.Statut = 6;
            if (cbstatut.Checked)
            {
                dem.Statut = 4;
            }
            gv_list.DataSource = dem.listHistorique(globaluserid);

        }

        private void cbstatut_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }


    }
}
