namespace BasicFacebookFeatures
{
    partial class PostsForm
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
            this.labelNewPost = new System.Windows.Forms.Label();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonFilterByDate = new System.Windows.Forms.Button();
            this.buttonCancelFilter = new System.Windows.Forms.Button();
            this.labelMonthIsZero = new System.Windows.Forms.Label();
            this.labelDayIsZero = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelActualNumber = new System.Windows.Forms.Label();
            this.labelNumberOfPosts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
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
            this.headLine.Location = new System.Drawing.Point(572, 125);
            this.headLine.Name = "headLine";
            this.headLine.ReadOnly = true;
            this.headLine.Size = new System.Drawing.Size(202, 69);
            this.headLine.TabIndex = 11;
            this.headLine.Text = "HeadLine";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(88, 53);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 42);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNewPost
            // 
            this.labelNewPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewPost.AutoSize = true;
            this.labelNewPost.Location = new System.Drawing.Point(761, 35);
            this.labelNewPost.Name = "labelNewPost";
            this.labelNewPost.Size = new System.Drawing.Size(80, 20);
            this.labelNewPost.TabIndex = 13;
            this.labelNewPost.Text = "New Post:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(847, 32);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(290, 30);
            this.textBoxPost.TabIndex = 14;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPost.Location = new System.Drawing.Point(1143, 28);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(106, 43);
            this.buttonPost.TabIndex = 15;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(231, 237);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(865, 184);
            this.listBoxPosts.TabIndex = 16;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownMonth.Location = new System.Drawing.Point(539, 491);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(49, 26);
            this.numericUpDownMonth.TabIndex = 17;
            this.numericUpDownMonth.ValueChanged += new System.EventHandler(this.numericUpDownMonth_ValueChanged);
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownDay.Location = new System.Drawing.Point(469, 491);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(46, 26);
            this.numericUpDownDay.TabIndex = 18;
            this.numericUpDownDay.ValueChanged += new System.EventHandler(this.numericUpDownDay_ValueChanged);
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownYear.Location = new System.Drawing.Point(606, 491);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(68, 26);
            this.numericUpDownYear.TabIndex = 19;
            this.numericUpDownYear.Value = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            // 
            // labelMonth
            // 
            this.labelMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(535, 453);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(58, 20);
            this.labelMonth.TabIndex = 20;
            this.labelMonth.Text = "Month:";
            // 
            // labelDay
            // 
            this.labelDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(465, 453);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(41, 20);
            this.labelDay.TabIndex = 21;
            this.labelDay.Text = "Day:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(615, 453);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(47, 20);
            this.labelYear.TabIndex = 22;
            this.labelYear.Text = "Year:";
            // 
            // buttonFilterByDate
            // 
            this.buttonFilterByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFilterByDate.Location = new System.Drawing.Point(680, 475);
            this.buttonFilterByDate.Name = "buttonFilterByDate";
            this.buttonFilterByDate.Size = new System.Drawing.Size(161, 56);
            this.buttonFilterByDate.TabIndex = 23;
            this.buttonFilterByDate.Text = "Filter Posts By Date";
            this.buttonFilterByDate.UseVisualStyleBackColor = true;
            this.buttonFilterByDate.Click += new System.EventHandler(this.buttonFilterByDate_Click);
            // 
            // buttonCancelFilter
            // 
            this.buttonCancelFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancelFilter.Location = new System.Drawing.Point(879, 475);
            this.buttonCancelFilter.Name = "buttonCancelFilter";
            this.buttonCancelFilter.Size = new System.Drawing.Size(161, 56);
            this.buttonCancelFilter.TabIndex = 24;
            this.buttonCancelFilter.Text = "Cancel Filter";
            this.buttonCancelFilter.UseVisualStyleBackColor = true;
            this.buttonCancelFilter.Click += new System.EventHandler(this.buttonCancelFilter_Click);
            // 
            // labelMonthIsZero
            // 
            this.labelMonthIsZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMonthIsZero.AutoSize = true;
            this.labelMonthIsZero.Location = new System.Drawing.Point(523, 534);
            this.labelMonthIsZero.Name = "labelMonthIsZero";
            this.labelMonthIsZero.Size = new System.Drawing.Size(290, 20);
            this.labelMonthIsZero.TabIndex = 25;
            this.labelMonthIsZero.Text = "Month: 0 represents all months in a year";
            // 
            // labelDayIsZero
            // 
            this.labelDayIsZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDayIsZero.AutoSize = true;
            this.labelDayIsZero.Location = new System.Drawing.Point(523, 554);
            this.labelDayIsZero.Name = "labelDayIsZero";
            this.labelDayIsZero.Size = new System.Drawing.Size(268, 20);
            this.labelDayIsZero.TabIndex = 26;
            this.labelDayIsZero.Text = "Day: 0 represents all days in a month";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1223, 112);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(102, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(92, 98);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(146, 103);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 10;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // labelActualNumber
            // 
            this.labelActualNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelActualNumber.AutoSize = true;
            this.labelActualNumber.Location = new System.Drawing.Point(494, 198);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(18, 20);
            this.labelActualNumber.TabIndex = 28;
            this.labelActualNumber.Text = "0";
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Location = new System.Drawing.Point(349, 198);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(130, 20);
            this.labelNumberOfPosts.TabIndex = 27;
            this.labelNumberOfPosts.Text = "Number of posts:";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 609);
            this.Controls.Add(this.labelActualNumber);
            this.Controls.Add(this.labelNumberOfPosts);
            this.Controls.Add(this.labelDayIsZero);
            this.Controls.Add(this.labelMonthIsZero);
            this.Controls.Add(this.buttonCancelFilter);
            this.Controls.Add(this.buttonFilterByDate);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.numericUpDownYear);
            this.Controls.Add(this.numericUpDownDay);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxPost);
            this.Controls.Add(this.labelNewPost);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.headLine);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
            this.Name = "PostsForm";
            this.Text = "Posts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
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
        private System.Windows.Forms.Label labelNewPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.NumericUpDown numericUpDownDay;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonFilterByDate;
        private System.Windows.Forms.Button buttonCancelFilter;
        private System.Windows.Forms.Label labelMonthIsZero;
        private System.Windows.Forms.Label labelDayIsZero;
        private System.Windows.Forms.Label labelActualNumber;
        private System.Windows.Forms.Label labelNumberOfPosts;
    }
}