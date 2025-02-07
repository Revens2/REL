namespace REL
{
    partial class Requete
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
            btHistorique = new Button();
            btaccount = new Button();
            btlogout = new Button();
            btdemande = new Button();
            SuspendLayout();
            // 
            // btHistorique
            // 
            btHistorique.BackColor = Color.FromArgb(255, 165, 0);
            btHistorique.Cursor = Cursors.Hand;
            btHistorique.FlatAppearance.BorderSize = 0;
            btHistorique.FlatStyle = FlatStyle.Flat;
            btHistorique.Font = new Font("Arial", 14F, FontStyle.Bold);
            btHistorique.ForeColor = Color.White;
            btHistorique.Location = new Point(383, 24);
            btHistorique.Margin = new Padding(2);
            btHistorique.Name = "btHistorique";
            btHistorique.Size = new Size(152, 52);
            btHistorique.TabIndex = 12;
            btHistorique.Text = "Historique";
            btHistorique.UseVisualStyleBackColor = false;
            btHistorique.Click += btHistorique_Click;
            // 
            // btaccount
            // 
            btaccount.BackColor = Color.Firebrick;
            btaccount.Cursor = Cursors.Hand;
            btaccount.FlatAppearance.BorderSize = 0;
            btaccount.FlatStyle = FlatStyle.Flat;
            btaccount.Font = new Font("Arial", 14F, FontStyle.Bold);
            btaccount.ForeColor = Color.White;
            btaccount.Location = new Point(561, 24);
            btaccount.Margin = new Padding(2);
            btaccount.Name = "btaccount";
            btaccount.Size = new Size(143, 52);
            btaccount.TabIndex = 30;
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
            btlogout.Location = new Point(909, 24);
            btlogout.Margin = new Padding(2);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(184, 52);
            btlogout.TabIndex = 31;
            btlogout.Text = "Deconnexion";
            btlogout.UseVisualStyleBackColor = false;
            btlogout.Click += btlogout_Click;
            // 
            // btdemande
            // 
            btdemande.BackColor = Color.FromArgb(70, 130, 180);
            btdemande.Cursor = Cursors.Hand;
            btdemande.FlatAppearance.BorderSize = 0;
            btdemande.FlatStyle = FlatStyle.Flat;
            btdemande.Font = new Font("Arial", 14F, FontStyle.Bold);
            btdemande.ForeColor = Color.White;
            btdemande.Location = new Point(183, 24);
            btdemande.Margin = new Padding(2);
            btdemande.Name = "btdemande";
            btdemande.Size = new Size(137, 52);
            btdemande.TabIndex = 32;
            btdemande.Text = "Demande";
            btdemande.UseVisualStyleBackColor = false;
            btdemande.Click += btdemande_Click;
            // 
            // Requete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 495);
            Controls.Add(btdemande);
            Controls.Add(btlogout);
            Controls.Add(btaccount);
            Controls.Add(btHistorique);
            Name = "Requete";
            Text = "Requete";
            ResumeLayout(false);
        }

        #endregion

        private Button btHistorique;
        private Button btaccount;
        private Button btlogout;
        private Button btdemande;
    }
}