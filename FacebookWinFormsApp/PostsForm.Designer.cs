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
            this.buttonSaveDate = new System.Windows.Forms.Button();
            this.textBoxDateToSave = new System.Windows.Forms.TextBox();
            this.comboBoxSavedDates = new System.Windows.Forms.ComboBox();
            this.buttonDeleteDate = new System.Windows.Forms.Button();
            this.labelSavedDates = new System.Windows.Forms.Label();
            this.buttonOlderPosts = new System.Windows.Forms.Button();
            this.labelLoading = new System.Windows.Forms.Label();
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
            this.labelName.Location = new System.Drawing.Point(16, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(165, 42);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNewPost
            // 
            this.labelNewPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNewPost.AutoSize = true;
            this.labelNewPost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNewPost.Location = new System.Drawing.Point(318, 451);
            this.labelNewPost.Name = "labelNewPost";
            this.labelNewPost.Size = new System.Drawing.Size(100, 21);
            this.labelNewPost.TabIndex = 13;
            this.labelNewPost.Text = "New Post:";
            // 
            // textBoxPost
            // 
            this.textBoxPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxPost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(420, 445);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(655, 75);
            this.textBoxPost.TabIndex = 14;
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonPost.Location = new System.Drawing.Point(1083, 445);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(106, 77);
            this.buttonPost.TabIndex = 15;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.Click += new System.EventHandler(this.buttonPost_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxPosts.BackColor = System.Drawing.SystemColors.Menu;
            this.listBoxPosts.DisplayMember = "Caption";
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 20;
            this.listBoxPosts.Location = new System.Drawing.Point(322, 249);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(865, 184);
            this.listBoxPosts.TabIndex = 16;
            this.listBoxPosts.ValueMember = "Caption";
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownMonth.Location = new System.Drawing.Point(279, 583);
            this.numericUpDownMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownMonth.TabIndex = 17;
            this.numericUpDownMonth.ValueChanged += new System.EventHandler(this.numericUpDownMonth_ValueChanged);
            // 
            // numericUpDownDay
            // 
            this.numericUpDownDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownDay.Location = new System.Drawing.Point(210, 583);
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
            this.numericUpDownYear.Location = new System.Drawing.Point(346, 583);
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
            this.labelMonth.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMonth.Location = new System.Drawing.Point(276, 544);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(64, 19);
            this.labelMonth.TabIndex = 20;
            this.labelMonth.Text = "Month:";
            // 
            // labelDay
            // 
            this.labelDay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDay.Location = new System.Drawing.Point(206, 544);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(45, 19);
            this.labelDay.TabIndex = 21;
            this.labelDay.Text = "Day:";
            // 
            // labelYear
            // 
            this.labelYear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelYear.Location = new System.Drawing.Point(356, 544);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(49, 19);
            this.labelYear.TabIndex = 22;
            this.labelYear.Text = "Year:";
            // 
            // buttonFilterByDate
            // 
            this.buttonFilterByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFilterByDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonFilterByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterByDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonFilterByDate.Location = new System.Drawing.Point(420, 567);
            this.buttonFilterByDate.Name = "buttonFilterByDate";
            this.buttonFilterByDate.Size = new System.Drawing.Size(200, 55);
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
            this.buttonCancelFilter.Location = new System.Drawing.Point(626, 567);
            this.buttonCancelFilter.Name = "buttonCancelFilter";
            this.buttonCancelFilter.Size = new System.Drawing.Size(171, 55);
            this.buttonCancelFilter.TabIndex = 24;
            this.buttonCancelFilter.Text = "Cancel Filter";
            this.buttonCancelFilter.UseVisualStyleBackColor = false;
            this.buttonCancelFilter.Click += new System.EventHandler(this.buttonCancelFilter_Click);
            // 
            // labelMonthIsZero
            // 
            this.labelMonthIsZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMonthIsZero.AutoSize = true;
            this.labelMonthIsZero.Location = new System.Drawing.Point(124, 628);
            this.labelMonthIsZero.Name = "labelMonthIsZero";
            this.labelMonthIsZero.Size = new System.Drawing.Size(290, 20);
            this.labelMonthIsZero.TabIndex = 25;
            this.labelMonthIsZero.Text = "Month: 0 represents all months in a year";
            // 
            // labelDayIsZero
            // 
            this.labelDayIsZero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDayIsZero.AutoSize = true;
            this.labelDayIsZero.Location = new System.Drawing.Point(124, 648);
            this.labelDayIsZero.Name = "labelDayIsZero";
            this.labelDayIsZero.Size = new System.Drawing.Size(268, 20);
            this.labelDayIsZero.TabIndex = 26;
            this.labelDayIsZero.Text = "Day: 0 represents all days in a month";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLogo.Image = global::BasicFacebookFeatures.Properties.Resources.Facebook_Logo_20231;
            this.pictureBoxLogo.Location = new System.Drawing.Point(1398, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(102, 106);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 12;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(21, 92);
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
            this.labelActualNumber.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelActualNumber.Location = new System.Drawing.Point(494, 222);
            this.labelActualNumber.Name = "labelActualNumber";
            this.labelActualNumber.Size = new System.Drawing.Size(21, 24);
            this.labelActualNumber.TabIndex = 28;
            this.labelActualNumber.Text = "0";
            // 
            // labelNumberOfPosts
            // 
            this.labelNumberOfPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNumberOfPosts.AutoSize = true;
            this.labelNumberOfPosts.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumberOfPosts.Location = new System.Drawing.Point(318, 222);
            this.labelNumberOfPosts.Name = "labelNumberOfPosts";
            this.labelNumberOfPosts.Size = new System.Drawing.Size(175, 24);
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
            this.labelHeadline.Location = new System.Drawing.Point(609, 132);
            this.labelHeadline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeadline.Name = "labelHeadline";
            this.labelHeadline.Size = new System.Drawing.Size(246, 62);
            this.labelHeadline.TabIndex = 29;
            this.labelHeadline.Text = "Headline";
            // 
            // buttonSaveDate
            // 
            this.buttonSaveDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSaveDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSaveDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSaveDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSaveDate.Location = new System.Drawing.Point(1116, 567);
            this.buttonSaveDate.Name = "buttonSaveDate";
            this.buttonSaveDate.Size = new System.Drawing.Size(171, 55);
            this.buttonSaveDate.TabIndex = 30;
            this.buttonSaveDate.Text = "Save Date";
            this.buttonSaveDate.UseVisualStyleBackColor = false;
            this.buttonSaveDate.Click += new System.EventHandler(this.buttonSaveDate_Click);
            // 
            // textBoxDateToSave
            // 
            this.textBoxDateToSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxDateToSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDateToSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateToSave.Location = new System.Drawing.Point(841, 578);
            this.textBoxDateToSave.Multiline = true;
            this.textBoxDateToSave.Name = "textBoxDateToSave";
            this.textBoxDateToSave.Size = new System.Drawing.Size(269, 31);
            this.textBoxDateToSave.TabIndex = 31;
            // 
            // comboBoxSavedDates
            // 
            this.comboBoxSavedDates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBoxSavedDates.FormattingEnabled = true;
            this.comboBoxSavedDates.Location = new System.Drawing.Point(21, 304);
            this.comboBoxSavedDates.Name = "comboBoxSavedDates";
            this.comboBoxSavedDates.Size = new System.Drawing.Size(243, 28);
            this.comboBoxSavedDates.TabIndex = 32;
            this.comboBoxSavedDates.Text = "Select Date";
            this.comboBoxSavedDates.SelectedIndexChanged += new System.EventHandler(this.comboBoxSavedDates_SelectedIndexChanged);
            // 
            // buttonDeleteDate
            // 
            this.buttonDeleteDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDeleteDate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDeleteDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDeleteDate.Location = new System.Drawing.Point(1116, 628);
            this.buttonDeleteDate.Name = "buttonDeleteDate";
            this.buttonDeleteDate.Size = new System.Drawing.Size(171, 55);
            this.buttonDeleteDate.TabIndex = 33;
            this.buttonDeleteDate.Text = "Delete Date";
            this.buttonDeleteDate.UseVisualStyleBackColor = false;
            this.buttonDeleteDate.Click += new System.EventHandler(this.buttonDeleteDate_Click);
            // 
            // labelSavedDates
            // 
            this.labelSavedDates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSavedDates.AutoSize = true;
            this.labelSavedDates.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelSavedDates.Location = new System.Drawing.Point(74, 282);
            this.labelSavedDates.Name = "labelSavedDates";
            this.labelSavedDates.Size = new System.Drawing.Size(107, 19);
            this.labelSavedDates.TabIndex = 34;
            this.labelSavedDates.Text = "Saved Dates";
            // 
            // buttonOlderPosts
            // 
            this.buttonOlderPosts.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonOlderPosts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonOlderPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOlderPosts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonOlderPosts.Location = new System.Drawing.Point(420, 628);
            this.buttonOlderPosts.Name = "buttonOlderPosts";
            this.buttonOlderPosts.Size = new System.Drawing.Size(200, 55);
            this.buttonOlderPosts.TabIndex = 35;
            this.buttonOlderPosts.Text = "Show Older Posts";
            this.buttonOlderPosts.UseVisualStyleBackColor = false;
            this.buttonOlderPosts.Click += new System.EventHandler(this.buttonOlderPosts_Click);
            // 
            // labelLoading
            // 
            this.labelLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoading.Location = new System.Drawing.Point(644, 323);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(178, 44);
            this.labelLoading.TabIndex = 36;
            this.labelLoading.Text = "Loading...";
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1516, 703);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.buttonOlderPosts);
            this.Controls.Add(this.labelSavedDates);
            this.Controls.Add(this.buttonDeleteDate);
            this.Controls.Add(this.comboBoxSavedDates);
            this.Controls.Add(this.textBoxDateToSave);
            this.Controls.Add(this.buttonSaveDate);
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
        private System.Windows.Forms.Button buttonSaveDate;
        private System.Windows.Forms.TextBox textBoxDateToSave;
        private System.Windows.Forms.ComboBox comboBoxSavedDates;
        private System.Windows.Forms.Button buttonDeleteDate;
        private System.Windows.Forms.Label labelSavedDates;
        private System.Windows.Forms.Button buttonOlderPosts;
        private System.Windows.Forms.Label labelLoading;
    }
}