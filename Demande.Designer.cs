namespace REL
{
    partial class Demande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btadd = new Button();
            gv_list = new DataGridView();
            cbprioritaire = new CheckBox();
            lbdemande = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btvalidate = new Button();
            notifyIcon1 = new NotifyIcon(components);
            lbcompteur = new Label();
            btexport = new Button();
            ((System.ComponentModel.ISupportInitialize)gv_list).BeginInit();
            SuspendLayout();
            // 
            // btadd
            // 
            btadd.BackColor = Color.FromArgb(70, 130, 180);
            btadd.Cursor = Cursors.Hand;
            btadd.FlatAppearance.BorderSize = 0;
            btadd.FlatStyle = FlatStyle.Flat;
            btadd.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btadd.ForeColor = Color.White;
            btadd.Location = new Point(228, 169);
            btadd.Margin = new Padding(2);
            btadd.Name = "btadd";
            btadd.Size = new Size(235, 26);
            btadd.TabIndex = 9;
            btadd.Text = "Ajouter une nouvelle demande";
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click;
            // 
            // gv_list
            // 
            gv_list.AllowUserToOrderColumns = true;
            gv_list.BackgroundColor = SystemColors.ActiveCaptionText;
            gv_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_list.Location = new Point(10, 212);
            gv_list.Margin = new Padding(2);
            gv_list.Name = "gv_list";
            gv_list.RowHeadersWidth = 82;
            gv_list.Size = new Size(998, 281);
            gv_list.TabIndex = 10;
            gv_list.CellContentClick += gv_list_CellContentClick;
            // 
            // cbprioritaire
            // 
            cbprioritaire.AutoSize = true;
            cbprioritaire.Location = new Point(10, 173);
            cbprioritaire.Margin = new Padding(3, 2, 3, 2);
            cbprioritaire.Name = "cbprioritaire";
            cbprioritaire.Size = new Size(161, 19);
            cbprioritaire.TabIndex = 30;
            cbprioritaire.Text = "Vos demandes prioritaires";
            cbprioritaire.UseVisualStyleBackColor = true;
            cbprioritaire.CheckedChanged += cbprioritaire_CheckedChanged;
            // 
            // lbdemande
            // 
            lbdemande.AutoSize = true;
            lbdemande.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbdemande.Location = new Point(10, 126);
            lbdemande.Name = "lbdemande";
            lbdemande.Size = new Size(328, 37);
            lbdemande.TabIndex = 31;
            lbdemande.Text = "Vos dernières demandes";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btvalidate
            // 
            btvalidate.BackColor = Color.FromArgb(0, 0, 64);
            btvalidate.Cursor = Cursors.Hand;
            btvalidate.FlatAppearance.BorderSize = 0;
            btvalidate.FlatStyle = FlatStyle.Flat;
            btvalidate.Font = new Font("Arial", 14F, FontStyle.Bold);
            btvalidate.ForeColor = Color.White;
            btvalidate.Location = new Point(732, 152);
            btvalidate.Margin = new Padding(2);
            btvalidate.Name = "btvalidate";
            btvalidate.Size = new Size(434, 34);
            btvalidate.TabIndex = 33;
            btvalidate.Text = "Demande en attente de validation";
            btvalidate.UseVisualStyleBackColor = false;
            btvalidate.Click += btvalidate_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // lbcompteur
            // 
            lbcompteur.AutoSize = true;
            lbcompteur.BackColor = Color.Red;
            lbcompteur.Location = new Point(1159, 142);
            lbcompteur.Name = "lbcompteur";
            lbcompteur.Size = new Size(13, 15);
            lbcompteur.TabIndex = 34;
            lbcompteur.Text = "1";
            // 
            // btexport
            // 
            btexport.BackColor = Color.Black;
            btexport.Cursor = Cursors.Hand;
            btexport.FlatAppearance.BorderSize = 0;
            btexport.FlatStyle = FlatStyle.Flat;
            btexport.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btexport.ForeColor = Color.White;
            btexport.Location = new Point(489, 169);
            btexport.Margin = new Padding(2);
            btexport.Name = "btexport";
            btexport.Size = new Size(131, 26);
            btexport.TabIndex = 35;
            btexport.Text = "Export en PDF";
            btexport.UseVisualStyleBackColor = false;
            btexport.Click += btexport_Click;
            // 
            // Demande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 502);
            Controls.Add(btexport);
            Controls.Add(lbcompteur);
            Controls.Add(btvalidate);
            Controls.Add(lbdemande);
            Controls.Add(cbprioritaire);
            Controls.Add(gv_list);
            Controls.Add(btadd);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Demande";
            Text = "Demande";
            ((System.ComponentModel.ISupportInitialize)gv_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btadd;
        private DataGridView gv_list;
        private CheckBox cbprioritaire;
        private Label lbdemande;
        private ContextMenuStrip contextMenuStrip1;
        private Button btvalidate;
        private NotifyIcon notifyIcon1;
        private Label lbcompteur;
        private Button btexport;
    }
}