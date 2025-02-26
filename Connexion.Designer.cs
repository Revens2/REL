namespace REL
{
    partial class Connexion
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

        private Panel panelLogin;
        private Label labelTitle;

        private void InitializeComponent()
        {
            labelTitle = new Label();
            panelLogin = new Panel();
            imgaccount = new PictureBox();
            lbusername = new Label();
            tbusername = new TextBox();
            btvalidated = new Button();
            lbmdp = new Label();
            tbmdp = new TextBox();
            btinscri = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgaccount).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(266, 128);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(286, 29);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Veuillez vous connecter";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(50, 50, 50);
            panelLogin.Controls.Add(imgaccount);
            panelLogin.Controls.Add(lbusername);
            panelLogin.Controls.Add(tbusername);
            panelLogin.Controls.Add(btvalidated);
            panelLogin.Controls.Add(lbmdp);
            panelLogin.Controls.Add(tbmdp);
            panelLogin.Controls.Add(btinscri);
            panelLogin.Location = new Point(248, 196);
            panelLogin.Margin = new Padding(3, 2, 3, 2);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(306, 150);
            panelLogin.TabIndex = 1;
            // 
            // imgaccount
            // 
            imgaccount.Location = new Point(3, 35);
            imgaccount.Name = "imgaccount";
            imgaccount.Size = new Size(43, 29);
            imgaccount.TabIndex = 6;
            imgaccount.TabStop = false;
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Font = new Font("Arial", 12F);
            lbusername.ForeColor = Color.White;
            lbusername.Location = new Point(36, 18);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(123, 18);
            lbusername.TabIndex = 0;
            lbusername.Text = "Nom d'utilisateur";
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.FixedSingle;
            tbusername.Font = new Font("Arial", 12F);
            tbusername.Location = new Point(36, 38);
            tbusername.Margin = new Padding(3, 2, 3, 2);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(245, 26);
            tbusername.TabIndex = 1;
            // 
            // btvalidated
            // 
            btvalidated.BackColor = Color.FromArgb(70, 130, 180);
            btvalidated.Cursor = Cursors.Hand;
            btvalidated.FlatAppearance.BorderSize = 0;
            btvalidated.FlatStyle = FlatStyle.Flat;
            btvalidated.Font = new Font("Arial", 12F, FontStyle.Bold);
            btvalidated.ForeColor = Color.White;
            btvalidated.Location = new Point(165, 120);
            btvalidated.Margin = new Padding(3, 2, 3, 2);
            btvalidated.Name = "btvalidated";
            btvalidated.Size = new Size(105, 26);
            btvalidated.TabIndex = 4;
            btvalidated.Text = "Valider";
            btvalidated.UseVisualStyleBackColor = false;
            btvalidated.Click += btnValidation_Click;
            // 
            // lbmdp
            // 
            lbmdp.AutoSize = true;
            lbmdp.Font = new Font("Arial", 12F);
            lbmdp.ForeColor = Color.White;
            lbmdp.Location = new Point(36, 66);
            lbmdp.Name = "lbmdp";
            lbmdp.Size = new Size(103, 18);
            lbmdp.TabIndex = 2;
            lbmdp.Text = "Mot de passe";
            // 
            // tbmdp
            // 
            tbmdp.BorderStyle = BorderStyle.FixedSingle;
            tbmdp.Font = new Font("Arial", 12F);
            tbmdp.Location = new Point(36, 90);
            tbmdp.Margin = new Padding(3, 2, 3, 2);
            tbmdp.Name = "tbmdp";
            tbmdp.PasswordChar = '*';
            tbmdp.Size = new Size(245, 26);
            tbmdp.TabIndex = 3;
            // 
            // btinscri
            // 
            btinscri.BackColor = Color.FromArgb(60, 179, 113);
            btinscri.Cursor = Cursors.Hand;
            btinscri.FlatAppearance.BorderSize = 0;
            btinscri.FlatStyle = FlatStyle.Flat;
            btinscri.Font = new Font("Arial", 12F, FontStyle.Bold);
            btinscri.ForeColor = Color.White;
            btinscri.Location = new Point(54, 120);
            btinscri.Margin = new Padding(3, 2, 3, 2);
            btinscri.Name = "btinscri";
            btinscri.Size = new Size(105, 26);
            btinscri.TabIndex = 5;
            btinscri.Text = "Inscription";
            btinscri.UseVisualStyleBackColor = false;
            btinscri.Click += btisncri_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(845, 441);
            Controls.Add(labelTitle);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page de Connexion";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgaccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btvalidated;
        private Label lbusername;
        private TextBox tbusername;
        private Label lbmdp;
        private TextBox tbmdp;
        private Button btinscri;
        private PictureBox imgaccount;
    }
}
