namespace BasicFacebookFeatures
{
    partial class LikedPagesForm
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
            this.richTextBoxHeadLine = new System.Windows.Forms.RichTextBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxHeadLine
            // 
            this.richTextBoxHeadLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBoxHeadLine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBoxHeadLine.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBoxHeadLine.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxHeadLine.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBoxHeadLine.Location = new System.Drawing.Point(11, 31);
            this.richTextBoxHeadLine.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxHeadLine.Name = "richTextBoxHeadLine";
            this.richTextBoxHeadLine.ReadOnly = true;
            this.richTextBoxHeadLine.Size = new System.Drawing.Size(381, 49);
            this.richTextBoxHeadLine.TabIndex = 8;
            this.richTextBoxHeadLine.Text = "HeadLine";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(721, 11);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(11, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 327);
            this.listBox1.TabIndex = 10;
            // 
            // LikedPagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.richTextBoxHeadLine);
            this.Name = "LikedPagesForm";
            this.Text = "LikedPagesForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHeadLine;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.ListBox listBox1;
    }
}