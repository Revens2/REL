using Biblio;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            BindDataGridView();
            btdelete.Visible = false;
            btedit.Visible = false;
           

        }

        private void BindDataGridView()
        {
            Livre monlivre = new Livre();
            gv_list.DataSource = monlivre.GetLivreInfo();
        }

        private void btadd_Click(object sender, EventArgs e)
        {

            this.Hide();
            ajoutlivre page = new ajoutlivre();
            page.ShowDialog();
            //string Nom = tbnom.Text;
            //string Prenom = tbprenom.Text;
            //int Age = Convert.ToInt32(tbage.Text);

            //Contact MonContact = new Contact(Nom, Prenom, Age);

            //Contact.Add(Nom, Prenom, Age);
            //BindDataGridView();
        }



        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            //if (e.RowIndex >= 0 && gv_list.Rows[e.RowIndex].Cells["nom_contact"].Value != null)
            //{
             
            //    DataGridViewRow selectedRow = gv_list.Rows[e.RowIndex];
            //    tbid.Text = selectedRow.Cells["id"].Value?.ToString() ?? "";
            //    tbnom.Text = selectedRow.Cells["nom_contact"].Value?.ToString() ?? "";
            //    tbprenom.Text = selectedRow.Cells["prenom_contact"].Value?.ToString() ?? "";
            //    tbage.Text = selectedRow.Cells["age"].Value?.ToString() ?? "";

            //}
            

           

            //btadd.Visible = false;
            //btdelete.Visible = true;
            //btedit.Visible = true;

        }

        private void btedit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbid.Text);
            string Nom = tbnom.Text;
            string Prenom = tbprenom.Text;
            int Age = Convert.ToInt32(tbage.Text);
            //Contact.update(Nom, Prenom, Age,id);
            BindDataGridView();
            ResetForm();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbid.Text);
            //Contact.delete(id);
            BindDataGridView();
            tbid.Text = "";
            tbnom.Text = "";
            tbprenom.Text = "";
            tbage.Text = "";
            btadd.Visible = true;
            btdelete.Visible = false;
            btedit.Visible = false;
            ResetForm();
        }
        private void ResetForm()
        {
            tbid.Text = "";
            tbnom.Text = "";
            tbprenom.Text = "";
            tbage.Text = "";
            btadd.Visible = true;
            btdelete.Visible = false;
            btedit.Visible = false;
        }
    }
}
