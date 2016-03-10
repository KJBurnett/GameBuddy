namespace Game_Buddy
{
    partial class AddGame
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
            this.ThirdPartyBrowseButton = new System.Windows.Forms.Button();
            this.ThirdPartyTextBox = new System.Windows.Forms.TextBox();
            this.ThirdPartyLabel = new System.Windows.Forms.Label();
            this.ImageCountLabel = new System.Windows.Forms.Label();
            this.SlideRightButton = new System.Windows.Forms.Button();
            this.SlideLeftButton = new System.Windows.Forms.Button();
            this.IsSteamGameCheckBox = new System.Windows.Forms.CheckBox();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.SummaryTextBox = new System.Windows.Forms.TextBox();
            this.CompletedCheckBox = new System.Windows.Forms.CheckBox();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.BrowseImagesButton = new System.Windows.Forms.Button();
            this.BrowseSaveButton = new System.Windows.Forms.Button();
            this.BrowseExeButton = new System.Windows.Forms.Button();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GameTitleTextBox = new System.Windows.Forms.TextBox();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.IntroductionLabel = new System.Windows.Forms.Label();
            this.ImageLocationTextBox = new System.Windows.Forms.TextBox();
            this.SaveLocationTextBox = new System.Windows.Forms.TextBox();
            this.ExeLocationTextBox = new System.Windows.Forms.TextBox();
            this.SaveLocationLabel = new System.Windows.Forms.Label();
            this.PreviewImageLabel = new System.Windows.Forms.Label();
            this.ExeLabel = new System.Windows.Forms.Label();
            this.TotalCompletionCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThirdPartyBrowseButton
            // 
            this.ThirdPartyBrowseButton.Enabled = false;
            this.ThirdPartyBrowseButton.Location = new System.Drawing.Point(706, 162);
            this.ThirdPartyBrowseButton.Name = "ThirdPartyBrowseButton";
            this.ThirdPartyBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.ThirdPartyBrowseButton.TabIndex = 61;
            this.ThirdPartyBrowseButton.Text = "Browse";
            this.ThirdPartyBrowseButton.UseVisualStyleBackColor = true;
            // 
            // ThirdPartyTextBox
            // 
            this.ThirdPartyTextBox.Enabled = false;
            this.ThirdPartyTextBox.Location = new System.Drawing.Point(518, 162);
            this.ThirdPartyTextBox.Name = "ThirdPartyTextBox";
            this.ThirdPartyTextBox.Size = new System.Drawing.Size(182, 20);
            this.ThirdPartyTextBox.TabIndex = 60;
            // 
            // ThirdPartyLabel
            // 
            this.ThirdPartyLabel.AutoSize = true;
            this.ThirdPartyLabel.Location = new System.Drawing.Point(515, 145);
            this.ThirdPartyLabel.Name = "ThirdPartyLabel";
            this.ThirdPartyLabel.Size = new System.Drawing.Size(262, 13);
            this.ThirdPartyLabel.TabIndex = 59;
            this.ThirdPartyLabel.Text = "Would you like to start a 3rd party app with this game?";
            // 
            // ImageCountLabel
            // 
            this.ImageCountLabel.AutoSize = true;
            this.ImageCountLabel.Location = new System.Drawing.Point(481, 313);
            this.ImageCountLabel.Name = "ImageCountLabel";
            this.ImageCountLabel.Size = new System.Drawing.Size(0, 13);
            this.ImageCountLabel.TabIndex = 58;
            // 
            // SlideRightButton
            // 
            this.SlideRightButton.BackgroundImage = global::Game_Buddy.Properties.Resources.right_arrow;
            this.SlideRightButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideRightButton.Location = new System.Drawing.Point(474, 363);
            this.SlideRightButton.Name = "SlideRightButton";
            this.SlideRightButton.Size = new System.Drawing.Size(41, 67);
            this.SlideRightButton.TabIndex = 57;
            this.SlideRightButton.UseVisualStyleBackColor = true;
            this.SlideRightButton.Click += new System.EventHandler(this.SlideRightButton_Click);
            // 
            // SlideLeftButton
            // 
            this.SlideLeftButton.BackgroundImage = global::Game_Buddy.Properties.Resources.left_arrow;
            this.SlideLeftButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlideLeftButton.Location = new System.Drawing.Point(474, 216);
            this.SlideLeftButton.Name = "SlideLeftButton";
            this.SlideLeftButton.Size = new System.Drawing.Size(41, 67);
            this.SlideLeftButton.TabIndex = 56;
            this.SlideLeftButton.UseVisualStyleBackColor = true;
            this.SlideLeftButton.Click += new System.EventHandler(this.SlideLeftButton_Click);
            // 
            // IsSteamGameCheckBox
            // 
            this.IsSteamGameCheckBox.AutoSize = true;
            this.IsSteamGameCheckBox.Enabled = false;
            this.IsSteamGameCheckBox.Location = new System.Drawing.Point(474, 12);
            this.IsSteamGameCheckBox.Name = "IsSteamGameCheckBox";
            this.IsSteamGameCheckBox.Size = new System.Drawing.Size(129, 17);
            this.IsSteamGameCheckBox.TabIndex = 55;
            this.IsSteamGameCheckBox.Text = "This is a Steam Game";
            this.IsSteamGameCheckBox.UseVisualStyleBackColor = true;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new System.Drawing.Point(515, 197);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(84, 13);
            this.SummaryLabel.TabIndex = 54;
            this.SummaryLabel.Text = "Game Summary:";
            // 
            // SummaryTextBox
            // 
            this.SummaryTextBox.Location = new System.Drawing.Point(515, 216);
            this.SummaryTextBox.Multiline = true;
            this.SummaryTextBox.Name = "SummaryTextBox";
            this.SummaryTextBox.Size = new System.Drawing.Size(266, 185);
            this.SummaryTextBox.TabIndex = 53;
            // 
            // CompletedCheckBox
            // 
            this.CompletedCheckBox.AutoSize = true;
            this.CompletedCheckBox.Location = new System.Drawing.Point(609, 10);
            this.CompletedCheckBox.Name = "CompletedCheckBox";
            this.CompletedCheckBox.Size = new System.Drawing.Size(153, 17);
            this.CompletedCheckBox.TabIndex = 52;
            this.CompletedCheckBox.Text = "Game has been completed";
            this.CompletedCheckBox.UseVisualStyleBackColor = true;
            // 
            // PreviewBox
            // 
            this.PreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreviewBox.Location = new System.Drawing.Point(14, 216);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(460, 215);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewBox.TabIndex = 50;
            this.PreviewBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(706, 407);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 49;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(609, 407);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 48;
            this.OKButton.Text = "Add Game!";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // BrowseImagesButton
            // 
            this.BrowseImagesButton.Location = new System.Drawing.Point(399, 185);
            this.BrowseImagesButton.Name = "BrowseImagesButton";
            this.BrowseImagesButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseImagesButton.TabIndex = 47;
            this.BrowseImagesButton.Text = "Browse";
            this.BrowseImagesButton.UseVisualStyleBackColor = true;
            this.BrowseImagesButton.Click += new System.EventHandler(this.BrowseImagesButton_Click);
            // 
            // BrowseSaveButton
            // 
            this.BrowseSaveButton.Location = new System.Drawing.Point(399, 129);
            this.BrowseSaveButton.Name = "BrowseSaveButton";
            this.BrowseSaveButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseSaveButton.TabIndex = 46;
            this.BrowseSaveButton.Text = "Browse";
            this.BrowseSaveButton.UseVisualStyleBackColor = true;
            this.BrowseSaveButton.Click += new System.EventHandler(this.BrowseSaveButton_Click);
            // 
            // BrowseExeButton
            // 
            this.BrowseExeButton.Location = new System.Drawing.Point(399, 72);
            this.BrowseExeButton.Name = "BrowseExeButton";
            this.BrowseExeButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseExeButton.TabIndex = 45;
            this.BrowseExeButton.Text = "Browse";
            this.BrowseExeButton.UseVisualStyleBackColor = true;
            this.BrowseExeButton.Click += new System.EventHandler(this.BrowseExeButton_Click);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(515, 118);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(266, 20);
            this.GenreTextBox.TabIndex = 44;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(512, 102);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 43;
            this.GenreLabel.Text = "Genre:";
            // 
            // GameTitleTextBox
            // 
            this.GameTitleTextBox.Location = new System.Drawing.Point(515, 74);
            this.GameTitleTextBox.Name = "GameTitleTextBox";
            this.GameTitleTextBox.Size = new System.Drawing.Size(266, 20);
            this.GameTitleTextBox.TabIndex = 42;
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Location = new System.Drawing.Point(512, 58);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(61, 13);
            this.GameTitleLabel.TabIndex = 41;
            this.GameTitleLabel.Text = "Game Title:";
            // 
            // IntroductionLabel
            // 
            this.IntroductionLabel.AutoSize = true;
            this.IntroductionLabel.Location = new System.Drawing.Point(11, 11);
            this.IntroductionLabel.Name = "IntroductionLabel";
            this.IntroductionLabel.Size = new System.Drawing.Size(357, 26);
            this.IntroductionLabel.TabIndex = 40;
            this.IntroductionLabel.Text = "* Any fields not filled will simply be replaced with \"N/A\".\r\n* To add a save loca" +
    "tion, simply locate and select a save file for the game.\r\n";
            // 
            // ImageLocationTextBox
            // 
            this.ImageLocationTextBox.Location = new System.Drawing.Point(14, 187);
            this.ImageLocationTextBox.Name = "ImageLocationTextBox";
            this.ImageLocationTextBox.Size = new System.Drawing.Size(379, 20);
            this.ImageLocationTextBox.TabIndex = 39;
            // 
            // SaveLocationTextBox
            // 
            this.SaveLocationTextBox.Location = new System.Drawing.Point(14, 131);
            this.SaveLocationTextBox.Name = "SaveLocationTextBox";
            this.SaveLocationTextBox.Size = new System.Drawing.Size(379, 20);
            this.SaveLocationTextBox.TabIndex = 38;
            // 
            // ExeLocationTextBox
            // 
            this.ExeLocationTextBox.Location = new System.Drawing.Point(14, 74);
            this.ExeLocationTextBox.Name = "ExeLocationTextBox";
            this.ExeLocationTextBox.Size = new System.Drawing.Size(379, 20);
            this.ExeLocationTextBox.TabIndex = 37;
            // 
            // SaveLocationLabel
            // 
            this.SaveLocationLabel.AutoSize = true;
            this.SaveLocationLabel.Location = new System.Drawing.Point(11, 115);
            this.SaveLocationLabel.Name = "SaveLocationLabel";
            this.SaveLocationLabel.Size = new System.Drawing.Size(111, 13);
            this.SaveLocationLabel.TabIndex = 36;
            this.SaveLocationLabel.Text = "Add A Save Location:";
            // 
            // PreviewImageLabel
            // 
            this.PreviewImageLabel.AutoSize = true;
            this.PreviewImageLabel.Location = new System.Drawing.Point(11, 171);
            this.PreviewImageLabel.Name = "PreviewImageLabel";
            this.PreviewImageLabel.Size = new System.Drawing.Size(112, 13);
            this.PreviewImageLabel.TabIndex = 35;
            this.PreviewImageLabel.Text = "Add A Preview Image:";
            // 
            // ExeLabel
            // 
            this.ExeLabel.AutoSize = true;
            this.ExeLabel.Location = new System.Drawing.Point(11, 58);
            this.ExeLabel.Name = "ExeLabel";
            this.ExeLabel.Size = new System.Drawing.Size(66, 13);
            this.ExeLabel.TabIndex = 34;
            this.ExeLabel.Text = "Add An Exe:";
            // 
            // TotalCompletionCheckBox
            // 
            this.TotalCompletionCheckBox.AutoSize = true;
            this.TotalCompletionCheckBox.Location = new System.Drawing.Point(609, 28);
            this.TotalCompletionCheckBox.Name = "TotalCompletionCheckBox";
            this.TotalCompletionCheckBox.Size = new System.Drawing.Size(160, 17);
            this.TotalCompletionCheckBox.TabIndex = 62;
            this.TotalCompletionCheckBox.Text = "This game is 100% complete";
            this.TotalCompletionCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 441);
            this.Controls.Add(this.TotalCompletionCheckBox);
            this.Controls.Add(this.ThirdPartyBrowseButton);
            this.Controls.Add(this.ThirdPartyTextBox);
            this.Controls.Add(this.ThirdPartyLabel);
            this.Controls.Add(this.ImageCountLabel);
            this.Controls.Add(this.SlideRightButton);
            this.Controls.Add(this.SlideLeftButton);
            this.Controls.Add(this.IsSteamGameCheckBox);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.SummaryTextBox);
            this.Controls.Add(this.CompletedCheckBox);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.BrowseImagesButton);
            this.Controls.Add(this.BrowseSaveButton);
            this.Controls.Add(this.BrowseExeButton);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.GameTitleTextBox);
            this.Controls.Add(this.GameTitleLabel);
            this.Controls.Add(this.IntroductionLabel);
            this.Controls.Add(this.ImageLocationTextBox);
            this.Controls.Add(this.SaveLocationTextBox);
            this.Controls.Add(this.ExeLocationTextBox);
            this.Controls.Add(this.SaveLocationLabel);
            this.Controls.Add(this.PreviewImageLabel);
            this.Controls.Add(this.ExeLabel);
            this.Name = "AddGame";
            this.Text = "AddGame";
            this.Load += new System.EventHandler(this.AddGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ThirdPartyBrowseButton;
        internal System.Windows.Forms.TextBox ThirdPartyTextBox;
        internal System.Windows.Forms.Label ThirdPartyLabel;
        internal System.Windows.Forms.Label ImageCountLabel;
        internal System.Windows.Forms.Button SlideRightButton;
        internal System.Windows.Forms.Button SlideLeftButton;
        internal System.Windows.Forms.CheckBox IsSteamGameCheckBox;
        internal System.Windows.Forms.Label SummaryLabel;
        internal System.Windows.Forms.TextBox SummaryTextBox;
        internal System.Windows.Forms.CheckBox CompletedCheckBox;
        internal System.Windows.Forms.PictureBox PreviewBox;
        internal System.Windows.Forms.Button CloseButton;
        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.Button BrowseImagesButton;
        internal System.Windows.Forms.Button BrowseSaveButton;
        internal System.Windows.Forms.Button BrowseExeButton;
        internal System.Windows.Forms.TextBox GenreTextBox;
        internal System.Windows.Forms.Label GenreLabel;
        internal System.Windows.Forms.TextBox GameTitleTextBox;
        internal System.Windows.Forms.Label GameTitleLabel;
        internal System.Windows.Forms.Label IntroductionLabel;
        internal System.Windows.Forms.TextBox ImageLocationTextBox;
        internal System.Windows.Forms.TextBox SaveLocationTextBox;
        internal System.Windows.Forms.TextBox ExeLocationTextBox;
        internal System.Windows.Forms.Label SaveLocationLabel;
        internal System.Windows.Forms.Label PreviewImageLabel;
        internal System.Windows.Forms.Label ExeLabel;
        private System.Windows.Forms.CheckBox TotalCompletionCheckBox;
    }
}