namespace BasicFacebookFeatures
{
    partial class AlbumsForm
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
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(212, 141);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(333, 56);
            this.listBoxAlbums.TabIndex = 4;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxAlbums);
            this.Name = "AlbumsForm";
            this.Text = "AlbumsForm";
            this.Controls.SetChildIndex(this.listBoxAlbums, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
    }
}