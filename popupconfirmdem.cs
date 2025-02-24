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
    public partial class popupconfirmdem : Form
    {
        public popupconfirmdem()
        {
            InitializeComponent();
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            cDemande.id_demande = 0;
            this.Close();

        }

        private void btsave_Click(object sender, EventArgs e)
        {
            cDemande.valideRDV(cDemande.id_demande);
            cDemande.UpdateNotif(true);
            menucs menu = new menucs();
            menu.BindNotif();
            Requete requete = new Requete();
            requete.Invalidate();
            requete.Update();
            this.Close();
        }
    }
}
