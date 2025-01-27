namespace REL
{
    partial class main
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            v = new Label();
            tbnom = new TextBox();
            tbprenom = new TextBox();
            label3 = new Label();
            tbage = new TextBox();
            gv_list = new DataGridView();
            btadd = new Button();
            btedit = new Button();
            btdelete = new Button();
            tbid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gv_list).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 20);
            label1.Name = "label1";
            label1.Size = new Size(503, 63);
            label1.TabIndex = 0;
            label1.Text = "Ajouter un contact";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1240, 52);
            label2.Name = "label2";
            label2.Size = new Size(265, 49);
            label2.TabIndex = 1;
            label2.Text = "Nom contact";
            // 
            // v
            // 
            v.AutoSize = true;
            v.Font = new Font("Arial", 16F);
            v.ForeColor = Color.White;
            v.Location = new Point(1240, 172);
            v.Name = "v";
            v.Size = new Size(325, 49);
            v.TabIndex = 3;
            v.Text = "Prénom contact";
            // 
            // tbnom
            // 
            tbnom.BackColor = Color.White;
            tbnom.BorderStyle = BorderStyle.FixedSingle;
            tbnom.Font = new Font("Arial", 14F);
            tbnom.ForeColor = Color.Black;
            tbnom.Location = new Point(1240, 92);
            tbnom.Name = "tbnom";
            tbnom.ScrollBars = ScrollBars.Horizontal;
            tbnom.Size = new Size(300, 50);
            tbnom.TabIndex = 2;
            // 
            // tbprenom
            // 
            tbprenom.BackColor = Color.White;
            tbprenom.BorderStyle = BorderStyle.FixedSingle;
            tbprenom.Font = new Font("Arial", 14F);
            tbprenom.ForeColor = Color.Black;
            tbprenom.Location = new Point(1240, 212);
            tbprenom.Name = "tbprenom";
            tbprenom.ScrollBars = ScrollBars.Horizontal;
            tbprenom.Size = new Size(300, 50);
            tbprenom.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1240, 292);
            label3.Name = "label3";
            label3.Size = new Size(260, 49);
            label3.TabIndex = 5;
            label3.Text = "Age Contact";
            // 
            // tbage
            // 
            tbage.BackColor = Color.White;
            tbage.BorderStyle = BorderStyle.FixedSingle;
            tbage.Font = new Font("Arial", 14F);
            tbage.ForeColor = Color.Black;
            tbage.Location = new Point(1425, 223);
            tbage.Name = "tbage";
            tbage.ScrollBars = ScrollBars.Horizontal;
            tbage.Size = new Size(300, 50);
            tbage.TabIndex = 6;
            // 
            // gv_list
            // 
            gv_list.AllowUserToOrderColumns = true;
            gv_list.BackgroundColor = SystemColors.ActiveCaptionText;
            gv_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_list.Location = new Point(276, 292);
            gv_list.Name = "gv_list";
            gv_list.RowHeadersWidth = 82;
            gv_list.Size = new Size(1100, 600);
            gv_list.TabIndex = 7;
            gv_list.CellContentClick += gv_list_CellContentClick;
            // 
            // btadd
            // 
            btadd.BackColor = Color.FromArgb(70, 130, 180);
            btadd.Cursor = Cursors.Hand;
            btadd.FlatAppearance.BorderSize = 0;
            btadd.FlatStyle = FlatStyle.Flat;
            btadd.Font = new Font("Arial", 14F, FontStyle.Bold);
            btadd.ForeColor = Color.White;
            btadd.Location = new Point(276, 210);
            btadd.Name = "btadd";
            btadd.Size = new Size(404, 50);
            btadd.TabIndex = 8;
            btadd.Text = "Ajouter un livre";
            btadd.UseVisualStyleBackColor = false;
            btadd.Click += btadd_Click;
            // 
            // btedit
            // 
            btedit.BackColor = Color.FromArgb(255, 165, 0);
            btedit.Cursor = Cursors.Hand;
            btedit.FlatAppearance.BorderSize = 0;
            btedit.FlatStyle = FlatStyle.Flat;
            btedit.Font = new Font("Arial", 14F, FontStyle.Bold);
            btedit.ForeColor = Color.White;
            btedit.Location = new Point(1395, 313);
            btedit.Name = "btedit";
            btedit.Size = new Size(120, 50);
            btedit.TabIndex = 9;
            btedit.Text = "Modifier";
            btedit.UseVisualStyleBackColor = false;
            btedit.Click += btedit_Click;
            // 
            // btdelete
            // 
            btdelete.BackColor = Color.FromArgb(220, 20, 60);
            btdelete.Cursor = Cursors.Hand;
            btdelete.FlatAppearance.BorderSize = 0;
            btdelete.FlatStyle = FlatStyle.Flat;
            btdelete.Font = new Font("Arial", 14F, FontStyle.Bold);
            btdelete.ForeColor = Color.White;
            btdelete.Location = new Point(1605, 313);
            btdelete.Name = "btdelete";
            btdelete.Size = new Size(120, 50);
            btdelete.TabIndex = 10;
            btdelete.Text = "Supprimer";
            btdelete.UseVisualStyleBackColor = false;
            btdelete.Click += btdelete_Click;
            // 
            // tbid
            // 
            tbid.Location = new Point(812, 28);
            tbid.Name = "tbid";
            tbid.Size = new Size(200, 39);
            tbid.TabIndex = 11;
            tbid.Visible = false;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1770, 1022);
            Controls.Add(tbid);
            Controls.Add(btdelete);
            Controls.Add(btedit);
            Controls.Add(btadd);
            Controls.Add(gv_list);
            Controls.Add(tbage);
            Controls.Add(label3);
            Controls.Add(tbprenom);
            Controls.Add(v);
            Controls.Add(tbnom);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion des Contacts";
            ((System.ComponentModel.ISupportInitialize)gv_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label v;
        private TextBox tbnom;
        private TextBox tbprenom;
        private Label label3;
        private TextBox tbage;
        private DataGridView gv_list;
        private Button btadd;
        private Button btedit;
        private Button btdelete;
        private TextBox tbid;
    }
}
