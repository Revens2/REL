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

        private void InitializeComponent()
        {
            btvalidated = new Button();
            lbusername = new Label();
            tbusername = new TextBox();
            lbmdp = new Label();
            tbmdp = new TextBox();
            btinscri = new Button();
            SuspendLayout();
            // 
            // btvalidated
            // 
            btvalidated.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btvalidated.Location = new Point(350, 450);
            btvalidated.Name = "btvalidated";
            btvalidated.Size = new Size(200, 60);
            btvalidated.TabIndex = 0;
            btvalidated.Text = "Valider";
            btvalidated.UseVisualStyleBackColor = true;
            btvalidated.BackColor = Color.FromArgb(70, 130, 180); // SteelBlue color
            btvalidated.ForeColor = Color.White;
            btvalidated.FlatStyle = FlatStyle.Flat;
            btvalidated.FlatAppearance.BorderSize = 0;
            btvalidated.Click += btnValidation_Click;
            btvalidated.Cursor = Cursors.Hand;
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbusername.ForeColor = Color.White;
            lbusername.Location = new Point(350, 100);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(250, 48);
            lbusername.TabIndex = 1;
            lbusername.Text = "Nom d'utilisateur";
            // 
            // tbusername
            // 
            tbusername.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbusername.Location = new Point(350, 160);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(400, 45);
            tbusername.TabIndex = 2;
            tbusername.TextChanged += tbusername_TextChanged;
            tbusername.BorderStyle = BorderStyle.FixedSingle;
            tbusername.BackColor = Color.White;
            tbusername.ForeColor = Color.Black;
            // 
            // lbmdp
            // 
            lbmdp.AutoSize = true;
            lbmdp.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbmdp.ForeColor = Color.White;
            lbmdp.Location = new Point(350, 240);
            lbmdp.Name = "lbmdp";
            lbmdp.Size = new Size(180, 48);
            lbmdp.TabIndex = 3;
            lbmdp.Text = "Mot de passe";
            // 
            // tbmdp
            // 
            tbmdp.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbmdp.Location = new Point(350, 300);
            tbmdp.Name = "tbmdp";
            tbmdp.PasswordChar = '*';
            tbmdp.Size = new Size(400, 45);
            tbmdp.TabIndex = 4;
            tbmdp.BorderStyle = BorderStyle.FixedSingle;
            tbmdp.BackColor = Color.White;
            tbmdp.ForeColor = Color.Black;
            // 
            // btinscri
            // 
            btinscri.Font = new Font("Arial", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btinscri.Location = new Point(570, 450);
            btinscri.Name = "btinscri";
            btinscri.Size = new Size(200, 60);
            btinscri.TabIndex = 5;
            btinscri.Text = "Inscription";
            btinscri.UseVisualStyleBackColor = true;
            btinscri.BackColor = Color.FromArgb(60, 179, 113); // MediumSeaGreen color
            btinscri.ForeColor = Color.White;
            btinscri.FlatStyle = FlatStyle.Flat;
            btinscri.FlatAppearance.BorderSize = 0;
            btinscri.Click += btisncri_Click;
            btinscri.Cursor = Cursors.Hand;
            // 
            // Connexion (Form)
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40); // Slightly lighter, modern background
            ClientSize = new Size(1100, 650);
            Controls.Add(btinscri);
            Controls.Add(tbmdp);
            Controls.Add(lbmdp);
            Controls.Add(tbusername);
            Controls.Add(lbusername);
            Controls.Add(btvalidated);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Connexion";
            Text = "Page de Connexion";
            Load += Form1_Load;
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
    }
}
