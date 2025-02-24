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
            SuspendLayout();
            // 
            // lbtype
            // 
            lbtype.AutoSize = true;
            lbtype.Location = new Point(25, 83);
            lbtype.Name = "lbtype";
            lbtype.Size = new Size(155, 20);
            lbtype.TabIndex = 0;
            lbtype.Text = "Type de la demande : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 9);
            label2.Name = "label2";
            label2.Size = new Size(442, 46);
            label2.TabIndex = 1;
            label2.Text = "Résumé de votre demande";
            // 
            // lbobjet
            // 
            lbobjet.AutoSize = true;
            lbobjet.Location = new Point(25, 130);
            lbobjet.Name = "lbobjet";
            lbobjet.Size = new Size(57, 20);
            lbobjet.TabIndex = 2;
            lbobjet.Text = "Objet : ";
            // 
            // btsave
            // 
            btsave.BackColor = Color.Green;
            btsave.Location = new Point(223, 376);
            btsave.Margin = new Padding(3, 4, 3, 4);
            btsave.Name = "btsave";
            btsave.Size = new Size(121, 44);
            btsave.TabIndex = 5;
            btsave.Text = "Confirmer";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // btcancel
            // 
            btcancel.BackColor = SystemColors.ControlDarkDark;
            btcancel.Location = new Point(425, 376);
            btcancel.Margin = new Padding(3, 4, 3, 4);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(113, 44);
            btcancel.TabIndex = 4;
            btcancel.Text = "Annuler";
            btcancel.UseVisualStyleBackColor = false;
            btcancel.Click += btcancel_Click;
            // 
            // lbcom
            // 
            lbcom.AutoSize = true;
            lbcom.Location = new Point(25, 237);
            lbcom.Name = "lbcom";
            lbcom.Size = new Size(110, 20);
            lbcom.TabIndex = 6;
            lbcom.Text = "Commentaire : ";
            // 
            // lbprio
            // 
            lbprio.AutoSize = true;
            lbprio.Location = new Point(25, 175);
            lbprio.Name = "lbprio";
            lbprio.Size = new Size(155, 20);
            lbprio.TabIndex = 7;
            lbprio.Text = "Demande prioritaire : ";
            // 
            // lbdebut
            // 
            lbdebut.AutoSize = true;
            lbdebut.Location = new Point(468, 83);
            lbdebut.Name = "lbdebut";
            lbdebut.Size = new Size(116, 20);
            lbdebut.TabIndex = 8;
            lbdebut.Text = "Date de debut : ";
            // 
            // lbfin
            // 
            lbfin.AutoSize = true;
            lbfin.Location = new Point(468, 130);
            lbfin.Name = "lbfin";
            lbfin.Size = new Size(94, 20);
            lbfin.TabIndex = 9;
            lbfin.Text = "Date de fin : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(468, 237);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 10;
            label1.Text = "Motif de mise en attente : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(468, 175);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 11;
            label3.Text = "Service concerné :";
            // 
            // popupconfirmdem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}