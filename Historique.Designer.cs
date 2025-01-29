namespace REL
{
    partial class Historique
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
            gv_list = new DataGridView();
            cbstatut = new CheckBox();
            btlogout = new Button();
            btdemande = new Button();
            btaccount = new Button();
            ((System.ComponentModel.ISupportInitialize)gv_list).BeginInit();
            SuspendLayout();
            // 
            // gv_list
            // 
            gv_list.AllowUserToOrderColumns = true;
            gv_list.BackgroundColor = SystemColors.ActiveCaptionText;
            gv_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_list.Location = new Point(159, 140);
            gv_list.Margin = new Padding(2);
            gv_list.Name = "gv_list";
            gv_list.RowHeadersWidth = 82;
            gv_list.Size = new Size(677, 375);
            gv_list.TabIndex = 8;
            // 
            // cbstatut
            // 
            cbstatut.AutoSize = true;
            cbstatut.Location = new Point(206, 86);
            cbstatut.Name = "cbstatut";
            cbstatut.Size = new Size(248, 24);
            cbstatut.TabIndex = 9;
            cbstatut.Text = "Afficher les Demandes Annulées ";
            cbstatut.UseVisualStyleBackColor = true;
            cbstatut.CheckedChanged += cbstatut_CheckedChanged;
            // 
            // btlogout
            // 
            btlogout.BackColor = Color.Silver;
            btlogout.Cursor = Cursors.Hand;
            btlogout.FlatAppearance.BorderSize = 0;
            btlogout.FlatStyle = FlatStyle.Flat;
            btlogout.Font = new Font("Arial", 14F, FontStyle.Bold);
            btlogout.ForeColor = Color.White;
            btlogout.Location = new Point(821, 11);
            btlogout.Margin = new Padding(2);
            btlogout.Name = "btlogout";
            btlogout.Size = new Size(178, 31);
            btlogout.TabIndex = 26;
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
            btdemande.Location = new Point(186, 11);
            btdemande.Margin = new Padding(2);
            btdemande.Name = "btdemande";
            btdemande.Size = new Size(129, 45);
            btdemande.TabIndex = 27;
            btdemande.Text = "Demande";
            btdemande.UseVisualStyleBackColor = false;
            btdemande.Click += btdemande_Click;
            // 
            // btaccount
            // 
            btaccount.BackColor = Color.Firebrick;
            btaccount.Cursor = Cursors.Hand;
            btaccount.FlatAppearance.BorderSize = 0;
            btaccount.FlatStyle = FlatStyle.Flat;
            btaccount.Font = new Font("Arial", 14F, FontStyle.Bold);
            btaccount.ForeColor = Color.White;
            btaccount.Location = new Point(556, 7);
            btaccount.Margin = new Padding(2);
            btaccount.Name = "btaccount";
            btaccount.Size = new Size(143, 52);
            btaccount.TabIndex = 28;
            btaccount.Text = "Compte";
            btaccount.UseVisualStyleBackColor = false;
            btaccount.Click += btaccount_Click;
            // 
            // Historique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 535);
            Controls.Add(btaccount);
            Controls.Add(btdemande);
            Controls.Add(btlogout);
            Controls.Add(cbstatut);
            Controls.Add(gv_list);
            Name = "Historique";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gv_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gv_list;
        private CheckBox cbstatut;
        private Button btlogout;
        private Button btdemande;
        private Button btaccount;
    }
}