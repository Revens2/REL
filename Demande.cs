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

   
    }

}
