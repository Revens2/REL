namespace REL
{
    partial class popupconfirmdem
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
            lbtype = new Label();
            label2 = new Label();
            lbobjet = new Label();
            btsave = new Button();
            btcancel = new Button();
            lbcom = new Label();
            lbprio = new Label();
            lbdebut = new Label();
            lbfin = new Label();
            label1 = new Label();
            label3 = new Label();
            lbtypedata = new Label();
            lbobjetdata = new Label();
            lbpriodata = new Label();
            lbcomdata = new Label();
            lbdebutdata = new Label();
            lbfindata = new Label();
            lbservicedata = new Label();
            lbmotifdata = new Label();
            SuspendLayout();
            // 
            // lbtype
            // 
            lbtype.AutoSize = true;
            lbtype.Location = new Point(22, 62);
            lbtype.Name = "lbtype";
            lbtype.Size = new Size(122, 15);
            lbtype.TabIndex = 0;
            lbtype.Text = "Type de la demande : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 7);
            label2.Name = "label2";
            label2.Size = new Size(359, 37);
            label2.TabIndex = 1;
            label2.Text = "Résumé de votre demande";
            // 
            // lbobjet
            // 
            lbobjet.AutoSize = true;
            lbobjet.Location = new Point(22, 98);
            lbobjet.Name = "lbobjet";
            lbobjet.Size = new Size(45, 15);
            lbobjet.TabIndex = 2;
            lbobjet.Text = "Objet : ";
            // 
            // btsave
            // 
            btsave.BackColor = Color.Green;
            btsave.Location = new Point(195, 282);
            btsave.Name = "btsave";
            btsave.Size = new Size(106, 33);
            btsave.TabIndex = 5;
            btsave.Text = "Confirmer";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // btcancel
            // 
            btcancel.BackColor = SystemColors.ControlDarkDark;
            btcancel.Location = new Point(372, 282);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(99, 33);
            btcancel.TabIndex = 4;
            btcancel.Text = "Annuler";
            btcancel.UseVisualStyleBackColor = false;
            btcancel.Click += btcancel_Click;
            // 
            // lbcom
            // 
            lbcom.AutoSize = true;
            lbcom.Location = new Point(22, 178);
            lbcom.Name = "lbcom";
            lbcom.Size = new Size(89, 15);
            lbcom.TabIndex = 6;
            lbcom.Text = "Commentaire : ";
            // 
            // lbprio
            // 
            lbprio.AutoSize = true;
            lbprio.Location = new Point(22, 131);
            lbprio.Name = "lbprio";
            lbprio.Size = new Size(121, 15);
            lbprio.TabIndex = 7;
            lbprio.Text = "Demande prioritaire : ";
            // 
            // lbdebut
            // 
            lbdebut.AutoSize = true;
            lbdebut.Location = new Point(410, 62);
            lbdebut.Name = "lbdebut";
            lbdebut.Size = new Size(90, 15);
            lbdebut.TabIndex = 8;
            lbdebut.Text = "Date de debut : ";
            // 
            // lbfin
            // 
            lbfin.AutoSize = true;
            lbfin.Location = new Point(410, 98);
            lbfin.Name = "lbfin";
            lbfin.Size = new Size(73, 15);
            lbfin.TabIndex = 9;
            lbfin.Text = "Date de fin : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(410, 178);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 10;
            label1.Text = "Motif de mise en attente : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(410, 131);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 11;
            label3.Text = "Service concerné :";
            // 
            // lbtypedata
            // 
            lbtypedata.AutoSize = true;
            lbtypedata.Location = new Point(143, 62);
            lbtypedata.Name = "lbtypedata";
            lbtypedata.Size = new Size(53, 15);
            lbtypedata.TabIndex = 12;
            lbtypedata.Text = "typedata";
            // 
            // lbobjetdata
            // 
            lbobjetdata.AutoSize = true;
            lbobjetdata.Location = new Point(143, 98);
            lbobjetdata.Name = "lbobjetdata";
            lbobjetdata.Size = new Size(57, 15);
            lbobjetdata.TabIndex = 13;
            lbobjetdata.Text = "objetdata";
            // 
            // lbpriodata
            // 
            lbpriodata.AutoSize = true;
            lbpriodata.Location = new Point(143, 131);
            lbpriodata.Name = "lbpriodata";
            lbpriodata.Size = new Size(51, 15);
            lbpriodata.TabIndex = 14;
            lbpriodata.Text = "priodata";
            // 
            // lbcomdata
            // 
            lbcomdata.AutoSize = true;
            lbcomdata.Location = new Point(143, 178);
            lbcomdata.Name = "lbcomdata";
            lbcomdata.Size = new Size(54, 15);
            lbcomdata.TabIndex = 15;
            lbcomdata.Text = "comdata";
            // 
            // lbdebutdata
            // 
            lbdebutdata.AutoSize = true;
            lbdebutdata.Location = new Point(548, 62);
            lbdebutdata.Name = "lbdebutdata";
            lbdebutdata.Size = new Size(61, 15);
            lbdebutdata.TabIndex = 16;
            lbdebutdata.Text = "debutdata";
            // 
            // lbfindata
            // 
            lbfindata.AutoSize = true;
            lbfindata.Location = new Point(548, 98);
            lbfindata.Name = "lbfindata";
            lbfindata.Size = new Size(44, 15);
            lbfindata.TabIndex = 17;
            lbfindata.Text = "findata";
            // 
            // lbservicedata
            // 
            lbservicedata.AutoSize = true;
            lbservicedata.Location = new Point(548, 131);
            lbservicedata.Name = "lbservicedata";
            lbservicedata.Size = new Size(66, 15);
            lbservicedata.TabIndex = 18;
            lbservicedata.Text = "servicedata";
            // 
            // lbmotifdata
            // 
            lbmotifdata.AutoSize = true;
            lbmotifdata.Location = new Point(548, 178);
            lbmotifdata.Name = "lbmotifdata";
            lbmotifdata.Size = new Size(59, 15);
            lbmotifdata.TabIndex = 19;
            lbmotifdata.Text = "motifdata";
            // 
            // popupconfirmdem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lbmotifdata);
            Controls.Add(lbservicedata);
            Controls.Add(lbfindata);
            Controls.Add(lbdebutdata);
            Controls.Add(lbcomdata);
            Controls.Add(lbpriodata);
            Controls.Add(lbobjetdata);
            Controls.Add(lbtypedata);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lbfin);
            Controls.Add(lbdebut);
            Controls.Add(lbprio);
            Controls.Add(lbcom);
            Controls.Add(btsave);
            Controls.Add(btcancel);
            Controls.Add(lbobjet);
            Controls.Add(label2);
            Controls.Add(lbtype);
            Margin = new Padding(3, 2, 3, 2);
            Name = "popupconfirmdem";
            Text = "popupconfirmdem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtype;
        private Label label2;
        private Label lbobjet;
        private Button btsave;
        private Button btcancel;
        private Label lbcom;
        private Label lbprio;
        private Label lbdebut;
        private Label lbfin;
        private Label label1;
        private Label label3;
        private Label lbtypedata;
        private Label lbobjetdata;
        private Label lbpriodata;
        private Label lbcomdata;
        private Label lbdebutdata;
        private Label lbfindata;
        private Label lbservicedata;
        private Label lbmotifdata;
    }
}