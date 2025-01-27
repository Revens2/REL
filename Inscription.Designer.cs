namespace REL
{
    partial class tbuser
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
            lbtitle = new Label();
            lbprenom = new Label();
            tbname = new TextBox();
            tbprenom = new TextBox();
            btinscri = new Button();
            lbmail = new Label();
            tbmail = new TextBox();
            label2 = new Label();
            tbpass = new TextBox();
            lnname = new Label();
            lbadresse = new Label();
            lbZip = new Label();
            lbville = new Label();
            lbnumber = new Label();
            tbadresse = new TextBox();
            tbzip = new TextBox();
            tbville = new TextBox();
            tbnumero = new TextBox();
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbtitle.ForeColor = Color.White;
            lbtitle.Location = new Point(420, 9);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(586, 75);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Page d'inscription";
            lbtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbprenom
            // 
            lbprenom.AutoSize = true;
            lbprenom.Font = new Font("Arial", 18F);
            lbprenom.ForeColor = Color.White;
            lbprenom.Location = new Point(98, 243);
            lbprenom.Name = "lbprenom";
            lbprenom.Size = new Size(193, 55);
            lbprenom.TabIndex = 3;
            lbprenom.Text = "Prénom";
            // 
            // tbname
            // 
            tbname.BackColor = Color.White;
            tbname.BorderStyle = BorderStyle.FixedSingle;
            tbname.Font = new Font("Arial", 14F);
            tbname.ForeColor = Color.Black;
            tbname.Location = new Point(84, 172);
            tbname.Name = "tbname";
            tbname.Size = new Size(400, 50);
            tbname.TabIndex = 2;
            // 
            // tbprenom
            // 
            tbprenom.BackColor = Color.White;
            tbprenom.BorderStyle = BorderStyle.FixedSingle;
            tbprenom.Font = new Font("Arial", 14F);
            tbprenom.ForeColor = Color.Black;
            tbprenom.Location = new Point(84, 318);
            tbprenom.Name = "tbprenom";
            tbprenom.Size = new Size(400, 50);
            tbprenom.TabIndex = 4;
            // 
            // btinscri
            // 
            btinscri.BackColor = Color.FromArgb(60, 179, 113);
            btinscri.Cursor = Cursors.Hand;
            btinscri.FlatAppearance.BorderSize = 0;
            btinscri.FlatStyle = FlatStyle.Flat;
            btinscri.Font = new Font("Arial", 16F);
            btinscri.ForeColor = Color.White;
            btinscri.Location = new Point(562, 876);
            btinscri.Name = "btinscri";
            btinscri.Size = new Size(250, 60);
            btinscri.TabIndex = 5;
            btinscri.Text = "S'inscrire";
            btinscri.UseVisualStyleBackColor = false;
            btinscri.Click += btinscri_Click;
            // 
            // lbmail
            // 
            lbmail.AutoSize = true;
            lbmail.Font = new Font("Arial", 18F);
            lbmail.ForeColor = Color.White;
            lbmail.Location = new Point(84, 396);
            lbmail.Name = "lbmail";
            lbmail.Size = new Size(110, 55);
            lbmail.TabIndex = 6;
            lbmail.Text = "Mail";
            // 
            // tbmail
            // 
            tbmail.BackColor = Color.White;
            tbmail.BorderStyle = BorderStyle.FixedSingle;
            tbmail.Font = new Font("Arial", 14F);
            tbmail.ForeColor = Color.Black;
            tbmail.Location = new Point(84, 500);
            tbmail.Name = "tbmail";
            tbmail.Size = new Size(400, 50);
            tbmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(98, 611);
            label2.Name = "label2";
            label2.Size = new Size(312, 55);
            label2.TabIndex = 8;
            label2.Text = "Mot de passe";
            // 
            // tbpass
            // 
            tbpass.BackColor = Color.White;
            tbpass.BorderStyle = BorderStyle.FixedSingle;
            tbpass.Font = new Font("Arial", 14F);
            tbpass.ForeColor = Color.Black;
            tbpass.Location = new Point(84, 708);
            tbpass.Name = "tbpass";
            tbpass.PasswordChar = '*';
            tbpass.Size = new Size(400, 50);
            tbpass.TabIndex = 9;
            tbpass.UseSystemPasswordChar = true;
            // 
            // lnname
            // 
            lnname.AutoSize = true;
            lnname.Font = new Font("Arial", 18F);
            lnname.ForeColor = Color.White;
            lnname.Location = new Point(84, 102);
            lnname.Name = "lnname";
            lnname.Size = new Size(126, 55);
            lnname.TabIndex = 1;
            lnname.Text = "Nom";
            lnname.Click += lbnewuser_Click;
            // 
            // lbadresse
            // 
            lbadresse.AutoSize = true;
            lbadresse.Font = new Font("Arial", 18F);
            lbadresse.ForeColor = Color.White;
            lbadresse.Location = new Point(916, 102);
            lbadresse.Name = "lbadresse";
            lbadresse.Size = new Size(201, 55);
            lbadresse.TabIndex = 10;
            lbadresse.Text = "Adresse";
            // 
            // lbZip
            // 
            lbZip.AutoSize = true;
            lbZip.Font = new Font("Arial", 18F);
            lbZip.ForeColor = Color.White;
            lbZip.Location = new Point(916, 243);
            lbZip.Name = "lbZip";
            lbZip.Size = new Size(308, 55);
            lbZip.TabIndex = 11;
            lbZip.Text = "Code postale";
            // 
            // lbville
            // 
            lbville.AutoSize = true;
            lbville.Font = new Font("Arial", 18F);
            lbville.ForeColor = Color.White;
            lbville.Location = new Point(916, 396);
            lbville.Name = "lbville";
            lbville.Size = new Size(112, 55);
            lbville.TabIndex = 12;
            lbville.Text = "Ville";
            // 
            // lbnumber
            // 
            lbnumber.AutoSize = true;
            lbnumber.Font = new Font("Arial", 18F);
            lbnumber.ForeColor = Color.White;
            lbnumber.Location = new Point(916, 611);
            lbnumber.Name = "lbnumber";
            lbnumber.Size = new Size(196, 55);
            lbnumber.TabIndex = 13;
            lbnumber.Text = "Numéro";
            // 
            // tbadresse
            // 
            tbadresse.BackColor = Color.White;
            tbadresse.BorderStyle = BorderStyle.FixedSingle;
            tbadresse.Font = new Font("Arial", 14F);
            tbadresse.ForeColor = Color.Black;
            tbadresse.Location = new Point(916, 172);
            tbadresse.Name = "tbadresse";
            tbadresse.Size = new Size(400, 50);
            tbadresse.TabIndex = 14;
            // 
            // tbzip
            // 
            tbzip.BackColor = Color.White;
            tbzip.BorderStyle = BorderStyle.FixedSingle;
            tbzip.Font = new Font("Arial", 14F);
            tbzip.ForeColor = Color.Black;
            tbzip.Location = new Point(916, 318);
            tbzip.Name = "tbzip";
            tbzip.Size = new Size(400, 50);
            tbzip.TabIndex = 15;
            // 
            // tbville
            // 
            tbville.BackColor = Color.White;
            tbville.BorderStyle = BorderStyle.FixedSingle;
            tbville.Font = new Font("Arial", 14F);
            tbville.ForeColor = Color.Black;
            tbville.Location = new Point(916, 500);
            tbville.Name = "tbville";
            tbville.Size = new Size(400, 50);
            tbville.TabIndex = 16;
            // 
            // tbnumero
            // 
            tbnumero.BackColor = Color.White;
            tbnumero.BorderStyle = BorderStyle.FixedSingle;
            tbnumero.Font = new Font("Arial", 14F);
            tbnumero.ForeColor = Color.Black;
            tbnumero.Location = new Point(916, 708);
            tbnumero.Name = "tbnumero";
            tbnumero.Size = new Size(400, 50);
            tbnumero.TabIndex = 17;
            // 
            // tbuser
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1410, 1054);
            Controls.Add(tbnumero);
            Controls.Add(tbville);
            Controls.Add(tbzip);
            Controls.Add(tbadresse);
            Controls.Add(lbnumber);
            Controls.Add(lbville);
            Controls.Add(lbZip);
            Controls.Add(lbadresse);
            Controls.Add(tbpass);
            Controls.Add(label2);
            Controls.Add(tbmail);
            Controls.Add(lbmail);
            Controls.Add(lbtitle);
            Controls.Add(btinscri);
            Controls.Add(tbprenom);
            Controls.Add(lbprenom);
            Controls.Add(tbname);
            Controls.Add(lnname);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "tbuser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Page d'inscription";
            Load += Inscription_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitle;
        private Label lbprenom;
        private TextBox tbname;
        private TextBox tbprenom;
        private Button btinscri;
        private Label lbmail;
        private TextBox tbmail;
        private Label label2;
        private TextBox tbpass;
        private Label lnname;
        private Label lbadresse;
        private Label lbZip;
        private Label lbville;
        private Label lbnumber;
        private TextBox tbadresse;
        private TextBox tbzip;
        private TextBox tbville;
        private TextBox tbnumero;
    }
}
