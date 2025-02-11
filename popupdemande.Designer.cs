namespace REL
{
    partial class popupdemande
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
            lbojet = new Label();
            tbobjet = new TextBox();
            lbprioritaire = new Label();
            cbprioritaire = new CheckBox();
            lbtype = new Label();
            ddltype = new ComboBox();
            pnlService = new Panel();
            gvserv = new DataGridView();
            label2 = new Label();
            pnlReunion = new Panel();
            gvlistreu = new DataGridView();
            pnlVehicule = new Panel();
            gvvehi = new DataGridView();
            ddlvehicule = new ComboBox();
            label1 = new Label();
            btsave = new Button();
            lbdatedebut = new Label();
            lbdateend = new Label();
            tbdatedebut = new DateTimePicker();
            tbdateend = new DateTimePicker();
            tbcom = new TextBox();
            lbcom = new Label();
            pnlService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvserv).BeginInit();
            pnlReunion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvlistreu).BeginInit();
            pnlVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvvehi).BeginInit();
            SuspendLayout();
            // 
            // lbojet
            // 
            lbojet.AutoSize = true;
            lbojet.Location = new Point(60, 76);
            lbojet.Name = "lbojet";
            lbojet.Size = new Size(205, 15);
            lbojet.TabIndex = 0;
            lbojet.Text = "Quelle est l'objet de votre demande  ?";
            // 
            // tbobjet
            // 
            tbobjet.Location = new Point(60, 106);
            tbobjet.Margin = new Padding(3, 2, 3, 2);
            tbobjet.Name = "tbobjet";
            tbobjet.Size = new Size(230, 23);
            tbobjet.TabIndex = 1;
            // 
            // lbprioritaire
            // 
            lbprioritaire.AutoSize = true;
            lbprioritaire.Location = new Point(60, 150);
            lbprioritaire.Name = "lbprioritaire";
            lbprioritaire.Size = new Size(143, 15);
            lbprioritaire.TabIndex = 2;
            lbprioritaire.Text = "Votre doit être prioritaire ?";
            // 
            // cbprioritaire
            // 
            cbprioritaire.AutoSize = true;
            cbprioritaire.Location = new Point(60, 176);
            cbprioritaire.Margin = new Padding(3, 2, 3, 2);
            cbprioritaire.Name = "cbprioritaire";
            cbprioritaire.Size = new Size(15, 14);
            cbprioritaire.TabIndex = 3;
            cbprioritaire.UseVisualStyleBackColor = true;
            // 
            // lbtype
            // 
            lbtype.AutoSize = true;
            lbtype.Location = new Point(60, 7);
            lbtype.Name = "lbtype";
            lbtype.Size = new Size(176, 15);
            lbtype.TabIndex = 5;
            lbtype.Text = "Votre demande est a quel sujet ?";
            // 
            // ddltype
            // 
            ddltype.FormattingEnabled = true;
            ddltype.Location = new Point(60, 36);
            ddltype.Margin = new Padding(3, 2, 3, 2);
            ddltype.Name = "ddltype";
            ddltype.Size = new Size(230, 23);
            ddltype.TabIndex = 6;
            ddltype.SelectedIndexChanged += ddltype_SelectedIndexChanged;
            // 
            // pnlService
            // 
            pnlService.Controls.Add(gvserv);
            pnlService.Controls.Add(label2);
            pnlService.Location = new Point(358, 1);
            pnlService.Margin = new Padding(3, 2, 3, 2);
            pnlService.Name = "pnlService";
            pnlService.Size = new Size(472, 312);
            pnlService.TabIndex = 7;
            // 
            // gvserv
            // 
            gvserv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvserv.Location = new Point(14, 65);
            gvserv.Margin = new Padding(3, 2, 3, 2);
            gvserv.Name = "gvserv";
            gvserv.RowHeadersWidth = 51;
            gvserv.Size = new Size(444, 182);
            gvserv.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 17);
            label2.Name = "label2";
            label2.Size = new Size(220, 15);
            label2.TabIndex = 7;
            label2.Text = "Vous souhaitez contacter quelle service ?";
            // 
            // pnlReunion
            // 
            pnlReunion.Controls.Add(gvlistreu);
            pnlReunion.Location = new Point(361, -3);
            pnlReunion.Margin = new Padding(3, 2, 3, 2);
            pnlReunion.Name = "pnlReunion";
            pnlReunion.Size = new Size(469, 312);
            pnlReunion.TabIndex = 8;
            // 
            // gvlistreu
            // 
            gvlistreu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvlistreu.Location = new Point(22, 38);
            gvlistreu.Margin = new Padding(3, 2, 3, 2);
            gvlistreu.Name = "gvlistreu";
            gvlistreu.RowHeadersWidth = 51;
            gvlistreu.Size = new Size(444, 182);
            gvlistreu.TabIndex = 0;
            // 
            // pnlVehicule
            // 
            pnlVehicule.Controls.Add(gvvehi);
            pnlVehicule.Controls.Add(ddlvehicule);
            pnlVehicule.Controls.Add(label1);
            pnlVehicule.Location = new Point(361, -1);
            pnlVehicule.Margin = new Padding(3, 2, 3, 2);
            pnlVehicule.Name = "pnlVehicule";
            pnlVehicule.Size = new Size(469, 312);
            pnlVehicule.TabIndex = 9;
            // 
            // gvvehi
            // 
            gvvehi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvvehi.Location = new Point(12, 65);
            gvvehi.Margin = new Padding(3, 2, 3, 2);
            gvvehi.Name = "gvvehi";
            gvvehi.RowHeadersWidth = 51;
            gvvehi.Size = new Size(444, 182);
            gvvehi.TabIndex = 9;
            // 
            // ddlvehicule
            // 
            ddlvehicule.FormattingEnabled = true;
            ddlvehicule.Location = new Point(3, 32);
            ddlvehicule.Margin = new Padding(3, 2, 3, 2);
            ddlvehicule.Name = "ddlvehicule";
            ddlvehicule.Size = new Size(230, 23);
            ddlvehicule.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(230, 15);
            label1.TabIndex = 7;
            label1.Text = "Vous voulez utilisé quelle type de véhicule ";
            // 
            // btsave
            // 
            btsave.BackColor = Color.FromArgb(60, 179, 113);
            btsave.Cursor = Cursors.Hand;
            btsave.FlatAppearance.BorderSize = 0;
            btsave.FlatStyle = FlatStyle.Flat;
            btsave.Font = new Font("Arial", 16F);
            btsave.ForeColor = Color.White;
            btsave.Location = new Point(73, 349);
            btsave.Margin = new Padding(2);
            btsave.Name = "btsave";
            btsave.Size = new Size(216, 43);
            btsave.TabIndex = 9;
            btsave.Text = "Enregistrer";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // lbdatedebut
            // 
            lbdatedebut.AutoSize = true;
            lbdatedebut.Location = new Point(60, 206);
            lbdatedebut.Name = "lbdatedebut";
            lbdatedebut.Size = new Size(155, 15);
            lbdatedebut.TabIndex = 10;
            lbdatedebut.Text = "Votre demande debutera le :";
            // 
            // lbdateend
            // 
            lbdateend.AutoSize = true;
            lbdateend.Location = new Point(60, 274);
            lbdateend.Name = "lbdateend";
            lbdateend.Size = new Size(135, 15);
            lbdateend.TabIndex = 12;
            lbdateend.Text = "Votre demande finira le :";
            // 
            // tbdatedebut
            // 
            tbdatedebut.Format = DateTimePickerFormat.Short;
            tbdatedebut.Location = new Point(60, 239);
            tbdatedebut.Margin = new Padding(3, 2, 3, 2);
            tbdatedebut.Name = "tbdatedebut";
            tbdatedebut.Size = new Size(219, 23);
            tbdatedebut.TabIndex = 23;
            tbdatedebut.Value = new DateTime(2025, 1, 27, 0, 0, 0, 0);
            // 
            // tbdateend
            // 
            tbdateend.Format = DateTimePickerFormat.Short;
            tbdateend.Location = new Point(60, 306);
            tbdateend.Margin = new Padding(3, 2, 3, 2);
            tbdateend.Name = "tbdateend";
            tbdateend.Size = new Size(219, 23);
            tbdateend.TabIndex = 24;
            tbdateend.Value = new DateTime(2025, 1, 27, 0, 0, 0, 0);
            // 
            // tbcom
            // 
            tbcom.Location = new Point(346, 341);
            tbcom.Margin = new Padding(3, 2, 3, 2);
            tbcom.Multiline = true;
            tbcom.Name = "tbcom";
            tbcom.Size = new Size(324, 60);
            tbcom.TabIndex = 26;
            // 
            // lbcom
            // 
            lbcom.AutoSize = true;
            lbcom.Location = new Point(346, 311);
            lbcom.Name = "lbcom";
            lbcom.Size = new Size(295, 15);
            lbcom.TabIndex = 25;
            lbcom.Text = "Avez-vous des informations supplémentaire a fournir ?";
            // 
            // popupdemande
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 414);
            Controls.Add(tbcom);
            Controls.Add(pnlVehicule);
            Controls.Add(lbcom);
            Controls.Add(pnlReunion);
            Controls.Add(pnlService);
            Controls.Add(tbdateend);
            Controls.Add(tbdatedebut);
            Controls.Add(lbdateend);
            Controls.Add(lbdatedebut);
            Controls.Add(btsave);
            Controls.Add(ddltype);
            Controls.Add(lbtype);
            Controls.Add(cbprioritaire);
            Controls.Add(lbprioritaire);
            Controls.Add(tbobjet);
            Controls.Add(lbojet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "popupdemande";
            Text = "popupdemande";
            pnlService.ResumeLayout(false);
            pnlService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvserv).EndInit();
            pnlReunion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gvlistreu).EndInit();
            pnlVehicule.ResumeLayout(false);
            pnlVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvvehi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbojet;
        private TextBox tbobjet;
        private Label lbprioritaire;
        private CheckBox cbprioritaire;
        private Label lbtype;
        private ComboBox ddltype;
        private Panel pnlService;
        private Label label2;
        private Panel pnlReunion;
        private Panel pnlVehicule;
        private Button btsave;
        private ComboBox ddlvehicule;
        private Label label1;
        private Label lbdatedebut;
        private Label lbdateend;
        private DateTimePicker tbdatedebut;
        private DateTimePicker tbdateend;
        private TextBox tbcom;
        private Label lbcom;
        private DataGridView gvlistreu;
        private DataGridView gvvehi;
        private DataGridView gvserv;
    }
}