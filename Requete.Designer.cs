namespace REL
{
    partial class Requete
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
            gvrequest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gvrequest).BeginInit();
            SuspendLayout();
            // 
            // gvrequest
            // 
            gvrequest.AllowUserToOrderColumns = true;
            gvrequest.BackgroundColor = SystemColors.ActiveCaptionText;
            gvrequest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvrequest.Location = new Point(44, 159);
            gvrequest.Margin = new Padding(2, 3, 2, 3);
            gvrequest.Name = "gvrequest";
            gvrequest.RowHeadersWidth = 82;
            gvrequest.Size = new Size(1041, 375);
            gvrequest.TabIndex = 11;
            gvrequest.CellContentClick += gvrequest_CellContentClick;
            // 
            // Requete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 692);
            Controls.Add(gvrequest);
            Name = "Requete";
            Text = "Requete";
            ((System.ComponentModel.ISupportInitialize)gvrequest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gvrequest;
    }
}