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
            btsave = new Button();
            pnlService.SuspendLayout();
            pnlReunion.SuspendLayout();
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
            pnlService.Location = new Point(440, 28);
            pnlService.Name = "pnlService";
            pnlService.Size = new Size(492, 374);
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
            pnlReunion.Controls.Add(pnlVehicule);
            pnlReunion.Location = new Point(295, 298);
            pnlReunion.Name = "pnlReunion";
            pnlReunion.Size = new Size(250, 125);
            pnlReunion.TabIndex = 8;
            // 
            // pnlVehicule
            // 
            pnlVehicule.Location = new Point(8, 8);
            pnlVehicule.Name = "pnlVehicule";
            pnlVehicule.Size = new Size(250, 125);
            pnlVehicule.TabIndex = 9;
            // 
            // btsave
            // 
            btsave.BackColor = Color.FromArgb(60, 179, 113);
            btsave.Cursor = Cursors.Hand;
            btsave.FlatAppearance.BorderSize = 0;
            btsave.FlatStyle = FlatStyle.Flat;
            btsave.Font = new Font("Arial", 16F);
            btsave.ForeColor = Color.White;
            btsave.Location = new Point(43, 374);
            btsave.Margin = new Padding(2);
            btsave.Name = "btsave";
            btsave.Size = new Size(247, 57);
            btsave.TabIndex = 9;
            btsave.Text = "Enregistrer";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // popupdemande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 552);
            Controls.Add(btsave);
            Controls.Add(pnlReunion);
            Controls.Add(pnlService);
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
    }
}