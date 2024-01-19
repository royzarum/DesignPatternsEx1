namespace BasicFacebookFeatures
{
    partial class FacebookTemplateFormControls
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
            this.labelName = new System.Windows.Forms.Label();
            this.headLine = new System.Windows.Forms.RichTextBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(33, 16);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(79, 27);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headLine
            // 
            this.headLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.headLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.headLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headLine.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLine.ForeColor = System.Drawing.SystemColors.Menu;
            this.headLine.Location = new System.Drawing.Point(359, 68);
            this.headLine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.headLine.Name = "headLine";
            this.headLine.ReadOnly = true;
            this.headLine.Size = new System.Drawing.Size(141, 46);
            this.headLine.TabIndex = 3;
            this.headLine.Text = "HeadLine";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(21, 45);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(97, 67);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 2;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(802, 16);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FacebookTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 451);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.headLine);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FacebookTemplateForm";
            this.Text = "FacebookTemplateForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.RichTextBox headLine;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}