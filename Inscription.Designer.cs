namespace REL
{
    partial class Inscription

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
            tbville = new TextBox();
            tbnumero = new TextBox();
            labdate = new Label();
            tbdate = new DateTimePicker();
            tbzip = new MaskedTextBox();
            btreturn = new Button();
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbtitle.ForeColor = Color.White;
            lbtitle.Location = new Point(258, 6);
            lbtitle.Margin = new Padding(2, 0, 2, 0);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(360, 46);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Page d'inscription";
            lbtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbprenom
            // 
            lbprenom.AutoSize = true;
            lbprenom.Font = new Font("Arial", 18F);
            lbprenom.ForeColor = Color.White;
            lbprenom.Location = new Point(51, 134);
            lbprenom.Margin = new Padding(2, 0, 2, 0);
            lbprenom.Name = "lbprenom";
            lbprenom.Size = new Size(120, 35);
            lbprenom.TabIndex = 3;
            lbprenom.Text = "Prénom";
            // 
            // tbname
            // 
            tbname.BackColor = Color.White;
            tbname.BorderStyle = BorderStyle.FixedSingle;
            tbname.Font = new Font("Arial", 14F);
            tbname.ForeColor = Color.Black;
            tbname.Location = new Point(51, 90);
            tbname.Margin = new Padding(2);
            tbname.Name = "tbname";
            tbname.Size = new Size(247, 34);
            tbname.TabIndex = 2;
            // 
            // tbprenom
            // 
            tbprenom.BackColor = Color.White;
            tbprenom.BorderStyle = BorderStyle.FixedSingle;
            tbprenom.Font = new Font("Arial", 14F);
            tbprenom.ForeColor = Color.Black;
            tbprenom.Location = new Point(51, 181);
            tbprenom.Margin = new Padding(2);
            tbprenom.Name = "tbprenom";
            tbprenom.Size = new Size(247, 34);
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
            btinscri.Location = new Point(563, 503);
            btinscri.Margin = new Padding(2);
            btinscri.Name = "btinscri";
            btinscri.Size = new Size(247, 57);
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
            lbmail.Location = new Point(51, 230);
            lbmail.Margin = new Padding(2, 0, 2, 0);
            lbmail.Name = "lbmail";
            lbmail.Size = new Size(70, 35);
            lbmail.TabIndex = 6;
            lbmail.Text = "Mail";
            // 
            // tbmail
            // 
            tbmail.BackColor = Color.White;
            tbmail.BorderStyle = BorderStyle.FixedSingle;
            tbmail.Font = new Font("Arial", 14F);
            tbmail.ForeColor = Color.Black;
            tbmail.Location = new Point(51, 294);
            tbmail.Margin = new Padding(2);
            tbmail.Name = "tbmail";
            tbmail.Size = new Size(247, 34);
            tbmail.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(51, 364);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(192, 35);
            label2.TabIndex = 8;
            label2.Text = "Mot de passe";
            // 
            // tbpass
            // 
            tbpass.BackColor = Color.White;
            tbpass.BorderStyle = BorderStyle.FixedSingle;
            tbpass.Font = new Font("Arial", 14F);
            tbpass.ForeColor = Color.Black;
            tbpass.Location = new Point(51, 424);
            tbpass.Margin = new Padding(2);
            tbpass.Name = "tbpass";
            tbpass.PasswordChar = '*';
            tbpass.Size = new Size(247, 34);
            tbpass.TabIndex = 9;
            tbpass.UseSystemPasswordChar = true;
            // 
            // lnname
            // 
            lnname.AutoSize = true;
            lnname.Font = new Font("Arial", 18F);
            lnname.ForeColor = Color.White;
            lnname.Location = new Point(51, 46);
            lnname.Margin = new Padding(2, 0, 2, 0);
            lnname.Name = "lnname";
            lnname.Size = new Size(78, 35);
            lnname.TabIndex = 1;
            lnname.Text = "Nom";
            lnname.Click += lbnewuser_Click;
            // 
            // lbadresse
            // 
            lbadresse.AutoSize = true;
            lbadresse.Font = new Font("Arial", 18F);
            lbadresse.ForeColor = Color.White;
            lbadresse.Location = new Point(563, 46);
            lbadresse.Margin = new Padding(2, 0, 2, 0);
            lbadresse.Name = "lbadresse";
            lbadresse.Size = new Size(123, 35);
            lbadresse.TabIndex = 10;
            lbadresse.Text = "Adresse";
            // 
            // lbZip
            // 
            lbZip.AutoSize = true;
            lbZip.Font = new Font("Arial", 18F);
            lbZip.ForeColor = Color.White;
            lbZip.Location = new Point(563, 134);
            lbZip.Margin = new Padding(2, 0, 2, 0);
            lbZip.Name = "lbZip";
            lbZip.Size = new Size(189, 35);
            lbZip.TabIndex = 11;
            lbZip.Text = "Code postale";
            // 
            // lbville
            // 
            lbville.AutoSize = true;
            lbville.Font = new Font("Arial", 18F);
            lbville.ForeColor = Color.White;
            lbville.Location = new Point(563, 230);
            lbville.Margin = new Padding(2, 0, 2, 0);
            lbville.Name = "lbville";
            lbville.Size = new Size(70, 35);
            lbville.TabIndex = 12;
            lbville.Text = "Ville";
            // 
            // lbnumber
            // 
            lbnumber.AutoSize = true;
            lbnumber.Font = new Font("Arial", 18F);
            lbnumber.ForeColor = Color.White;
            lbnumber.Location = new Point(563, 364);
            lbnumber.Margin = new Padding(2, 0, 2, 0);
            lbnumber.Name = "lbnumber";
            lbnumber.Size = new Size(122, 35);
            lbnumber.TabIndex = 13;
            lbnumber.Text = "Numéro";
            // 
            // tbadresse
            // 
            tbadresse.BackColor = Color.White;
            tbadresse.BorderStyle = BorderStyle.FixedSingle;
            tbadresse.Font = new Font("Arial", 14F);
            tbadresse.ForeColor = Color.Black;
            tbadresse.Location = new Point(563, 90);
            tbadresse.Margin = new Padding(2);
            tbadresse.Name = "tbadresse";
            tbadresse.Size = new Size(247, 34);
            tbadresse.TabIndex = 14;
            // 
            // tbville
            // 
            tbville.BackColor = Color.White;
            tbville.BorderStyle = BorderStyle.FixedSingle;
            tbville.Font = new Font("Arial", 14F);
            tbville.ForeColor = Color.Black;
            tbville.Location = new Point(563, 294);
            tbville.Margin = new Padding(2);
            tbville.Name = "tbville";
            tbville.Size = new Size(247, 34);
            tbville.TabIndex = 16;
            // 
            // tbnumero
            // 
            tbnumero.BackColor = Color.White;
            tbnumero.BorderStyle = BorderStyle.FixedSingle;
            tbnumero.Font = new Font("Arial", 14F);
            tbnumero.ForeColor = Color.Black;
            tbnumero.Location = new Point(563, 424);
            tbnumero.Margin = new Padding(2);
            tbnumero.MaxLength = 10;
            tbnumero.Name = "tbnumero";
            tbnumero.Size = new Size(247, 34);
            tbnumero.TabIndex = 17;
            // 
            // labdate
            // 
            labdate.AutoSize = true;
            labdate.Font = new Font("Arial", 18F);
            labdate.ForeColor = Color.White;
            labdate.Location = new Point(51, 471);
            labdate.Margin = new Padding(2, 0, 2, 0);
            labdate.Name = "labdate";
            labdate.Size = new Size(265, 35);
            labdate.TabIndex = 18;
            labdate.Text = "Date de Naissance";
            // 
            // tbdate
            // 
            tbdate.Format = DateTimePickerFormat.Short;
            tbdate.Location = new Point(51, 533);
            tbdate.Name = "tbdate";
            tbdate.Size = new Size(250, 27);
            tbdate.TabIndex = 22;
            tbdate.Value = new DateTime(2025, 1, 27, 0, 0, 0, 0);
            // 
            // tbzip
            // 
            tbzip.Location = new Point(563, 185);
            tbzip.Mask = "00000";
            tbzip.Name = "tbzip";
            tbzip.Size = new Size(247, 27);
            tbzip.TabIndex = 23;
            // 
            // btreturn
            // 
            btreturn.BackColor = Color.Silver;
            btreturn.Cursor = Cursors.Hand;
            btreturn.FlatAppearance.BorderSize = 0;
            btreturn.FlatStyle = FlatStyle.Flat;
            btreturn.Font = new Font("Arial", 14F, FontStyle.Bold);
            btreturn.ForeColor = Color.White;
            btreturn.Location = new Point(47, 617);
            btreturn.Margin = new Padding(2);
            btreturn.Name = "btreturn";
            btreturn.Size = new Size(124, 31);
            btreturn.TabIndex = 24;
            btreturn.Text = "Retour";
            btreturn.UseVisualStyleBackColor = false;
            btreturn.Click += btreturn_Click_1;
            // 
            // Inscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(868, 659);
            Controls.Add(btreturn);
            Controls.Add(tbzip);
            Controls.Add(tbdate);
            Controls.Add(labdate);
            Controls.Add(tbnumero);
            Controls.Add(tbville);
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
            Margin = new Padding(2);
            Name = "Inscription";
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
        private TextBox tbville;
        private TextBox tbnumero;
        private Label labdate;
        private DateTimePicker tbdate;
        private MaskedTextBox tbzip;
        private Button btreturn;
    }
}
