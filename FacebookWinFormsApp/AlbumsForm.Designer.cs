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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumsForm));
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberOfAlbumsValue = new System.Windows.Forms.Label();
            this.labelNumberOfAlbums = new System.Windows.Forms.Label();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxAlbums.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxAlbums.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 21;
            this.listBoxAlbums.Location = new System.Drawing.Point(495, 212);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(448, 67);
            this.listBoxAlbums.TabIndex = 4;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.labelName.Location = new System.Drawing.Point(38, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(150, 42);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberOfAlbumsValue
            // 
            this.labelNumberOfAlbumsValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfAlbumsValue.AutoSize = true;
            this.labelNumberOfAlbumsValue.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfAlbumsValue.Location = new System.Drawing.Point(690, 291);
            this.labelNumberOfAlbumsValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfAlbumsValue.Name = "labelNumberOfAlbumsValue";
            this.labelNumberOfAlbumsValue.Size = new System.Drawing.Size(21, 24);
            this.labelNumberOfAlbumsValue.TabIndex = 9;
            this.labelNumberOfAlbumsValue.Text = "0";
            // 
            // labelNumberOfAlbums
            // 
            this.labelNumberOfAlbums.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfAlbums.AutoSize = true;
            this.labelNumberOfAlbums.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfAlbums.Location = new System.Drawing.Point(490, 291);
            this.labelNumberOfAlbums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfAlbums.Name = "labelNumberOfAlbums";
            this.labelNumberOfAlbums.Size = new System.Drawing.Size(190, 24);
            this.labelNumberOfAlbums.TabIndex = 10;
            this.labelNumberOfAlbums.Text = "Number of albums:";
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.labelHeadline.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(585, 143);
            this.labelHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(246, 62);
            this.labelHeadline.TabIndex = 24;
            this.labelHeadline.Text = "Headline";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1222, 58);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(102, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 8;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.ErrorImage = global::BasicFacebookFeatures.Properties.Resources.NullProfileImage;
            this.pictureBoxProfile.Location = new System.Drawing.Point(42, 105);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(150, 154);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 56;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // AlbumsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1359, 731);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelNumberOfAlbums);
            this.Controls.Add(this.labelNumberOfAlbumsValue);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.listBoxAlbums);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(97, 91);
            this.Name = "AlbumsForm";
            this.Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberOfAlbumsValue;
        private System.Windows.Forms.Label labelNumberOfAlbums;
        private System.Windows.Forms.Label labelHeadline;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}