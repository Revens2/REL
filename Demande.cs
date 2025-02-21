using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Action";
            btnEdit.Name = "btnEdit";
            btnEdit.Text = "Modifier";
            btnEdit.UseColumnTextForButtonValue = true;

            gv_list.Columns.Add(btnEdit);

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
            btnDelete.HeaderText = "Action";
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Supprimer";
            btnDelete.UseColumnTextForButtonValue = true;

            gv_list.Columns.Add(btnDelete);


        }

        public void Bindlist()
        {
            cDemande dem = new cDemande();
            gv_list.DataSource = dem.listDemande(cUtilisateur.user_id, cBdd.CbConvert(cbprioritaire.Checked));

            int compteur = 0;

            foreach (DataGridViewRow row in gv_list.Rows)
            {
                if (row.Cells["statut"].Value != null && row.Cells["statut"].Value.ToString() == "2")
                {
                    compteur++;
                }
            }
            if (compteur != 0)
            {
                lbcompteur.Text = compteur.ToString();
                lbcompteur.Visible = true;
                btvalidate.Visible = true;
            }
            else
            {
                lbcompteur.Visible = false;
                btvalidate.Visible = false;
            }


        }

        private void btadd_Click(object sender, EventArgs e)
        {
            cDemande.id_demande = 0;
            popupdemande popup = new popupdemande();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.Show();
            Bindlist();
        }



        private void cbprioritaire_CheckedChanged(object sender, EventArgs e)
        {
            Bindlist();
        }



        private void gv_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gv_list.Columns["btnEdit"].Index && e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(gv_list.Rows[e.RowIndex].Cells["Id_demande"].Value);

                cDemande.id_demande = selectedId;
                popupdemande popup = new popupdemande();
                popup.ShowDialog();


            }

            if (e.ColumnIndex == gv_list.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                int selectedId = Convert.ToInt32(gv_list.Rows[e.RowIndex].Cells["Id_demande"].Value);

                cDemande.deletedemande(selectedId);
                Bindlist();

            }
        }

        private void btvalidate_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gv_list.Rows)
            {
                if (row.Cells["statut"].Value != null && row.Cells["statut"].Value.ToString() == "2")

                {
                    cDemande.id_demande = Convert.ToInt32(row.Cells["id_demande"].Value);
                    popvalid popup = new popvalid(5);
                    popup.ShowDialog();
                    Bindlist();
                }
            }
        }

        private void btexport_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "ExportDemandes.pdf");
            ExportGridToPdf(filePath);
        }
        public void ExportGridToPdf(string filePath)
        {
            // Définir la page du document avec des marges
            Document document = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            // Déterminer le nombre de colonnes visibles dans gv_list
            int visibleColumnCount = 0;
            foreach (DataGridViewColumn col in gv_list.Columns)
            {
                if (col.Visible)
                    visibleColumnCount++;
            }

            // Créer un tableau PDF avec autant de colonnes que de colonnes visibles
            PdfPTable pdfTable = new PdfPTable(visibleColumnCount);
            pdfTable.WidthPercentage = 100;
            pdfTable.SpacingBefore = 10f;
            pdfTable.SpacingAfter = 10f;

            // Ajouter les en-têtes
            foreach (DataGridViewColumn column in gv_list.Columns)
            {
                if (column.Visible)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial", "10", Font.Bold)));
                    headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    headerCell.BackgroundColor = new BaseColor(240, 240, 240);
                    pdfTable.AddCell(headerCell);
                }
            }

            // Ajouter les lignes du DataGridView
            foreach (DataGridViewRow row in gv_list.Rows)
            {
                // Sauter la ligne de création de nouvelle ligne
                if (row.IsNewRow)
                    continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Exporter uniquement les cellules appartenant à une colonne visible
                    if (cell.OwningColumn.Visible)
                    {
                        string cellText = cell.Value != null ? cell.Value.ToString() : "";
                        PdfPCell pdfCell = new PdfPCell(new Phrase(cellText, FontFactory.GetFont("Arial", "10", Font.Bold)));
                        pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.AddCell(pdfCell);
                    }
                }
            }

            // Ajouter le tableau au document
            document.Add(pdfTable);
            document.Close();
            writer.Close();
        }

    }
}
    
