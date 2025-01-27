namespace Biblio
{
    partial class ajoutlivre
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
            lbtitle = new Label();
            lbannee = new Label();
            lbname = new Label();
            lbauteur = new Label();
            lbgenre = new Label();
            Valider = new Button();
            tbname = new TextBox();
            tbgenre = new TextBox();
            tbauteur = new TextBox();
            tbanne = new TextBox();
            SuspendLayout();
            // 
            // lbtitle
            // 
            lbtitle.AutoSize = true;
            lbtitle.Location = new Point(669, 40);
            lbtitle.Name = "lbtitle";
            lbtitle.Size = new Size(128, 32);
            lbtitle.TabIndex = 0;
            lbtitle.Text = "Ajout Livre";
            // 
            // lbannee
            // 
            lbannee.AutoSize = true;
            lbannee.Location = new Point(928, 146);
            lbannee.Name = "lbannee";
            lbannee.Size = new Size(243, 32);
            lbannee.TabIndex = 1;
            lbannee.Text = "Année de publication";
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Location = new Point(195, 146);
            lbname.Name = "lbname";
            lbname.Size = new Size(159, 32);
            lbname.TabIndex = 2;
            lbname.Text = "Nom du Livre";
            // 
            // lbauteur
            // 
            lbauteur.AutoSize = true;
            lbauteur.Location = new Point(195, 383);
            lbauteur.Name = "lbauteur";
            lbauteur.Size = new Size(86, 32);
            lbauteur.TabIndex = 3;
            lbauteur.Text = "Auteur";
            // 
            // lbgenre
            // 
            lbgenre.AutoSize = true;
            lbgenre.Location = new Point(928, 383);
            lbgenre.Name = "lbgenre";
            lbgenre.Size = new Size(78, 32);
            lbgenre.TabIndex = 4;
            lbgenre.Text = "Genre";
            // 
            // Valider
            // 
            Valider.Location = new Point(638, 616);
            Valider.Name = "Valider";
            Valider.Size = new Size(222, 74);
            Valider.TabIndex = 5;
            Valider.Text = "btvalidate";
            Valider.UseVisualStyleBackColor = true;
            Valider.Click += this.Valider_Click;
            // 
            // tbname
            // 
            tbname.Location = new Point(195, 228);
            tbname.Name = "tbname";
            tbname.Size = new Size(200, 39);
            tbname.TabIndex = 6;
            // 
            // tbgenre
            // 
            tbgenre.Location = new Point(928, 471);
            tbgenre.Name = "tbgenre";
            tbgenre.Size = new Size(200, 39);
            tbgenre.TabIndex = 7;
            // 
            // tbauteur
            // 
            tbauteur.Location = new Point(195, 471);
            tbauteur.Name = "tbauteur";
            tbauteur.Size = new Size(200, 39);
            tbauteur.TabIndex = 8;
            // 
            // tbanne
            // 
            tbanne.Location = new Point(928, 228);
            tbanne.Name = "tbanne";
            tbanne.Size = new Size(200, 39);
            tbanne.TabIndex = 9;
            // 
            // ajoutlivre
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 40, 40);
            ClientSize = new Size(1490, 786);
            Controls.Add(tbanne);
            Controls.Add(tbauteur);
            Controls.Add(tbgenre);
            Controls.Add(tbname);
            Controls.Add(Valider);
            Controls.Add(lbgenre);
            Controls.Add(lbauteur);
            Controls.Add(lbname);
            Controls.Add(lbannee);
            Controls.Add(lbtitle);
            Name = "ajoutlivre";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbtitle;
        private Label lbannee;
        private Label lbname;
        private Label lbauteur;
        private Label lbgenre;
        private Button Valider;
        private TextBox tbname;
        private TextBox tbgenre;
        private TextBox tbauteur;
        private TextBox tbanne;
    }
}