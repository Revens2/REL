﻿namespace REL
{
    partial class Account

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
            btmaj = new Button();
            lbmail = new Label();
            tbmail = new TextBox();
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
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lbtitle.ForeColor = Color.White;
            lbtitle.Location = new Point(348, 80);
            lbtitle.Margin = new Padding(2, 0, 2, 0);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(275, 37);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Vos Informations";
            lbtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbprenom
            // 
            lbprenom.AutoSize = true;
            lbprenom.Font = new Font("Arial", 18F);
            lbprenom.ForeColor = Color.White;
            lbprenom.Location = new Point(167, 176);
            lbprenom.Margin = new Padding(2, 0, 2, 0);
            lbprenom.Name = "lbprenom";
            lbprenom.Size = new Size(96, 27);
            lbprenom.TabIndex = 3;
            lbprenom.Text = "Prénom";
            // 
            // tbname
            // 
            tbname.BackColor = Color.White;
            tbname.BorderStyle = BorderStyle.FixedSingle;
            tbname.Font = new Font("Arial", 14F);
            tbname.ForeColor = Color.Black;
            tbname.Location = new Point(167, 143);
            tbname.Margin = new Padding(2);
            tbname.Name = "tbname";
            tbname.Size = new Size(216, 29);
            tbname.TabIndex = 2;
            // 
            // tbprenom
            // 
            tbprenom.BackColor = Color.White;
            tbprenom.BorderStyle = BorderStyle.FixedSingle;
            tbprenom.Font = new Font("Arial", 14F);
            tbprenom.ForeColor = Color.Black;
            tbprenom.Location = new Point(167, 211);
            tbprenom.Margin = new Padding(2);
            tbprenom.Name = "tbprenom";
            tbprenom.Size = new Size(216, 29);
            tbprenom.TabIndex = 4;
            // 
            // btmaj
            // 
            btmaj.BackColor = Color.FromArgb(60, 179, 113);
            btmaj.Cursor = Cursors.Hand;
            btmaj.FlatAppearance.BorderSize = 0;
            btmaj.FlatStyle = FlatStyle.Flat;
            btmaj.Font = new Font("Arial", 16F);
            btmaj.ForeColor = Color.White;
            btmaj.Location = new Point(386, 466);
            btmaj.Margin = new Padding(2);
            btmaj.Name = "btmaj";
            btmaj.Size = new Size(216, 43);
            btmaj.TabIndex = 5;
            btmaj.Text = "Mettre à jour ";
            btmaj.UseVisualStyleBackColor = false;
            btmaj.Click += btmaj_Click;
            // 
            // lbmail
            // 
            lbmail.AutoSize = true;
            lbmail.Font = new Font("Arial", 18F);
            lbmail.ForeColor = Color.White;
            lbmail.Location = new Point(167, 248);
            lbmail.Margin = new Padding(2, 0, 2, 0);
            lbmail.Name = "lbmail";
            lbmail.Size = new Size(55, 27);
            lbmail.TabIndex = 6;
            lbmail.Text = "Mail";
            // 
            // tbmail
            // 
            tbmail.BackColor = Color.White;
            tbmail.BorderStyle = BorderStyle.FixedSingle;
            tbmail.Font = new Font("Arial", 14F);
            tbmail.ForeColor = Color.Black;
            tbmail.Location = new Point(167, 296);
            tbmail.Margin = new Padding(2);
            tbmail.Name = "tbmail";
            tbmail.Size = new Size(216, 29);
            tbmail.TabIndex = 7;
            // 
            // lnname
            // 
            lnname.AutoSize = true;
            lnname.Font = new Font("Arial", 18F);
            lnname.ForeColor = Color.White;
            lnname.Location = new Point(167, 110);
            lnname.Margin = new Padding(2, 0, 2, 0);
            lnname.Name = "lnname";
            lnname.Size = new Size(62, 27);
            lnname.TabIndex = 1;
            lnname.Text = "Nom";
            // 
            // lbadresse
            // 
            lbadresse.AutoSize = true;
            lbadresse.Font = new Font("Arial", 18F);
            lbadresse.ForeColor = Color.White;
            lbadresse.Location = new Point(615, 110);
            lbadresse.Margin = new Padding(2, 0, 2, 0);
            lbadresse.Name = "lbadresse";
            lbadresse.Size = new Size(99, 27);
            lbadresse.TabIndex = 10;
            lbadresse.Text = "Adresse";
            // 
            // lbZip
            // 
            lbZip.AutoSize = true;
            lbZip.Font = new Font("Arial", 18F);
            lbZip.ForeColor = Color.White;
            lbZip.Location = new Point(615, 176);
            lbZip.Margin = new Padding(2, 0, 2, 0);
            lbZip.Name = "lbZip";
            lbZip.Size = new Size(154, 27);
            lbZip.TabIndex = 11;
            lbZip.Text = "Code postale";
            // 
            // lbville
            // 
            lbville.AutoSize = true;
            lbville.Font = new Font("Arial", 18F);
            lbville.ForeColor = Color.White;
            lbville.Location = new Point(615, 248);
            lbville.Margin = new Padding(2, 0, 2, 0);
            lbville.Name = "lbville";
            lbville.Size = new Size(57, 27);
            lbville.TabIndex = 12;
            lbville.Text = "Ville";
            // 
            // lbnumber
            // 
            lbnumber.AutoSize = true;
            lbnumber.Font = new Font("Arial", 18F);
            lbnumber.ForeColor = Color.White;
            lbnumber.Location = new Point(615, 349);
            lbnumber.Margin = new Padding(2, 0, 2, 0);
            lbnumber.Name = "lbnumber";
            lbnumber.Size = new Size(97, 27);
            lbnumber.TabIndex = 13;
            lbnumber.Text = "Numéro";
            // 
            // tbadresse
            // 
            tbadresse.BackColor = Color.White;
            tbadresse.BorderStyle = BorderStyle.FixedSingle;
            tbadresse.Font = new Font("Arial", 14F);
            tbadresse.ForeColor = Color.Black;
            tbadresse.Location = new Point(615, 143);
            tbadresse.Margin = new Padding(2);
            tbadresse.Name = "tbadresse";
            tbadresse.Size = new Size(216, 29);
            tbadresse.TabIndex = 14;
            // 
            // tbville
            // 
            tbville.BackColor = Color.White;
            tbville.BorderStyle = BorderStyle.FixedSingle;
            tbville.Font = new Font("Arial", 14F);
            tbville.ForeColor = Color.Black;
            tbville.Location = new Point(615, 296);
            tbville.Margin = new Padding(2);
            tbville.Name = "tbville";
            tbville.Size = new Size(216, 29);
            tbville.TabIndex = 16;
            // 
            // tbnumero
            // 
            tbnumero.BackColor = Color.White;
            tbnumero.BorderStyle = BorderStyle.FixedSingle;
            tbnumero.Font = new Font("Arial", 14F);
            tbnumero.ForeColor = Color.Black;
            tbnumero.Location = new Point(615, 393);
            tbnumero.Margin = new Padding(2);
            tbnumero.MaxLength = 10;
            tbnumero.Name = "tbnumero";
            tbnumero.Size = new Size(216, 29);
            tbnumero.TabIndex = 17;
            // 
            // labdate
            // 
            labdate.AutoSize = true;
            labdate.Font = new Font("Arial", 18F);
            labdate.ForeColor = Color.White;
            labdate.Location = new Point(163, 356);
            labdate.Margin = new Padding(2, 0, 2, 0);
            labdate.Name = "labdate";
            labdate.Size = new Size(214, 27);
            labdate.TabIndex = 18;
            labdate.Text = "Date de Naissance";
            // 
            // tbdate
            // 
            tbdate.Format = DateTimePickerFormat.Short;
            tbdate.Location = new Point(163, 403);
            tbdate.Margin = new Padding(3, 2, 3, 2);
            tbdate.Name = "tbdate";
            tbdate.Size = new Size(219, 23);
            tbdate.TabIndex = 22;
            tbdate.Value = new DateTime(2025, 1, 27, 0, 0, 0, 0);
            // 
            // tbzip
            // 
            tbzip.Location = new Point(615, 214);
            tbzip.Margin = new Padding(3, 2, 3, 2);
            tbzip.Mask = "00000";
            tbzip.Name = "tbzip";
            tbzip.Size = new Size(217, 23);
            tbzip.TabIndex = 23;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1005, 580);
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
            Controls.Add(tbmail);
            Controls.Add(lbmail);
            Controls.Add(lbtitle);
            Controls.Add(btmaj);
            Controls.Add(tbprenom);
            Controls.Add(lbprenom);
            Controls.Add(tbname);
            Controls.Add(lnname);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            Name = "Account";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Compte utilisateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitle;
        private Label lbprenom;
        private TextBox tbname;
        private TextBox tbprenom;
        private Button btmaj;
        private Label lbmail;
        private TextBox tbmail;
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
    }
}
