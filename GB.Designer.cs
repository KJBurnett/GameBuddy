namespace Game_Buddy
{
    partial class GB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GB));
            this.CollectivePlayTimeValueLabel = new System.Windows.Forms.Label();
            this.CollectivePlayTimeLabel = new System.Windows.Forms.Label();
            this.CompletedLabel = new System.Windows.Forms.Label();
            this.editGameLabel = new System.Windows.Forms.LinkLabel();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.LastPlayedValueLabel = new System.Windows.Forms.Label();
            this.FirstPlayedValueLabel = new System.Windows.Forms.Label();
            this.LastPlayedLabel = new System.Windows.Forms.Label();
            this.FirstPlayedLabel = new System.Windows.Forms.Label();
            this.TotalTimePlayedValueLabel = new System.Windows.Forms.Label();
            this.GenreValueLabel = new System.Windows.Forms.Label();
            this.NameValueLabel = new System.Windows.Forms.Label();
            this.TotalTimePlayedLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RestoreGamesButton = new System.Windows.Forms.Button();
            this.RestoreCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SlashLabel2 = new System.Windows.Forms.Label();
            this.RestoreModeLink = new System.Windows.Forms.LinkLabel();
            this.ListBoxLabel = new System.Windows.Forms.Label();
            this.GamesListBox = new System.Windows.Forms.ListBox();
            this.SlashLabel1 = new System.Windows.Forms.Label();
            this.BackupModeLink = new System.Windows.Forms.LinkLabel();
            this.GameModeLink = new System.Windows.Forms.LinkLabel();
            this.BackupCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.GalleryButton = new System.Windows.Forms.Button();
            this.PlayGameButton = new System.Windows.Forms.Button();
            this.SummaryValueLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateSteamGamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TOOLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportPlayTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.DateCompletedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.TotalCompletedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CollectivePlayTimeValueLabel
            // 
            this.CollectivePlayTimeValueLabel.AutoSize = true;
            this.CollectivePlayTimeValueLabel.Location = new System.Drawing.Point(547, 32);
            this.CollectivePlayTimeValueLabel.Name = "CollectivePlayTimeValueLabel";
            this.CollectivePlayTimeValueLabel.Size = new System.Drawing.Size(0, 13);
            this.CollectivePlayTimeValueLabel.TabIndex = 69;
            // 
            // CollectivePlayTimeLabel
            // 
            this.CollectivePlayTimeLabel.AutoSize = true;
            this.CollectivePlayTimeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.CollectivePlayTimeLabel.Location = new System.Drawing.Point(427, 32);
            this.CollectivePlayTimeLabel.Name = "CollectivePlayTimeLabel";
            this.CollectivePlayTimeLabel.Size = new System.Drawing.Size(120, 13);
            this.CollectivePlayTimeLabel.TabIndex = 68;
            this.CollectivePlayTimeLabel.Text = "Collective Time Played: ";
            // 
            // CompletedLabel
            // 
            this.CompletedLabel.AutoSize = true;
            this.CompletedLabel.ForeColor = System.Drawing.Color.Red;
            this.CompletedLabel.Location = new System.Drawing.Point(354, 421);
            this.CompletedLabel.Name = "CompletedLabel";
            this.CompletedLabel.Size = new System.Drawing.Size(77, 13);
            this.CompletedLabel.TabIndex = 67;
            this.CompletedLabel.Text = "Not Completed";
            this.CompletedLabel.Visible = false;
            // 
            // editGameLabel
            // 
            this.editGameLabel.AutoSize = true;
            this.editGameLabel.Location = new System.Drawing.Point(219, 420);
            this.editGameLabel.Name = "editGameLabel";
            this.editGameLabel.Size = new System.Drawing.Size(107, 13);
            this.editGameLabel.TabIndex = 66;
            this.editGameLabel.TabStop = true;
            this.editGameLabel.Text = "edit game information";
            this.editGameLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editGameLabel_LinkClicked);
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new System.Drawing.Point(219, 331);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(56, 13);
            this.SummaryLabel.TabIndex = 65;
            this.SummaryLabel.Text = "Summary: ";
            // 
            // LastPlayedValueLabel
            // 
            this.LastPlayedValueLabel.AutoSize = true;
            this.LastPlayedValueLabel.Location = new System.Drawing.Point(564, 383);
            this.LastPlayedValueLabel.Name = "LastPlayedValueLabel";
            this.LastPlayedValueLabel.Size = new System.Drawing.Size(0, 13);
            this.LastPlayedValueLabel.TabIndex = 63;
            // 
            // FirstPlayedValueLabel
            // 
            this.FirstPlayedValueLabel.AutoSize = true;
            this.FirstPlayedValueLabel.Location = new System.Drawing.Point(564, 344);
            this.FirstPlayedValueLabel.Name = "FirstPlayedValueLabel";
            this.FirstPlayedValueLabel.Size = new System.Drawing.Size(0, 13);
            this.FirstPlayedValueLabel.TabIndex = 62;
            // 
            // LastPlayedLabel
            // 
            this.LastPlayedLabel.AutoSize = true;
            this.LastPlayedLabel.Location = new System.Drawing.Point(564, 370);
            this.LastPlayedLabel.Name = "LastPlayedLabel";
            this.LastPlayedLabel.Size = new System.Drawing.Size(68, 13);
            this.LastPlayedLabel.TabIndex = 61;
            this.LastPlayedLabel.Text = "Last Played: ";
            // 
            // FirstPlayedLabel
            // 
            this.FirstPlayedLabel.AutoSize = true;
            this.FirstPlayedLabel.Location = new System.Drawing.Point(564, 331);
            this.FirstPlayedLabel.Name = "FirstPlayedLabel";
            this.FirstPlayedLabel.Size = new System.Drawing.Size(67, 13);
            this.FirstPlayedLabel.TabIndex = 60;
            this.FirstPlayedLabel.Text = "First Played: ";
            // 
            // TotalTimePlayedValueLabel
            // 
            this.TotalTimePlayedValueLabel.AutoSize = true;
            this.TotalTimePlayedValueLabel.Location = new System.Drawing.Point(564, 305);
            this.TotalTimePlayedValueLabel.Name = "TotalTimePlayedValueLabel";
            this.TotalTimePlayedValueLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalTimePlayedValueLabel.TabIndex = 59;
            // 
            // GenreValueLabel
            // 
            this.GenreValueLabel.AutoSize = true;
            this.GenreValueLabel.Location = new System.Drawing.Point(567, 421);
            this.GenreValueLabel.Name = "GenreValueLabel";
            this.GenreValueLabel.Size = new System.Drawing.Size(0, 13);
            this.GenreValueLabel.TabIndex = 58;
            // 
            // NameValueLabel
            // 
            this.NameValueLabel.AutoSize = true;
            this.NameValueLabel.Location = new System.Drawing.Point(219, 305);
            this.NameValueLabel.Name = "NameValueLabel";
            this.NameValueLabel.Size = new System.Drawing.Size(0, 13);
            this.NameValueLabel.TabIndex = 57;
            // 
            // TotalTimePlayedLabel
            // 
            this.TotalTimePlayedLabel.AutoSize = true;
            this.TotalTimePlayedLabel.Location = new System.Drawing.Point(564, 292);
            this.TotalTimePlayedLabel.Name = "TotalTimePlayedLabel";
            this.TotalTimePlayedLabel.Size = new System.Drawing.Size(95, 13);
            this.TotalTimePlayedLabel.TabIndex = 56;
            this.TotalTimePlayedLabel.Text = "Total Time Played:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(564, 404);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(42, 13);
            this.GenreLabel.TabIndex = 55;
            this.GenreLabel.Text = "Genre: ";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(219, 292);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 54;
            this.NameLabel.Text = "Name:";
            // 
            // RestoreGamesButton
            // 
            this.RestoreGamesButton.Location = new System.Drawing.Point(15, 391);
            this.RestoreGamesButton.Name = "RestoreGamesButton";
            this.RestoreGamesButton.Size = new System.Drawing.Size(193, 23);
            this.RestoreGamesButton.TabIndex = 53;
            this.RestoreGamesButton.Text = "Restore Games";
            this.RestoreGamesButton.UseVisualStyleBackColor = true;
            this.RestoreGamesButton.Visible = false;
            this.RestoreGamesButton.Click += new System.EventHandler(this.RestoreGamesButton_Click);
            // 
            // RestoreCheckedListBox
            // 
            this.RestoreCheckedListBox.FormattingEnabled = true;
            this.RestoreCheckedListBox.Location = new System.Drawing.Point(15, 81);
            this.RestoreCheckedListBox.Name = "RestoreCheckedListBox";
            this.RestoreCheckedListBox.Size = new System.Drawing.Size(193, 289);
            this.RestoreCheckedListBox.TabIndex = 52;
            this.RestoreCheckedListBox.Visible = false;
            this.RestoreCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.RestoreCheckedListBox_SelectedIndexChanged);
            // 
            // SlashLabel2
            // 
            this.SlashLabel2.AutoSize = true;
            this.SlashLabel2.Location = new System.Drawing.Point(164, 32);
            this.SlashLabel2.Name = "SlashLabel2";
            this.SlashLabel2.Size = new System.Drawing.Size(15, 13);
            this.SlashLabel2.TabIndex = 51;
            this.SlashLabel2.Text = "  |";
            // 
            // RestoreModeLink
            // 
            this.RestoreModeLink.AutoSize = true;
            this.RestoreModeLink.Location = new System.Drawing.Point(182, 32);
            this.RestoreModeLink.Name = "RestoreModeLink";
            this.RestoreModeLink.Size = new System.Drawing.Size(74, 13);
            this.RestoreModeLink.TabIndex = 50;
            this.RestoreModeLink.TabStop = true;
            this.RestoreModeLink.Text = "Restore Mode";
            this.RestoreModeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RestoreModeLink_LinkClicked);
            // 
            // ListBoxLabel
            // 
            this.ListBoxLabel.AutoSize = true;
            this.ListBoxLabel.Location = new System.Drawing.Point(50, 65);
            this.ListBoxLabel.Name = "ListBoxLabel";
            this.ListBoxLabel.Size = new System.Drawing.Size(106, 13);
            this.ListBoxLabel.TabIndex = 49;
            this.ListBoxLabel.Text = "Available To Backup";
            // 
            // GamesListBox
            // 
            this.GamesListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GamesListBox.FormattingEnabled = true;
            this.GamesListBox.Location = new System.Drawing.Point(15, 81);
            this.GamesListBox.Name = "GamesListBox";
            this.GamesListBox.Size = new System.Drawing.Size(193, 316);
            this.GamesListBox.Sorted = true;
            this.GamesListBox.TabIndex = 48;
            this.GamesListBox.SelectedIndexChanged += new System.EventHandler(this.GamesListBox_SelectedIndexChanged);
            // 
            // SlashLabel1
            // 
            this.SlashLabel1.AutoSize = true;
            this.SlashLabel1.Location = new System.Drawing.Point(78, 32);
            this.SlashLabel1.Name = "SlashLabel1";
            this.SlashLabel1.Size = new System.Drawing.Size(12, 13);
            this.SlashLabel1.TabIndex = 47;
            this.SlashLabel1.Text = " |";
            // 
            // BackupModeLink
            // 
            this.BackupModeLink.AutoSize = true;
            this.BackupModeLink.Location = new System.Drawing.Point(93, 32);
            this.BackupModeLink.Name = "BackupModeLink";
            this.BackupModeLink.Size = new System.Drawing.Size(74, 13);
            this.BackupModeLink.TabIndex = 46;
            this.BackupModeLink.TabStop = true;
            this.BackupModeLink.Text = "Backup Mode";
            this.BackupModeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackupModeLink_LinkClicked);
            // 
            // GameModeLink
            // 
            this.GameModeLink.AutoSize = true;
            this.GameModeLink.Location = new System.Drawing.Point(12, 32);
            this.GameModeLink.Name = "GameModeLink";
            this.GameModeLink.Size = new System.Drawing.Size(65, 13);
            this.GameModeLink.TabIndex = 45;
            this.GameModeLink.TabStop = true;
            this.GameModeLink.Text = "Game Mode";
            this.GameModeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GameModeLink_LinkClicked);
            // 
            // BackupCheckedListBox
            // 
            this.BackupCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BackupCheckedListBox.FormattingEnabled = true;
            this.BackupCheckedListBox.Location = new System.Drawing.Point(15, 81);
            this.BackupCheckedListBox.Name = "BackupCheckedListBox";
            this.BackupCheckedListBox.Size = new System.Drawing.Size(193, 289);
            this.BackupCheckedListBox.Sorted = true;
            this.BackupCheckedListBox.TabIndex = 36;
            this.BackupCheckedListBox.Visible = false;
            this.BackupCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.BackupCheckedListBox_SelectedIndexChanged);
            // 
            // GalleryButton
            // 
            this.GalleryButton.Location = new System.Drawing.Point(15, 407);
            this.GalleryButton.Name = "GalleryButton";
            this.GalleryButton.Size = new System.Drawing.Size(92, 23);
            this.GalleryButton.TabIndex = 44;
            this.GalleryButton.Text = "Gallery";
            this.GalleryButton.UseVisualStyleBackColor = true;
            this.GalleryButton.Visible = false;
            // 
            // PlayGameButton
            // 
            this.PlayGameButton.Location = new System.Drawing.Point(12, 407);
            this.PlayGameButton.Name = "PlayGameButton";
            this.PlayGameButton.Size = new System.Drawing.Size(196, 23);
            this.PlayGameButton.TabIndex = 43;
            this.PlayGameButton.Text = "Play Game!";
            this.PlayGameButton.UseVisualStyleBackColor = true;
            this.PlayGameButton.Click += new System.EventHandler(this.PlayGameButton_Click);
            // 
            // SummaryValueLabel
            // 
            this.SummaryValueLabel.AutoSize = true;
            this.SummaryValueLabel.Location = new System.Drawing.Point(219, 344);
            this.SummaryValueLabel.MaximumSize = new System.Drawing.Size(330, 0);
            this.SummaryValueLabel.Name = "SummaryValueLabel";
            this.SummaryValueLabel.Size = new System.Drawing.Size(195, 26);
            this.SummaryValueLabel.TabIndex = 42;
            this.SummaryValueLabel.Text = "Welcome to your game buddy. to begin,\r\nselect a game.";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(12, 407);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 41;
            this.ClearAllButton.Text = "Clear All";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Visible = false;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(12, 376);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(75, 24);
            this.SelectAllButton.TabIndex = 40;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Visible = false;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // PreviewBox
            // 
            this.PreviewBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewBox.Location = new System.Drawing.Point(222, 65);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(460, 215);
            this.PreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewBox.TabIndex = 38;
            this.PreviewBox.TabStop = false;
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Location = new System.Drawing.Point(96, 391);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(112, 23);
            this.SaveGameButton.TabIndex = 37;
            this.SaveGameButton.Text = "Save Games";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Visible = false;
            this.SaveGameButton.Click += new System.EventHandler(this.SaveGameButton_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EDITToolStripMenuItem,
            this.TOOLSToolStripMenuItem,
            this.HELPToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(694, 24);
            this.MenuStrip.TabIndex = 39;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddGameToolStripMenuItem,
            this.RefreshListsToolStripMenuItem,
            this.UpdateSteamGamesToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.FileToolStripMenuItem.Text = "FILE";
            // 
            // AddGameToolStripMenuItem
            // 
            this.AddGameToolStripMenuItem.Name = "AddGameToolStripMenuItem";
            this.AddGameToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.AddGameToolStripMenuItem.Text = "Add Game";
            this.AddGameToolStripMenuItem.Click += new System.EventHandler(this.AddGameToolStripMenuItem_Click);
            // 
            // RefreshListsToolStripMenuItem
            // 
            this.RefreshListsToolStripMenuItem.Name = "RefreshListsToolStripMenuItem";
            this.RefreshListsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.RefreshListsToolStripMenuItem.Text = "Refresh Lists";
            // 
            // UpdateSteamGamesToolStripMenuItem
            // 
            this.UpdateSteamGamesToolStripMenuItem.Name = "UpdateSteamGamesToolStripMenuItem";
            this.UpdateSteamGamesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.UpdateSteamGamesToolStripMenuItem.Text = "Update Steam Games";
            this.UpdateSteamGamesToolStripMenuItem.Click += new System.EventHandler(this.UpdateSteamGamesToolStripMenuItem_Click);
            // 
            // EDITToolStripMenuItem
            // 
            this.EDITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreferencesToolStripMenuItem});
            this.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem";
            this.EDITToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.EDITToolStripMenuItem.Text = "EDIT";
            // 
            // PreferencesToolStripMenuItem
            // 
            this.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem";
            this.PreferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.PreferencesToolStripMenuItem.Text = "Preferences";
            this.PreferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItem_Click);
            // 
            // TOOLSToolStripMenuItem
            // 
            this.TOOLSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportPlayTimeToolStripMenuItem});
            this.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem";
            this.TOOLSToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.TOOLSToolStripMenuItem.Text = "TOOLS";
            // 
            // ExportPlayTimeToolStripMenuItem
            // 
            this.ExportPlayTimeToolStripMenuItem.Name = "ExportPlayTimeToolStripMenuItem";
            this.ExportPlayTimeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.ExportPlayTimeToolStripMenuItem.Text = "Export Play Time";
            // 
            // HELPToolStripMenuItem
            // 
            this.HELPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem,
            this.SendFeedbackToolStripMenuItem});
            this.HELPToolStripMenuItem.Name = "HELPToolStripMenuItem";
            this.HELPToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.HELPToolStripMenuItem.Text = "HELP";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // SendFeedbackToolStripMenuItem
            // 
            this.SendFeedbackToolStripMenuItem.Name = "SendFeedbackToolStripMenuItem";
            this.SendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.SendFeedbackToolStripMenuItem.Text = "Send Feedback";
            this.SendFeedbackToolStripMenuItem.Click += new System.EventHandler(this.SendFeedbackToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.DateCompletedToolStripLabel,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.TotalCompletedToolStripLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 441);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 70;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 22);
            this.toolStripLabel1.Text = "Completed on";
            // 
            // DateCompletedToolStripLabel
            // 
            this.DateCompletedToolStripLabel.Name = "DateCompletedToolStripLabel";
            this.DateCompletedToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.DateCompletedToolStripLabel.Text = "N/A";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel3.Text = "100% Completed on";
            // 
            // TotalCompletedToolStripLabel
            // 
            this.TotalCompletedToolStripLabel.Name = "TotalCompletedToolStripLabel";
            this.TotalCompletedToolStripLabel.Size = new System.Drawing.Size(29, 22);
            this.TotalCompletedToolStripLabel.Text = "N/A";
            // 
            // GB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 466);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.CollectivePlayTimeValueLabel);
            this.Controls.Add(this.CollectivePlayTimeLabel);
            this.Controls.Add(this.CompletedLabel);
            this.Controls.Add(this.editGameLabel);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.LastPlayedValueLabel);
            this.Controls.Add(this.FirstPlayedValueLabel);
            this.Controls.Add(this.LastPlayedLabel);
            this.Controls.Add(this.FirstPlayedLabel);
            this.Controls.Add(this.TotalTimePlayedValueLabel);
            this.Controls.Add(this.GenreValueLabel);
            this.Controls.Add(this.NameValueLabel);
            this.Controls.Add(this.TotalTimePlayedLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RestoreGamesButton);
            this.Controls.Add(this.RestoreCheckedListBox);
            this.Controls.Add(this.SlashLabel2);
            this.Controls.Add(this.RestoreModeLink);
            this.Controls.Add(this.ListBoxLabel);
            this.Controls.Add(this.GamesListBox);
            this.Controls.Add(this.SlashLabel1);
            this.Controls.Add(this.BackupModeLink);
            this.Controls.Add(this.GameModeLink);
            this.Controls.Add(this.BackupCheckedListBox);
            this.Controls.Add(this.GalleryButton);
            this.Controls.Add(this.PlayGameButton);
            this.Controls.Add(this.SummaryValueLabel);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GB";
            this.Text = "Game Buddy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GB_FormClosing);
            this.Load += new System.EventHandler(this.GB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label CollectivePlayTimeValueLabel;
        internal System.Windows.Forms.Label CollectivePlayTimeLabel;
        internal System.Windows.Forms.Label CompletedLabel;
        internal System.Windows.Forms.LinkLabel editGameLabel;
        internal System.Windows.Forms.Label SummaryLabel;
        internal System.Windows.Forms.Label LastPlayedValueLabel;
        internal System.Windows.Forms.Label FirstPlayedValueLabel;
        internal System.Windows.Forms.Label LastPlayedLabel;
        internal System.Windows.Forms.Label FirstPlayedLabel;
        internal System.Windows.Forms.Label TotalTimePlayedValueLabel;
        internal System.Windows.Forms.Label GenreValueLabel;
        internal System.Windows.Forms.Label NameValueLabel;
        internal System.Windows.Forms.Label TotalTimePlayedLabel;
        internal System.Windows.Forms.Label GenreLabel;
        internal System.Windows.Forms.Label NameLabel;
        internal System.Windows.Forms.Button RestoreGamesButton;
        internal System.Windows.Forms.CheckedListBox RestoreCheckedListBox;
        internal System.Windows.Forms.Label SlashLabel2;
        internal System.Windows.Forms.LinkLabel RestoreModeLink;
        internal System.Windows.Forms.Label ListBoxLabel;
        internal System.Windows.Forms.ListBox GamesListBox;
        internal System.Windows.Forms.Label SlashLabel1;
        internal System.Windows.Forms.LinkLabel BackupModeLink;
        internal System.Windows.Forms.LinkLabel GameModeLink;
        internal System.Windows.Forms.CheckedListBox BackupCheckedListBox;
        internal System.Windows.Forms.Button GalleryButton;
        internal System.Windows.Forms.Button PlayGameButton;
        internal System.Windows.Forms.Label SummaryValueLabel;
        internal System.Windows.Forms.Button ClearAllButton;
        internal System.Windows.Forms.Button SelectAllButton;
        internal System.Windows.Forms.PictureBox PreviewBox;
        internal System.Windows.Forms.Button SaveGameButton;
        internal System.Windows.Forms.MenuStrip MenuStrip;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AddGameToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem RefreshListsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem UpdateSteamGamesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EDITToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem PreferencesToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TOOLSToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExportPlayTimeToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem HELPToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem SendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel DateCompletedToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel TotalCompletedToolStripLabel;
    }
}

