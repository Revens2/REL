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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            labelTitle = new Label();
            panelLogin = new Panel();
            pictureBox1 = new PictureBox();
            imgaccount = new PictureBox();
            lbusername = new Label();
            tbusername = new TextBox();
            btvalidated = new Button();
            lbmdp = new Label();
            tbmdp = new TextBox();
            btinscri = new Button();
            panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgaccount).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(304, 171);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(354, 35);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Veuillez vous connecter";
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(50, 50, 50);
            panelLogin.Controls.Add(pictureBox1);
            panelLogin.Controls.Add(imgaccount);
            panelLogin.Controls.Add(lbusername);
            panelLogin.Controls.Add(tbusername);
            panelLogin.Controls.Add(btvalidated);
            panelLogin.Controls.Add(lbmdp);
            panelLogin.Controls.Add(tbmdp);
            panelLogin.Controls.Add(btinscri);
            panelLogin.Location = new Point(283, 261);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(347, 227);
            panelLogin.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 129);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 28);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // imgaccount
            // 
            imgaccount.BackColor = Color.White;
            imgaccount.Image = (Image)resources.GetObject("imgaccount.Image");
            imgaccount.Location = new Point(43, 53);
            imgaccount.Margin = new Padding(3, 4, 3, 4);
            imgaccount.Name = "imgaccount";
            imgaccount.Size = new Size(33, 26);
            imgaccount.TabIndex = 6;
            imgaccount.TabStop = false;
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Font = new Font("Arial", 12F);
            lbusername.ForeColor = Color.White;
            lbusername.Location = new Point(41, 24);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(154, 23);
            lbusername.TabIndex = 0;
            lbusername.Text = "Nom d'utilisateur";
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.FixedSingle;
            tbusername.Font = new Font("Arial", 12F);
            tbusername.Location = new Point(41, 51);
            tbusername.MinimumSize = new Size(114, 30);
            tbusername.Name = "tbusername";
            tbusername.PlaceholderText = "Username";
            tbusername.Size = new Size(280, 30);
            tbusername.TabIndex = 1;
            tbusername.TextAlign = HorizontalAlignment.Center;
            // 
            // btvalidated
            // 
            btvalidated.BackColor = Color.FromArgb(70, 130, 180);
            btvalidated.Cursor = Cursors.Hand;
            btvalidated.FlatAppearance.BorderSize = 0;
            btvalidated.FlatStyle = FlatStyle.Flat;
            btvalidated.Font = new Font("Arial", 12F, FontStyle.Bold);
            btvalidated.ForeColor = Color.White;
            btvalidated.Location = new Point(190, 188);
            btvalidated.Name = "btvalidated";
            btvalidated.Size = new Size(120, 35);
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
            lbmdp.Location = new Point(41, 93);
            lbmdp.Name = "lbmdp";
            lbmdp.Size = new Size(131, 23);
            lbmdp.TabIndex = 2;
            lbmdp.Text = "Mot de passe";
            // 
            // tbmdp
            // 
            tbmdp.BorderStyle = BorderStyle.FixedSingle;
            tbmdp.Font = new Font("Arial", 12F);
            tbmdp.Location = new Point(41, 128);
            tbmdp.Multiline = true;
            tbmdp.Name = "tbmdp";
            tbmdp.PasswordChar = '*';
            tbmdp.PlaceholderText = "Passeword";
            tbmdp.Size = new Size(280, 32);
            tbmdp.TabIndex = 3;
            tbmdp.TextAlign = HorizontalAlignment.Center;
            // 
            // btinscri
            // 
            btinscri.BackColor = Color.FromArgb(60, 179, 113);
            btinscri.Cursor = Cursors.Hand;
            btinscri.FlatAppearance.BorderSize = 0;
            btinscri.FlatStyle = FlatStyle.Flat;
            btinscri.Font = new Font("Arial", 12F, FontStyle.Bold);
            btinscri.ForeColor = Color.White;
            btinscri.Location = new Point(42, 188);
            btinscri.Name = "btinscri";
            btinscri.Size = new Size(120, 35);
            btinscri.TabIndex = 5;
            btinscri.Text = "Inscription";
            btinscri.UseVisualStyleBackColor = false;
            btinscri.Click += btisncri_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(966, 588);
            Controls.Add(labelTitle);
            Controls.Add(panelLogin);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
    }
}
