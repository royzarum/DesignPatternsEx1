namespace BasicFacebookFeatures
{
    partial class FriendsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsForm));
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberOfFriends = new System.Windows.Forms.Label();
            this.labelActualNumber = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxFriends.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 16;
            this.listBoxFriends.Location = new System.Drawing.Point(347, 153);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(256, 132);
            this.listBoxFriends.TabIndex = 18;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(39, 29);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(126, 27);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNumberOfFriends
            // 
            this.labelNumberOfFriends.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfFriends.AutoSize = true;
            this.labelNumberOfFriends.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfFriends.Location = new System.Drawing.Point(344, 135);
            this.labelNumberOfFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfFriends.Name = "labelNumberOfFriends";
            this.labelNumberOfFriends.Size = new System.Drawing.Size(124, 16);
            this.labelNumberOfFriends.TabIndex = 19;
            this.labelNumberOfFriends.Text = "Number of friends:";
            // 
            // labelActualNumber
            // 
            this.labelActualNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelActualNumber.AutoSize = true;
            this.labelActualNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelActualNumber.Location = new System.Drawing.Point(472, 135);
            this.labelActualNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(14, 16);
            this.labelActualNumber.TabIndex = 20;
            this.labelActualNumber.Text = "0";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(828, 29);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(41, 58);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(97, 67);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 15;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.labelHeadline.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(387, 84);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(159, 41);
            this.labelHeadline.TabIndex = 23;
            this.labelHeadline.Text = "Headline";
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(939, 358);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelActualNumber);
            this.Controls.Add(this.labelNumberOfFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FriendsForm";
            this.RightToLeftLayout = true;
            this.Text = "Friends";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberOfFriends;
        private System.Windows.Forms.Label labelActualNumber;
        private System.Windows.Forms.Label labelHeadline;
    }
}