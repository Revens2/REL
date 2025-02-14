namespace REL
{
    partial class popvalid
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
            lbmess = new Label();
            tbmess = new TextBox();
            btcancel = new Button();
            btsave = new Button();
            SuspendLayout();
            // 
            // lbmess
            // 
            lbmess.AutoSize = true;
            lbmess.Location = new Point(71, 21);
            lbmess.Name = "lbmess";
            lbmess.Size = new Size(24, 15);
            lbmess.TabIndex = 0;
            lbmess.Text = "oui";
            // 
            // tbmess
            // 
            tbmess.Location = new Point(50, 60);
            tbmess.Multiline = true;
            tbmess.Name = "tbmess";
            tbmess.Size = new Size(285, 49);
            tbmess.TabIndex = 1;
            // 
            // btcancel
            // 
            btcancel.BackColor = SystemColors.ControlDarkDark;
            btcancel.Location = new Point(227, 132);
            btcancel.Name = "btcancel";
            btcancel.Size = new Size(99, 33);
            btcancel.TabIndex = 2;
            btcancel.Text = "Annuler";
            btcancel.UseVisualStyleBackColor = false;
            btcancel.Click += btcancel_Click;
            // 
            // btsave
            // 
            btsave.BackColor = Color.Green;
            btsave.Location = new Point(50, 132);
            btsave.Name = "btsave";
            btsave.Size = new Size(106, 33);
            btsave.TabIndex = 3;
            btsave.Text = "Confirmer";
            btsave.UseVisualStyleBackColor = false;
            btsave.Click += btsave_Click;
            // 
            // popvalid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 177);
            Controls.Add(btsave);
            Controls.Add(btcancel);
            Controls.Add(tbmess);
            Controls.Add(lbmess);
            Name = "popvalid";
            Text = "popvalid";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbmess;
        private TextBox tbmess;
        private Button btcancel;
        private Button btsave;
    }
}