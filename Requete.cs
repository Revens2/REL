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

        }

        private void Bindlist()
        {

            gvrequest.DataSource = cDemande.listrequete();
        }
    }
}
