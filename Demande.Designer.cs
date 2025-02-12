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
            menuStrip1 = new MenuStrip();
            demandeToolStripMenuItem = new ToolStripMenuItem();
            ajouterDemandeToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)gv_list).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btadd
            // 
            btadd.BackColor = Color.FromArgb(70, 130, 180);
            btadd.Cursor = Cursors.Hand;
            btadd.FlatAppearance.BorderSize = 0;
            btadd.FlatStyle = FlatStyle.Flat;
            btadd.Font = new Font("Arial", 14F, FontStyle.Bold);
            btadd.ForeColor = Color.White;
            btadd.Location = new Point(267, 131);
            btadd.Margin = new Padding(2);
            btadd.Name = "btadd";
            btadd.Size = new Size(445, 45);
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
            gv_list.Location = new Point(11, 283);
            gv_list.Margin = new Padding(2);
            gv_list.Name = "gv_list";
            gv_list.RowHeadersWidth = 82;
            gv_list.Size = new Size(1341, 375);
            gv_list.TabIndex = 10;
            gv_list.CellContentClick += gv_list_CellContentClick;
            // 
            // cbprioritaire
            // 
            cbprioritaire.AutoSize = true;
            cbprioritaire.Location = new Point(272, 217);
            cbprioritaire.Name = "cbprioritaire";
            cbprioritaire.Size = new Size(277, 24);
            cbprioritaire.TabIndex = 30;
            cbprioritaire.Text = "Afficher les demandes non prioritaire";
            cbprioritaire.UseVisualStyleBackColor = true;
            cbprioritaire.CheckedChanged += cbprioritaire_CheckedChanged;
            // 
            // lbdemande
            // 
            lbdemande.AutoSize = true;
            lbdemande.Location = new Point(284, 244);
            lbdemande.Name = "lbdemande";
            lbdemande.Size = new Size(170, 20);
            lbdemande.TabIndex = 31;
            lbdemande.Text = "Vos dernières demandes";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { demandeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1363, 28);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // demandeToolStripMenuItem
            // 
            demandeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajouterDemandeToolStripMenuItem, modifierToolStripMenuItem });
            demandeToolStripMenuItem.Name = "demandeToolStripMenuItem";
            demandeToolStripMenuItem.Size = new Size(88, 24);
            demandeToolStripMenuItem.Text = "Demande";
            // 
            // ajouterDemandeToolStripMenuItem
            // 
            ajouterDemandeToolStripMenuItem.Name = "ajouterDemandeToolStripMenuItem";
            ajouterDemandeToolStripMenuItem.Size = new Size(208, 26);
            ajouterDemandeToolStripMenuItem.Text = "Ajouter demande";
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(208, 26);
            modifierToolStripMenuItem.Text = "Modifier";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Demande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 669);
            Controls.Add(lbdemande);
            Controls.Add(cbprioritaire);
            Controls.Add(gv_list);
            Controls.Add(btadd);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Demande";
            Text = "Demande";
            ((System.ComponentModel.ISupportInitialize)gv_list).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btadd;
        private DataGridView gv_list;
        private CheckBox cbprioritaire;
        private Label lbdemande;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem demandeToolStripMenuItem;
        private ToolStripMenuItem ajouterDemandeToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
    }
}