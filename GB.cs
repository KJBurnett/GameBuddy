using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Buddy
{
    public partial class GB : Form
    {
        public GB()
        {
            InitializeComponent();
        }

        private string selectedGame = "";
        private List<Game> games = new List<Game>();
        private List<ImageHolder> imageHolders = new List<ImageHolder>();

        private DateTime startDateTime;
        private DateTime endDateTime;

        private void GB_Load(object sender, EventArgs e)
        {
            FirstTimeCheck();
            Startup();
        }

        private void FirstTimeCheck()
        {
            // Necessary folder and file creation.
            string[] folders = { "Backup", "Error Logs", "Images", "Screenshots", "Summaries" };
            string[] files   = { "Games.csv", "Preferences.txt", "Startup.txt", "SteamID.txt" };

            foreach (string folder in folders)
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

            foreach (string file in files)
                if (!File.Exists(file))
                    File.Create(file);
        }

        private void Startup()
        {
            GamesListBox.Select();
            CreateGameList();
            CreateImageHolderList();
            LoadLastPlayedGame();
            GameModeLink.LinkColor = Color.Red;
        }

        public string GetSelectedGame()
        {
            return selectedGame;
        }

        public Game GetCurrentGame()
        {
            foreach (Game game in games)
                if (game.name == selectedGame)
                    return game;
            return null;
        }

        public void SetSelectedGame(string name)
        {
            selectedGame = name;
        }

        public void SetCurrentGame(Game game)
        {
            for (int x = 0; x < games.Count; x++)
                if (games[x].name == game.name)
                {
                    games[x] = game;
                    return;
                }
        }

        private void LoadLastPlayedGame()
        {
            string startGame = File.ReadAllText("Startup.txt");
            selectedGame = startGame;
            GamesListBox.SelectedItem = selectedGame;
        }

        #region Game Creation

        private void CreateImageHolderList()
        {
            string name;
            string currentImage;
            string totalImages;

            string line;
            string[] row;
            ImageHolder imageHolder;

            // Open the ImageHolder list file.
            StreamReader sr = new StreamReader("images/ImageHolder.csv");

            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(',');

                // -- Variable Input --
                name = row[0];
                currentImage = row[1];
                totalImages = row[2];
                imageHolder = new ImageHolder(name, currentImage, totalImages);
                imageHolders.Add(imageHolder);
            }

            // Sort the ImageHolders in their list by name.
            imageHolders.Sort(new ImageHolderComp());
        }

        private void CreateGameList()
        {
            string name;
            string gameLocation;
            string saveLocation;
            string genre;
            string playTime;
            string steamPlayTime;
            string firstPlayed;
            string lastPlayed;
            string dateCompleted;
            string timeToComplete;
            string date100PercentCompleted;
            string timeTo100Percent;

            string line;
            string[] row;
            Game game;

            // Open the game list file.
            StreamReader sr = new StreamReader("Games.csv");

            // Read in and dispose of header row.
            //line = sr.ReadLine();

            // Clear any duplicates in the game listbox.
            GamesListBox.Items.Clear();

            while ((line = sr.ReadLine()) != null)
            {
                row = line.Split(',');

                // -- Variable Input --
                name = row[0];
                gameLocation = row[1];
                saveLocation = row[2];
                genre = row[3];
                playTime = row[4];
                steamPlayTime = row[5];
                firstPlayed = row[6];
                lastPlayed = row[7];
                dateCompleted = row[8];
                timeToComplete = row[9];

                if (row.Length < 11)
                    date100PercentCompleted = "N/A";
                else
                    date100PercentCompleted = row[10];

                if (row.Length < 12)
                    timeTo100Percent = "N/A";
                else
                    timeTo100Percent = row[11];
                

                game = new Game(name, gameLocation, saveLocation, genre, playTime, 
                    steamPlayTime, firstPlayed, lastPlayed, dateCompleted, timeToComplete, date100PercentCompleted, timeTo100Percent);

                games.Add(game);
            } // End While

            // Sort the games in their list by name.
            games.Sort(new GameComp());

            // Populate GamesListBox, BackupCheckedListBox, and RestoreCheckedListBox
            // with the now ordered games.
            foreach (Game gameToAdd in games)
            {
                GamesListBox.Items.Add(gameToAdd.name);

                if (gameToAdd.saveLocation != "N/A" && Directory.Exists(gameToAdd.saveLocation))
                    BackupCheckedListBox.Items.Add(gameToAdd.name);
            }
            UpdateRestoreList();

            sr.Close();
        }
        #endregion

        public void ChangeCurrentGame()
        {
            selectedGame = GamesListBox.SelectedItem.ToString();
            UpdateLabels();
            UpdateImages();
        }

        #region Updates
        private void UpdateLabels()
        {
            string summaryPath = "./summaries/" + selectedGame.ToLower() + ".txt";
            if (File.Exists(summaryPath))
                SummaryValueLabel.Text = File.ReadAllText(summaryPath);
            else
                SummaryValueLabel.Text = "";

            foreach (Game game in games)
            {
                if (game.name == selectedGame)
                {
                    NameValueLabel.Text = game.name;
                    SetTotalPlayTime(game);
                    FirstPlayedValueLabel.Text = game.firstPlayed;
                    SetLastPlayedTime();
                    GenreValueLabel.Text = game.genre;

                    DateCompletedToolStripLabel.Text = game.dateCompleted + " in " + game.timeToComplete;

                    if (game.name.ToLower().Contains("minecraft"))
                        CompletedLabel.Text = "NEVER";
                }
            }
            SetCollectivePlayTime(games);
        }

        delegate void SetLastPlayedTimeCallback();

        private void SetLastPlayedTime()
        {
            if (this.LastPlayedValueLabel.InvokeRequired)
            {
                SetLastPlayedTimeCallback d = new SetLastPlayedTimeCallback(SetLastPlayedTime);
                this.Invoke(d, new object[] { });
            } else
            {
                if (endDateTime > startDateTime)
                    games[GamesListBox.SelectedIndex].lastPlayed = endDateTime.ToString();
                LastPlayedValueLabel.Text = games[GamesListBox.SelectedIndex].lastPlayed;
            }
        }

        delegate void SetTotalPlayTimeCallback(Game game);

        private void SetTotalPlayTime(Game game)
        {
            if (this.TotalTimePlayedValueLabel.InvokeRequired)
            {
                SetTotalPlayTimeCallback d = new SetTotalPlayTimeCallback(SetTotalPlayTime);
                this.Invoke(d, new object[] { game });
            }
            else
            {
                int totalPlayTime = Convert.ToInt32(game.playTime) + Convert.ToInt32(game.steamPlayTime);
                TotalTimePlayedValueLabel.Text = TimeUtil.ConvertToHoursMinutes(totalPlayTime);
            }
        }

        delegate void SetCollectivePlayTimeCallback(List<Game> games);

        private void SetCollectivePlayTime(List<Game> games)
        {
            if (this.CollectivePlayTimeLabel.InvokeRequired)
            {
                SetCollectivePlayTimeCallback d = new SetCollectivePlayTimeCallback(SetCollectivePlayTime);
                this.Invoke(d, new object[] { games });
            } else
            {
                CollectivePlayTimeValueLabel.Text = TimeUtil.GetCollectivePlayTime(games);
            }
        }

        private void UpdateImages()
        {
            //string imageLocation = "./images/" +  imageHolders[GamesListBox.SelectedIndex].GetStoredImage();
            string imageLocation = "./images/" + games[GamesListBox.SelectedIndex].name + ".png";
            if (File.Exists(imageLocation))
                PreviewBox.ImageLocation = imageLocation;
            else
                PreviewBox.ImageLocation = "./images/error.png";
        }

        private void UpdateGameList()
        {
            string cur = GamesListBox.SelectedItem.ToString();
            GamesListBox.Items.Clear();
            foreach (Game game in games)
                GamesListBox.Items.Add(game.name);
            GamesListBox.SelectedItem = cur;
        }

        private void UpdateBackupList()
        {
            BackupCheckedListBox.Items.Clear();
            foreach (Game game in games)
            {
                if (game.saveLocation != "N/A" && Directory.Exists(game.saveLocation))
                    BackupCheckedListBox.Items.Add(game.name);
                if (!Directory.Exists("./Backup/" + game.name))
                    Directory.CreateDirectory("./Backup/" + game.name);
            }
        }

        private void UpdateRestoreList()
        {
            RestoreCheckedListBox.Items.Clear();
            string[] backupDir = Directory.GetDirectories("./Backup/");
            foreach (string availableBackup in backupDir)
                RestoreCheckedListBox.Items.Add(Path.GetFileName(availableBackup));
        }
        # endregion

        private DateTime GetCurrentDateTime()
        {
            return DateTime.Now;
        }

        private void UpdatePlayTime()
        {
            foreach (Game game in games)
            {
                if (game.name == selectedGame)
                {
                    TimeSpan span = endDateTime - startDateTime;
                    game.playTime = (Convert.ToInt32(game.playTime) + span.Minutes).ToString();
                    UpdateLabels();
                    return;
                }
            }
        }

        private void SetLastSelectedGame()
        {
           File.WriteAllText("Startup.txt", selectedGame);
        }

        private void UpdateGameFile()
        {
            StreamWriter sw = new StreamWriter("Games.csv");
            foreach (Game game in games)
                sw.WriteLine(game.ToString());
            sw.Close();
        }

        private void SetFirstPlayedTime()
        {
            if (games[GamesListBox.SelectedIndex].firstPlayed == "N/A")
            {
                games[GamesListBox.SelectedIndex].firstPlayed = DateTime.Now.ToString();
                FirstPlayedValueLabel.Text = games[GamesListBox.SelectedIndex].firstPlayed;
            }
        }

        #region ListBox Events
    //------------------------------------------------------------------------------------
    //                                ListBox Events                                   
    //------------------------------------------------------------------------------------

            private void MouseDirection(MouseEventArgs e)
            {
                if (e.Delta > 0 && GamesListBox.SelectedIndex > 0)
                    GamesListBox.SelectedIndex--;
                else if (e.Delta < 0 && GamesListBox.SelectedIndex < GamesListBox.Items.Count - 1)
                    GamesListBox.SelectedIndex++;
            }

            private void GamesListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                ChangeCurrentGame();
            }

            private void BackupCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                ChangeCurrentGame();
            }

            private void RestoreCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                ChangeCurrentGame();
            }
    #endregion

        #region LinkLabel Events
        //------------------------------------------------------------------------------------
        //                            LinkLabel (ViewMode) Events                                   
        //------------------------------------------------------------------------------------

                private void GameModeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    ViewMode.ChangeView(this, "Game");
                }

                private void BackupModeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    ViewMode.ChangeView(this, "Backup");
                }

                private void RestoreModeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    ViewMode.ChangeView(this, "Restore");
                }

        #endregion

        #region Button Click Events
                //------------------------------------------------------------------------------------
        //                               Button Click Events                                   
        //------------------------------------------------------------------------------------

                // TODO
                private void RestoreGamesButton_Click(object sender, EventArgs e)
                {
                    foreach (string item in RestoreCheckedListBox.Items)
                        foreach (Game game in games)
                            if (game.name == item)
                                if (Directory.Exists("./Backup/" + game.name))
                                    GameUtil.DirectoryCopy("./Backup/" + game.name, game.saveLocation, true);
                }

                private void ClearAllButton_Click(object sender, EventArgs e)
                {
                    for (int x = 0; x < BackupCheckedListBox.Items.Count; x++)
                        BackupCheckedListBox.SetItemChecked(x, false);
                }

                private void SelectAllButton_Click(object sender, EventArgs e)
                {
                    for (int x = 0; x < BackupCheckedListBox.Items.Count; x++)
                        BackupCheckedListBox.SetItemChecked(x, true);
                }

                private void SaveGameButton_Click(object sender, EventArgs e)
                {
                    string source;
                    string destination = "./Backup/";

                    foreach (string item in BackupCheckedListBox.CheckedItems)
                    {
                        foreach (Game game in games)
                            if (game.name == item)
                            {
                                source = game.saveLocation;
                                destination += game.name;
                                GameUtil.DirectoryCopy(source, destination, true);
                            }
                    }
                    UpdateRestoreList();
                    MessageBox.Show("Games backed up successfully.");
                }

                private void editGameLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
                {
                    for (int x = 0; x < games.Count; x++)
                    {
                        if (games[x].name == selectedGame)
                        {
                            AddGame EditGameForm = new AddGame(games[x], "Edit");
                            EditGameForm.ShowDialog();
                            Game added = EditGameForm.GetGame();
                            if (added != null)
                            {
                                games[x] = added;
                                ChangeCurrentGame();
                            }
                            return;
                        }
                    }
                }

                private void PlayGameButton_Click(object sender, EventArgs e)
                {
                    string gameExe = games[GamesListBox.SelectedIndex].gameLocation;
                    Process p = new Process();

                    p.StartInfo.FileName = gameExe;
                    p.EnableRaisingEvents = true;
                    p.Exited += new EventHandler(VideoGameProcess_Exited);

                    if (File.Exists(gameExe))
                    {
                        p.Start();
                        startDateTime = DateTime.Now;
                        SetFirstPlayedTime();
                    }
                }

                private void VideoGameProcess_Exited(object sender, System.EventArgs e)
                {
                    endDateTime = DateTime.Now;
                    UpdatePlayTime();

                }
                #endregion

        #region Tool Strip Menu Item Events
        //------------------------------------------------------------------------------------
        //                           Tool Strip Menu Item Events                                   
        //------------------------------------------------------------------------------------

                private void AddGameToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    AddGame addGameForm = new AddGame("Add");
                    addGameForm.ShowDialog();
                    Game added = addGameForm.GetGame();
                    if (added != null)
                    {
                        games.Add(added);
                        games.Sort(new GameComp());
                    }
                    UpdateGameList();
                    ChangeCurrentGame();
                }

                private void UpdateSteamGamesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    SteamUtil steam = new SteamUtil();
                    steam.UpdateGames(games);
                    ChangeCurrentGame();
                }

                private void PreferencesToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    Preferences pref = new Preferences();
                    pref.ShowDialog();
                }

                private void GB_FormClosing(object sender, FormClosingEventArgs e)
                {
                    UpdateGameFile();
                    SetLastSelectedGame();
                }

                private void SendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    EmailForm ef = new EmailForm();
                    ef.ShowDialog();
                }

                private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
                {
                    MessageBox.Show("Written By Kyler Burnett\n\nThis is a game manager that allows the user to create a database-like\ncollection of owned video games.");
                }
        #endregion

    }// end class
}// end Namespace
