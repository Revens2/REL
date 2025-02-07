﻿namespace REL
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
            btHistorique = new Button();
            btlogout = new Button();
            btaccount = new Button();
            cbprioritaire = new CheckBox();
            lbdemande = new Label();
            menuStrip1 = new MenuStrip();
            demandeToolStripMenuItem = new ToolStripMenuItem();
            ajouterDemandeToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btrequete = new Button();
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
            gv_list.Location = new Point(267, 283);
            gv_list.Margin = new Padding(2);
            gv_list.Name = "gv_list";
            gv_list.RowHeadersWidth = 82;
            gv_list.Size = new Size(866, 375);
            gv_list.TabIndex = 10;
            // 
            // btHistorique
            // 
            btHistorique.BackColor = Color.FromArgb(255, 165, 0);
            btHistorique.Cursor = Cursors.Hand;
            btHistorique.FlatAppearance.BorderSize = 0;
            btHistorique.FlatStyle = FlatStyle.Flat;
            btHistorique.Font = new Font("Arial", 14F, FontStyle.Bold);
            btHistorique.ForeColor = Color.White;
            btHistorique.Location = new Point(648, 16);
            btHistorique.Margin = new Padding(2);
            btHistorique.Name = "btHistorique";
            btHistorique.Size = new Size(152, 52);
            btHistorique.TabIndex = 11;
            btHistorique.Text = "Historique";
            btHistorique.UseVisualStyleBackColor = false;
            btHistorique.Click += btHistorique_Click;
            // 
            // btlogout
            // 
            btlogout.BackColor = Color.Silver;
            btlogout.Cursor = Cursors.Hand;
            btlogout.FlatAppearance.BorderSize = 0;
            btlogout.FlatStyle = FlatStyle.Flat;
            btlogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            btlogout.ForeColor = Color.White;
            btlogout.Location = new Point(1128, 16);
            btlogout.Margin = new Padding(2);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(185, 31);
            btlogout.TabIndex = 25;
            btlogout.Text = "Deconnexion";
            btlogout.UseVisualStyleBackColor = false;
            btlogout.Click += btlogout_Click;
            // 
            // btaccount
            // 
            btaccount.BackColor = Color.Firebrick;
            btaccount.Cursor = Cursors.Hand;
            btaccount.FlatAppearance.BorderSize = 0;
            btaccount.FlatStyle = FlatStyle.Flat;
            btaccount.Font = new Font("Arial", 14F, FontStyle.Bold);
            btaccount.ForeColor = Color.White;
            btaccount.Location = new Point(914, 16);
            btaccount.Margin = new Padding(2);
            btaccount.Name = "btaccount";
            btaccount.Size = new Size(143, 52);
            btaccount.TabIndex = 29;
            btaccount.Text = "Compte";
            btaccount.UseVisualStyleBackColor = false;
            btaccount.Click += btaccount_Click;
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
            // btrequete
            // 
            btrequete.BackColor = Color.Olive;
            btrequete.Cursor = Cursors.Hand;
            btrequete.FlatAppearance.BorderSize = 0;
            btrequete.FlatStyle = FlatStyle.Flat;
            btrequete.Font = new Font("Arial", 14F, FontStyle.Bold);
            btrequete.ForeColor = Color.White;
            btrequete.Location = new Point(454, 16);
            btrequete.Margin = new Padding(2);
            btrequete.Name = "btrequete";
            btrequete.Size = new Size(152, 52);
            btrequete.TabIndex = 33;
            btrequete.Text = "Requête";
            btrequete.UseVisualStyleBackColor = false;
            btrequete.Click += btrequete_Click;
            // 
            // Demande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1363, 669);
            Controls.Add(btrequete);
            Controls.Add(lbdemande);
            Controls.Add(cbprioritaire);
            Controls.Add(btaccount);
            Controls.Add(btlogout);
            Controls.Add(btHistorique);
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
        private Button btHistorique;
        private Button btlogout;
        private Button btaccount;
        private CheckBox cbprioritaire;
        private Label lbdemande;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem demandeToolStripMenuItem;
        private ToolStripMenuItem ajouterDemandeToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private Button btrequete;
    }
}