using REL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblio
{
    public partial class ajoutlivre : Form
    {
        public ajoutlivre()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            string name = tbname.Text;
            string auteur = tbauteur.Text;
            int anne = Convert.ToInt32(tbanne.Text);
            string genre = tbgenre.Text;

            Livre unlivre = new Livre();


            if (Livre.AddLivre(name, auteur, anne, genre))
            {
                MessageBox.Show("bv t co ");

                this.Hide();
            }
            else
            {
                MessageBox.Show("gro naz");
            }
        }
    }
}
