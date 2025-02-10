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
            dllservice = new ComboBox();
            label2 = new Label();
            pnlReunion = new Panel();
            pnlVehicule = new Panel();
            ddlvehicule = new ComboBox();
            label1 = new Label();
            btsave = new Button();
            lbdatedebut = new Label();
            lbdateend = new Label();
            tbdatedebut = new DateTimePicker();
            tbdateend = new DateTimePicker();
            tbcom = new TextBox();
            lbcom = new Label();
            gvlistvehi = new DataGridView();
            pnlService.SuspendLayout();
            pnlReunion.SuspendLayout();
            pnlVehicule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gvlistvehi).BeginInit();
            SuspendLayout();
            // 
            // lbojet
            // 
            lbojet.AutoSize = true;
            lbojet.Location = new Point(68, 102);
            lbojet.Name = "lbojet";
            lbojet.Size = new Size(262, 20);
            lbojet.TabIndex = 0;
            lbojet.Text = "Quelle est l'objet de votre demande  ?";
            // 
            // tbobjet
            // 
            tbobjet.Location = new Point(68, 142);
            tbobjet.Name = "tbobjet";
            tbobjet.Size = new Size(262, 27);
            tbobjet.TabIndex = 1;
            // 
            // lbprioritaire
            // 
            lbprioritaire.AutoSize = true;
            lbprioritaire.Location = new Point(68, 200);
            lbprioritaire.Name = "lbprioritaire";
            lbprioritaire.Size = new Size(186, 20);
            lbprioritaire.TabIndex = 2;
            lbprioritaire.Text = "Votre doit être prioritaire ?";
            // 
            // cbprioritaire
            // 
            cbprioritaire.AutoSize = true;
            cbprioritaire.Location = new Point(68, 235);
            cbprioritaire.Name = "cbprioritaire";
            cbprioritaire.Size = new Size(18, 17);
            cbprioritaire.TabIndex = 3;
            cbprioritaire.UseVisualStyleBackColor = true;
            // 
            // lbtype
            // 
            lbtype.AutoSize = true;
            lbtype.Location = new Point(68, 9);
            lbtype.Name = "lbtype";
            lbtype.Size = new Size(225, 20);
            lbtype.TabIndex = 5;
            lbtype.Text = "Votre demande est a quel sujet ?";
            // 
            // ddltype
            // 
            ddltype.FormattingEnabled = true;
            ddltype.Location = new Point(68, 48);
            ddltype.Name = "ddltype";
            ddltype.Size = new Size(262, 28);
            ddltype.TabIndex = 6;
            ddltype.SelectedIndexChanged += ddltype_SelectedIndexChanged;
            // 
            // pnlService
            // 
            pnlService.Controls.Add(dllservice);
            pnlService.Controls.Add(label2);
            pnlService.Location = new Point(393, 3);
            pnlService.Name = "pnlService";
            pnlService.Size = new Size(539, 416);
            pnlService.TabIndex = 7;
            // 
            // dllservice
            // 
            dllservice.FormattingEnabled = true;
            dllservice.Location = new Point(28, 62);
            dllservice.Name = "dllservice";
            dllservice.Size = new Size(262, 28);
            dllservice.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 23);
            label2.Name = "label2";
            label2.Size = new Size(278, 20);
            label2.TabIndex = 7;
            label2.Text = "Vous souhaitez contacter quelle service ?";
            // 
            // pnlReunion
            // 
            pnlReunion.Controls.Add(gvlistvehi);
            pnlReunion.Location = new Point(396, 3);
            pnlReunion.Name = "pnlReunion";
            pnlReunion.Size = new Size(536, 416);
            pnlReunion.TabIndex = 8;
            // 
            // pnlVehicule
            // 
            pnlVehicule.Controls.Add(ddlvehicule);
            pnlVehicule.Controls.Add(label1);
            pnlVehicule.Location = new Point(393, 3);
            pnlVehicule.Name = "pnlVehicule";
            pnlVehicule.Size = new Size(492, 399);
            pnlVehicule.TabIndex = 9;
            // 
            // ddlvehicule
            // 
            ddlvehicule.FormattingEnabled = true;
            ddlvehicule.Location = new Point(3, 42);
            ddlvehicule.Name = "ddlvehicule";
            ddlvehicule.Size = new Size(262, 28);
            ddlvehicule.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(291, 20);
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
            btsave.Location = new Point(83, 465);
            btsave.Margin = new Padding(2);
            btsave.Name = "btsave";
            btsave.Size = new Size(247, 57);
            btsave.TabIndex = 9;
            btsave.Text = "Enregistrer";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // lbdatedebut
            // 
            lbdatedebut.AutoSize = true;
            lbdatedebut.Location = new Point(68, 275);
            lbdatedebut.Name = "lbdatedebut";
            lbdatedebut.Size = new Size(198, 20);
            lbdatedebut.TabIndex = 10;
            lbdatedebut.Text = "Votre demande debutera le :";
            // 
            // lbdateend
            // 
            lbdateend.AutoSize = true;
            lbdateend.Location = new Point(68, 366);
            lbdateend.Name = "lbdateend";
            lbdateend.Size = new Size(172, 20);
            lbdateend.TabIndex = 12;
            lbdateend.Text = "Votre demande finira le :";
            // 
            // tbdatedebut
            // 
            tbdatedebut.Format = DateTimePickerFormat.Short;
            tbdatedebut.Location = new Point(68, 319);
            tbdatedebut.Name = "tbdatedebut";
            tbdatedebut.Size = new Size(250, 27);
            tbdatedebut.TabIndex = 23;
            tbdatedebut.Value = new DateTime(2025, 1, 27, 0, 0, 0, 0);
            // 
            // tbdateend
            // 
            tbdateend.Format = DateTimePickerFormat.Short;
            tbdateend.Location = new Point(68, 408);
            tbdateend.Name = "tbdateend";
            tbdateend.Size = new Size(250, 27);
            tbdateend.TabIndex = 24;
            tbdateend.Value = new DateTime(2025, 1, 27, 0, 0, 0, 0);
            // 
            // tbcom
            // 
            tbcom.Location = new Point(396, 455);
            tbcom.Multiline = true;
            tbcom.Name = "tbcom";
            tbcom.Size = new Size(370, 78);
            tbcom.TabIndex = 26;
            // 
            // lbcom
            // 
            lbcom.AutoSize = true;
            lbcom.Location = new Point(396, 415);
            lbcom.Name = "lbcom";
            lbcom.Size = new Size(370, 20);
            lbcom.TabIndex = 25;
            lbcom.Text = "Avez-vous des informations supplémentaire a fournir ?";
            // 
            // gvlistvehi
            // 
            gvlistvehi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvlistvehi.Location = new Point(25, 50);
            gvlistvehi.Name = "gvlistvehi";
            gvlistvehi.RowHeadersWidth = 51;
            gvlistvehi.Size = new Size(508, 242);
            gvlistvehi.TabIndex = 0;
            // 
            // popupdemande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 552);
            Controls.Add(tbcom);
            Controls.Add(lbcom);
            Controls.Add(pnlReunion);
            Controls.Add(pnlService);
            Controls.Add(tbdateend);
            Controls.Add(tbdatedebut);
            Controls.Add(lbdateend);
            Controls.Add(lbdatedebut);
            Controls.Add(pnlVehicule);
            Controls.Add(btsave);
            Controls.Add(ddltype);
            Controls.Add(lbtype);
            Controls.Add(cbprioritaire);
            Controls.Add(lbprioritaire);
            Controls.Add(tbobjet);
            Controls.Add(lbojet);
            Name = "popupdemande";
            Text = "popupdemande";
            pnlService.ResumeLayout(false);
            pnlService.PerformLayout();
            pnlReunion.ResumeLayout(false);
            pnlVehicule.ResumeLayout(false);
            pnlVehicule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gvlistvehi).EndInit();
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
        private ComboBox dllservice;
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
        private DataGridView gvlistvehi;
    }
}