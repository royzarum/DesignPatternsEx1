namespace BasicFacebookFeatures
{
    partial class GroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsForm));
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelActualNumber = new System.Windows.Forms.Label();
            this.labelNumberOGroups = new System.Windows.Forms.Label();
            this.labelHeadline = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(14, 27);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(188, 27);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxGroups.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxGroups.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(247, 142);
            this.listBoxGroups.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(425, 132);
            this.listBoxGroups.TabIndex = 13;
            // 
            // labelActualNumber
            // 
            this.labelActualNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelActualNumber.AutoSize = true;
            this.labelActualNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelActualNumber.Location = new System.Drawing.Point(372, 281);
            this.labelActualNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(14, 16);
            this.labelActualNumber.TabIndex = 22;
            this.labelActualNumber.Text = "0";
            // 
            // labelNumberOGroups
            // 
            this.labelNumberOGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOGroups.AutoSize = true;
            this.labelNumberOGroups.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOGroups.Location = new System.Drawing.Point(244, 278);
            this.labelNumberOGroups.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOGroups.Name = "labelNumberOGroups";
            this.labelNumberOGroups.Size = new System.Drawing.Size(124, 16);
            this.labelNumberOGroups.TabIndex = 21;
            this.labelNumberOGroups.Text = "Number of groups:";
            // 
            // labelHeadline
            // 
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.labelHeadline.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(366, 82);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(159, 41);
            this.labelHeadline.TabIndex = 23;
            this.labelHeadline.Text = "Headline";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(818, 27);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(17, 56);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(97, 67);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 10;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(894, 349);
            this.Controls.Add(this.labelHeadline);
            this.Controls.Add(this.labelActualNumber);
            this.Controls.Add(this.labelNumberOGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GroupsForm";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelActualNumber;
        private System.Windows.Forms.Label labelNumberOGroups;
        private System.Windows.Forms.Label labelHeadline;
    }
}