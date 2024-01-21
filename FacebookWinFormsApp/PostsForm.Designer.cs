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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostsForm));
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
            this.labelHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.Location = new System.Drawing.Point(11, 23);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(110, 27);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNewPost
            // 
            this.labelNewPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewPost.AutoSize = true;
            this.labelNewPost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewPost.Location = new System.Drawing.Point(212, 293);
            this.labelNewPost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewPost.Name = "labelNewPost";
            this.labelNewPost.Size = new System.Drawing.Size(64, 15);
            this.labelNewPost.TabIndex = 13;
            this.labelNewPost.Text = "New Post:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(280, 289);
            this.textBoxPost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(438, 50);
            this.textBoxPost.TabIndex = 14;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Location = new System.Drawing.Point(722, 289);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(71, 50);
            this.buttonPost.TabIndex = 15;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(215, 162);
            this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(578, 121);
            this.listBoxPosts.TabIndex = 16;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownMonth.Location = new System.Drawing.Point(338, 378);
            this.numericUpDownMonth.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(33, 20);
            this.numericUpDownMonth.TabIndex = 17;
            this.numericUpDownMonth.ValueChanged += new System.EventHandler(this.numericUpDownMonth_ValueChanged);
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownDay.Location = new System.Drawing.Point(292, 378);
            this.numericUpDownDay.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericUpDownDay.Name = "numericUpDownDay";
            this.numericUpDownDay.Size = new System.Drawing.Size(31, 20);
            this.numericUpDownDay.TabIndex = 18;
            this.numericUpDownDay.ValueChanged += new System.EventHandler(this.numericUpDownDay_ValueChanged);
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownYear.Location = new System.Drawing.Point(383, 378);
            this.numericUpDownYear.Margin = new System.Windows.Forms.Padding(2);
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
            this.numericUpDownYear.Size = new System.Drawing.Size(45, 20);
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
            this.labelMonth.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMonth.Location = new System.Drawing.Point(336, 353);
            this.labelMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(45, 14);
            this.labelMonth.TabIndex = 20;
            this.labelMonth.Text = "Month:";
            // 
            // labelDay
            // 
            this.labelDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDay.Location = new System.Drawing.Point(289, 353);
            this.labelDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(29, 14);
            this.labelDay.TabIndex = 21;
            this.labelDay.Text = "Day:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelYear.Location = new System.Drawing.Point(389, 353);
            this.labelYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(34, 14);
            this.labelYear.TabIndex = 22;
            this.labelYear.Text = "Year:";
            // 
            // buttonFilterByDate
            // 
            this.buttonFilterByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFilterByDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFilterByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterByDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFilterByDate.Location = new System.Drawing.Point(432, 368);
            this.buttonFilterByDate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFilterByDate.Name = "buttonFilterByDate";
            this.buttonFilterByDate.Size = new System.Drawing.Size(133, 36);
            this.buttonFilterByDate.TabIndex = 23;
            this.buttonFilterByDate.Text = "Filter Posts By Date";
            this.buttonFilterByDate.UseVisualStyleBackColor = false;
            this.buttonFilterByDate.Click += new System.EventHandler(this.buttonFilterByDate_Click);
            // 
            // buttonCancelFilter
            // 
            this.buttonCancelFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCancelFilter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCancelFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelFilter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCancelFilter.Location = new System.Drawing.Point(569, 368);
            this.buttonCancelFilter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelFilter.Name = "buttonCancelFilter";
            this.buttonCancelFilter.Size = new System.Drawing.Size(114, 36);
            this.buttonCancelFilter.TabIndex = 24;
            this.buttonCancelFilter.Text = "Cancel Filter";
            this.buttonCancelFilter.UseVisualStyleBackColor = false;
            this.buttonCancelFilter.Click += new System.EventHandler(this.buttonCancelFilter_Click);
            // 
            // labelMonthIsZero
            // 
            this.labelMonthIsZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMonthIsZero.AutoSize = true;
            this.labelMonthIsZero.Location = new System.Drawing.Point(289, 406);
            this.labelMonthIsZero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMonthIsZero.Name = "labelMonthIsZero";
            this.labelMonthIsZero.Size = new System.Drawing.Size(194, 13);
            this.labelMonthIsZero.TabIndex = 25;
            this.labelMonthIsZero.Text = "Month: 0 represents all months in a year";
            // 
            // labelDayIsZero
            // 
            this.labelDayIsZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDayIsZero.AutoSize = true;
            this.labelDayIsZero.Location = new System.Drawing.Point(289, 419);
            this.labelDayIsZero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDayIsZero.Name = "labelDayIsZero";
            this.labelDayIsZero.Size = new System.Drawing.Size(180, 13);
            this.labelDayIsZero.TabIndex = 26;
            this.labelDayIsZero.Text = "Day: 0 represents all days in a month";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(932, 11);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(68, 69);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(14, 60);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(97, 67);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 10;
            this.pictureBoxProfile.TabStop = false;
            this.pictureBoxProfile.Visible = false;
            // 
            // labelActualNumber
            // 
            this.labelActualNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelActualNumber.AutoSize = true;
            this.labelActualNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelActualNumber.Location = new System.Drawing.Point(329, 144);
            this.labelActualNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(14, 16);
            this.labelActualNumber.TabIndex = 28;
            this.labelActualNumber.Text = "0";
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfPosts.Location = new System.Drawing.Point(212, 144);
            this.labelNumberOfPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(113, 16);
            this.labelNumberOfPosts.TabIndex = 27;
            this.labelNumberOfPosts.Text = "Number of posts:";
            // 
            // labelHeadline
            // 
            this.labelHeadline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHeadline.AutoSize = true;
            this.labelHeadline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.labelHeadline.Font = new System.Drawing.Font("Arial", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelHeadline.ForeColor = System.Drawing.Color.White;
            this.labelHeadline.Location = new System.Drawing.Point(406, 86);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(159, 41);
            this.labelHeadline.TabIndex = 29;
            this.labelHeadline.Text = "Headline";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 457);
            this.Controls.Add(this.labelHeadline);
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
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PostsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.Label labelHeadline;
    }
}