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
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.headLine = new System.Windows.Forms.RichTextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelNumberOfFriends = new System.Windows.Forms.Label();
            this.labelActualNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 20;
            this.listBoxFriends.Location = new System.Drawing.Point(521, 235);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(382, 224);
            this.listBoxFriends.TabIndex = 18;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1242, 44);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(102, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 17;
            this.pictureBoxLogo.TabStop = false;
            // 
            // headLine
            // 
            this.headLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.headLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headLine.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLine.ForeColor = System.Drawing.SystemColors.Menu;
            this.headLine.Location = new System.Drawing.Point(630, 121);
            this.headLine.Name = "headLine";
            this.headLine.ReadOnly = true;
            this.headLine.Size = new System.Drawing.Size(208, 69);
            this.headLine.TabIndex = 16;
            this.headLine.Text = "HeadLine";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(62, 89);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(146, 103);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 15;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(58, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 42);
            this.labelName.TabIndex = 14;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNumberOfFriends
            // 
            this.labelNumberOfFriends.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfFriends.AutoSize = true;
            this.labelNumberOfFriends.Location = new System.Drawing.Point(280, 249);
            this.labelNumberOfFriends.Name = "labelNumberOfFriends";
            this.labelNumberOfFriends.Size = new System.Drawing.Size(139, 20);
            this.labelNumberOfFriends.TabIndex = 19;
            this.labelNumberOfFriends.Text = "Number of friends:";
            // 
            // labelActualNumber
            // 
            this.labelActualNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelActualNumber.AutoSize = true;
            this.labelActualNumber.Location = new System.Drawing.Point(425, 249);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(18, 20);
            this.labelActualNumber.TabIndex = 20;
            this.labelActualNumber.Text = "0";
            // 
            // FriendsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 550);
            this.Controls.Add(this.labelActualNumber);
            this.Controls.Add(this.labelNumberOfFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.headLine);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
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
        private System.Windows.Forms.RichTextBox headLine;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelNumberOfFriends;
        private System.Windows.Forms.Label labelActualNumber;
    }
}