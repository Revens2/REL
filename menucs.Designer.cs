namespace REL
{
    partial class menucs
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            btdemande = new Button();
            btHistorique = new Button();
            btrequete = new Button();
            btaccount = new Button();
            btlogout = new Button();
            lbnotifdemande = new Label();
            lbnotifgestion = new Label();
            lbinfo = new Label();
            lbnotifhisto = new Label();
            SuspendLayout();
            // 
            // btdemande
            // 
            btdemande.BackColor = Color.FromArgb(70, 130, 180);
            btdemande.Cursor = Cursors.Hand;
            btdemande.FlatAppearance.BorderSize = 0;
            btdemande.FlatStyle = FlatStyle.Flat;
            btdemande.Font = new Font("Arial", 14F, FontStyle.Bold);
            btdemande.ForeColor = Color.White;
            btdemande.Location = new Point(11, 20);
            btdemande.Margin = new Padding(2);
            btdemande.Name = "btdemande";
            btdemande.Size = new Size(180, 52);
            btdemande.TabIndex = 33;
            btdemande.Text = "Vos Demande";
            btdemande.UseVisualStyleBackColor = false;
            btdemande.Click += btdemande_Click;
            // 
            // btHistorique
            // 
            btHistorique.BackColor = Color.FromArgb(255, 165, 0);
            btHistorique.Cursor = Cursors.Hand;
            btHistorique.FlatAppearance.BorderSize = 0;
            btHistorique.FlatStyle = FlatStyle.Flat;
            btHistorique.Font = new Font("Arial", 14F, FontStyle.Bold);
            btHistorique.ForeColor = Color.White;
            btHistorique.Location = new Point(553, 20);
            btHistorique.Margin = new Padding(2);
            btHistorique.Name = "btHistorique";
            btHistorique.Size = new Size(152, 52);
            btHistorique.TabIndex = 34;
            btHistorique.Text = "Historique";
            btHistorique.UseVisualStyleBackColor = false;
            btHistorique.Click += btHistorique_Click;
            // 
            // btrequete
            // 
            btrequete.BackColor = Color.Olive;
            btrequete.Cursor = Cursors.Hand;
            btrequete.FlatAppearance.BorderSize = 0;
            btrequete.FlatStyle = FlatStyle.Flat;
            btrequete.Font = new Font("Arial", 14F, FontStyle.Bold);
            btrequete.ForeColor = Color.White;
            btrequete.Location = new Point(225, 20);
            btrequete.Margin = new Padding(2);
            btrequete.Name = "btrequete";
            btrequete.Size = new Size(293, 52);
            btrequete.TabIndex = 35;
            btrequete.Text = "Gestion des demandes";
            btrequete.UseVisualStyleBackColor = false;
            btrequete.Click += btrequete_Click;
            // 
            // btaccount
            // 
            btaccount.BackColor = Color.Firebrick;
            btaccount.Cursor = Cursors.Hand;
            btaccount.FlatAppearance.BorderSize = 0;
            btaccount.FlatStyle = FlatStyle.Flat;
            btaccount.Font = new Font("Arial", 14F, FontStyle.Bold);
            btaccount.ForeColor = Color.White;
            btaccount.Location = new Point(730, 20);
            btaccount.Margin = new Padding(2);
            btaccount.Name = "btaccount";
            btaccount.Size = new Size(143, 52);
            btaccount.TabIndex = 36;
            btaccount.Text = "Compte";
            btaccount.UseVisualStyleBackColor = false;
            btaccount.Click += btaccount_Click;
            // 
            // btlogout
            // 
            btlogout.BackColor = Color.Silver;
            btlogout.Cursor = Cursors.Hand;
            btlogout.FlatAppearance.BorderSize = 0;
            btlogout.FlatStyle = FlatStyle.Flat;
            btlogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            btlogout.ForeColor = Color.White;
            btlogout.Location = new Point(904, 20);
            btlogout.Margin = new Padding(2);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(185, 52);
            btlogout.TabIndex = 37;
            btlogout.Text = "Deconnexion";
            btlogout.UseVisualStyleBackColor = false;
            btlogout.Click += btlogout_Click;
            // 
            // lbnotifdemande
            // 
            lbnotifdemande.AutoSize = true;
            lbnotifdemande.BackColor = Color.Red;
            lbnotifdemande.Location = new Point(184, 11);
            lbnotifdemande.Name = "lbnotifdemande";
            lbnotifdemande.Size = new Size(17, 20);
            lbnotifdemande.TabIndex = 38;
            lbnotifdemande.Text = "1";
            // 
            // lbnotifgestion
            // 
            lbnotifgestion.AutoSize = true;
            lbnotifgestion.BackColor = Color.Red;
            lbnotifgestion.Location = new Point(510, 11);
            lbnotifgestion.Name = "lbnotifgestion";
            lbnotifgestion.Size = new Size(17, 20);
            lbnotifgestion.TabIndex = 39;
            lbnotifgestion.Text = "1";
            // 
            // lbinfo
            // 
            lbinfo.AutoSize = true;
            lbinfo.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbinfo.Location = new Point(1127, 25);
            lbinfo.Name = "lbinfo";
            lbinfo.Size = new Size(94, 38);
            lbinfo.TabIndex = 41;
            lbinfo.Text = "label2";
            // 
            // lbnotifhisto
            // 
            lbnotifhisto.AutoSize = true;
            lbnotifhisto.BackColor = Color.Red;
            lbnotifhisto.Location = new Point(698, 11);
            lbnotifhisto.Name = "lbnotifhisto";
            lbnotifhisto.Size = new Size(17, 20);
            lbnotifhisto.TabIndex = 42;
            lbnotifhisto.Text = "1";
            // 
            // menucs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbnotifhisto);
            Controls.Add(lbinfo);
            Controls.Add(lbnotifgestion);
            Controls.Add(lbnotifdemande);
            Controls.Add(btlogout);
            Controls.Add(btaccount);
            Controls.Add(btrequete);
            Controls.Add(btHistorique);
            Controls.Add(btdemande);
            Name = "menucs";
            Size = new Size(1380, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btdemande;
        private Button btHistorique;
        private Button btrequete;
        private Button btaccount;
        private Button btlogout;
        private Label lbnotifdemande;
        private Label lbnotifgestion;
        private Label lbinfo;
        private Label lbnotifhisto;
    }
}
