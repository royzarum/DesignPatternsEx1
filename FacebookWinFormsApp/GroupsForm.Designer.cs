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
            this.headLine = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelActualNumber = new System.Windows.Forms.Label();
            this.labelNumberOGroups = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // headLine
            // 
            this.headLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.headLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headLine.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLine.ForeColor = System.Drawing.SystemColors.Menu;
            this.headLine.Location = new System.Drawing.Point(593, 118);
            this.headLine.Name = "headLine";
            this.headLine.ReadOnly = true;
            this.headLine.Size = new System.Drawing.Size(208, 69);
            this.headLine.TabIndex = 11;
            this.headLine.Text = "HeadLine";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(21, 41);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 42);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1205, 41);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(102, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(25, 86);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(146, 103);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 10;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 20;
            this.listBoxGroups.Location = new System.Drawing.Point(359, 218);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(636, 204);
            this.listBoxGroups.TabIndex = 13;
            // 
            // labelActualNumber
            // 
            this.labelActualNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelActualNumber.AutoSize = true;
            this.labelActualNumber.Location = new System.Drawing.Point(283, 218);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(18, 20);
            this.labelActualNumber.TabIndex = 22;
            this.labelActualNumber.Text = "0";
            // 
            // labelNumberOGroups
            // 
            this.labelNumberOGroups.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOGroups.AutoSize = true;
            this.labelNumberOGroups.Location = new System.Drawing.Point(138, 218);
            this.labelNumberOGroups.Name = "labelNumberOGroups";
            this.labelNumberOGroups.Size = new System.Drawing.Size(140, 20);
            this.labelNumberOGroups.TabIndex = 21;
            this.labelNumberOGroups.Text = "Number of groups:";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 450);
            this.Controls.Add(this.labelActualNumber);
            this.Controls.Add(this.labelNumberOGroups);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.headLine);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
            this.Name = "GroupsForm";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.RichTextBox headLine;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label labelActualNumber;
        private System.Windows.Forms.Label labelNumberOGroups;
    }
}