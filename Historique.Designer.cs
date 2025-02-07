namespace REL
{
    partial class Historique
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
            gv_list = new DataGridView();
            cbstatut = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)gv_list).BeginInit();
            SuspendLayout();
            // 
            // gv_list
            // 
            gv_list.AllowUserToOrderColumns = true;
            gv_list.BackgroundColor = SystemColors.ActiveCaptionText;
            gv_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_list.Location = new Point(159, 140);
            gv_list.Margin = new Padding(2);
            gv_list.Name = "gv_list";
            gv_list.RowHeadersWidth = 82;
            gv_list.Size = new Size(677, 375);
            gv_list.TabIndex = 8;
            // 
            // cbstatut
            // 
            cbstatut.AutoSize = true;
            cbstatut.Location = new Point(206, 86);
            cbstatut.Name = "cbstatut";
            cbstatut.Size = new Size(248, 24);
            cbstatut.TabIndex = 9;
            cbstatut.Text = "Afficher les Demandes Annulées ";
            cbstatut.UseVisualStyleBackColor = true;
            cbstatut.CheckedChanged += cbstatut_CheckedChanged;
            // 
            // Historique
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 535);
            Controls.Add(cbstatut);
            Controls.Add(gv_list);
            Name = "Historique";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gv_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gv_list;
        private CheckBox cbstatut;
    }
}