using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Buddy
{
    public partial class AddGame : Form
    {
        private string mode;
        private Game game;
        private int currentImage = 0;
        private int totalImages = 0;
        private bool userClickedSave = false;
        private string oldImage;

        public AddGame()
        {
            InitializeComponent();
        }

        public AddGame(string mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.game = new Game();
        }

        public AddGame(Game game, string mode)
        {
            InitializeComponent();
            this.mode = mode;
            this.game = game;
        }

        private void AddGame_Load(object sender, EventArgs e)
        {
            if (mode == "Add")
                AddNewGame();
            else if (mode == "Edit")
                EditExistingGame();
        }

        private void AddNewGame()
        {

        }

        private void EditExistingGame()
        {
            ExeLocationTextBox.Text = game.gameLocation;
            SaveLocationTextBox.Text = game.saveLocation;
            ImageLocationTextBox.Text = GetCurrentImage();
            oldImage = ImageLocationTextBox.Text;
            PreviewBox.ImageLocation = ImageLocationTextBox.Text;
            CompletedCheckBox.Checked = GetCompletedState();
            TotalCompletionCheckBox.Checked = GetTotalCompletionState();
            GameTitleTextBox.Text = game.name;
            GenreTextBox.Text = game.genre;
            SummaryTextBox.Text = GetSummary();
            ImageCountLabel.Text = GetImageCount();
        }

        public Game GetGame()
        {
            if (userClickedSave)
                return this.game;
                return null;
        }

        private bool GetCompletedState()
        {
            if (game.dateCompleted != "N/A")
                return true;
            return false;
        }

        private bool GetTotalCompletionState()
        {
            if (game.timeTo100Percent != "N/A")
                return true;
            return false;
        }

        private string ParseGameTitle()
        {
            string title = ExeLocationTextBox.Text;
            title = Path.GetFileNameWithoutExtension(title);

            while (title.Contains("."))
                title.Replace(".", " ");

            return title;
        }

        private string GetSummary()
        {
            string summary = "./Summaries/" + game.name.ToLower() + ".txt";
            if (File.Exists(summary))
                return File.ReadAllText(summary);
            return "";
        }

        private string GetCurrentImage()
        {
            string img = "./Images/" + game.name + ".png";
            if (File.Exists(img))
                return Path.GetFullPath(img);
            return "";
        }

        private string GetImageCount()
        {
            string imgDir = "./Images/";
            string[] imgFiles = Directory.GetFiles(imgDir);
            string imgName = Path.GetFileNameWithoutExtension(ImageLocationTextBox.Text);
            int total = 0;

            foreach (string img in imgFiles)
                if (img.Contains(game.name))
                    total++;

            currentImage = 0; // Due to 0th indexing.
            totalImages = total - 1;

            SetSlideButtons();
            return (currentImage + 1).ToString() + "/" + (totalImages + 1).ToString();
        }

        private void SlideLeftButton_Click(object sender, EventArgs e)
        {
            string img = ImageLocationTextBox.Text;
            string[] a = img.Split('(');

            if (currentImage > 1)
            {
                currentImage--;
                img = a[0] + "(" + currentImage.ToString() + ").png";
            }
            else if (currentImage == 1)
            {
                currentImage--;
                img = Path.GetFullPath("./Images/" + game.name + ".png");
            }

            ImageLocationTextBox.Text = img;
            PreviewBox.ImageLocation = img;
            ImageCountLabel.Text = (currentImage + 1).ToString() + "/" + (totalImages + 1).ToString();
            SetSlideButtons();
        }

        private void SlideRightButton_Click(object sender, EventArgs e)
        {
            string img = ImageLocationTextBox.Text;

            if (currentImage == 0)
            {
                currentImage++;
                string[] a = img.Split('.');
                img = a[0] + " (" + currentImage.ToString() + ").png";
            }

            else if (currentImage < totalImages)
            {
                currentImage++;
                string[] a = img.Split('(');
                img = a[0] + "(" + currentImage.ToString() + ").png";
            }

            ImageLocationTextBox.Text = img;
            PreviewBox.ImageLocation = img;
            ImageCountLabel.Text = (currentImage + 1).ToString() + "/" + (totalImages + 1).ToString();
            SetSlideButtons();
        }

        private void SetSlideButtons()
        {
            if (currentImage == 0)
            {
                SlideLeftButton.Enabled = false;
                SlideRightButton.Enabled = true;
            }
            else if (currentImage == totalImages)
            {
                SlideLeftButton.Enabled = true;
                SlideRightButton.Enabled = false;
            }
            else
            {
                SlideLeftButton.Enabled = true;
                SlideRightButton.Enabled = true;
            }
        }

        private void RenameCurrentImage()
        {
            string img = ImageLocationTextBox.Text;
            string truImg = Path.GetFullPath("./Images/" + game.name.ToLower() + ".png");
            if (File.Exists(truImg))
            {
                string temp = Path.GetFullPath("./Images/" + "temp.png");

                if (img != truImg) // Move the current image to the current slot.
                {
                    File.Move(truImg, temp);
                    File.Move(img, truImg);
                    File.Move(temp, img);
                }
            }
            else
            {
                AddNewImage();
            }
        }

        public void SetExeLocationTextBox(string str)
        {
            ExeLocationTextBox.Text = str;
        }

        private void BrowseExeButton_Click(object sender, EventArgs e)
        {
            string res = DialogUtil.OpenFileDialog(DialogUtil.GetExeFilter());
            if (res != "")
            {
                ExeLocationTextBox.Text = res;
                GameTitleTextBox.Text = Path.GetFileNameWithoutExtension(res);
            }
        }

        private void BrowseSaveButton_Click(object sender, EventArgs e)
        {
            string res = DialogUtil.OpenFolderDialog();
            if (res != "")
                SaveLocationTextBox.Text = res;
        }

        private void BrowseImagesButton_Click(object sender, EventArgs e)
        {
            string res = DialogUtil.OpenFileDialog(DialogUtil.GetImageFilter());
            if (res != "")
            {
                ImageLocationTextBox.Text = res;
                PreviewBox.ImageLocation = res;
            }
        }

        private void SaveEditedData()
        {
            game.gameLocation = ExeLocationTextBox.Text;
            game.name = GameTitleTextBox.Text;
            game.saveLocation = SaveLocationTextBox.Text;
            game.dateCompleted = getCompletionDate();
            game.timeToComplete = getCompletionTime();
            Check100PercentCompletion();
            game.genre = GenreTextBox.Text;
            StoreNewSummary();
        }

        private void StoreNewSummary()
        {
            File.WriteAllText("./Summaries/" + game.name + ".txt", SummaryTextBox.Text);
        }

        private string getCompletionDate()
        {
            if (CompletedCheckBox.Checked && game.dateCompleted == "N/A") 
                return DateTime.Now.ToString("MM/dd/yyyy h:m tt");
            else 
                return "N/A";
        }

        private string getCompletionTime()
        {
            if (CompletedCheckBox.Checked && game.timeToComplete == "N/A")
                return TimeUtil.ConvertToHoursMinutes(Convert.ToInt32(game.playTime) + Convert.ToInt32(game.steamPlayTime));
            else
                return "N/A";
        }

        private void Check100PercentCompletion()
        {
            if (TotalCompletionCheckBox.Checked && game.timeTo100Percent == "N/A")
            {
                game.timeTo100Percent = DateTime.Now.ToString("MM/dd/yyyy h:m tt");
                game.timeTo100Percent += " in ";
                game.timeTo100Percent += TimeUtil.ConvertToHoursMinutes(Convert.ToInt32(game.playTime) + Convert.ToInt32(game.steamPlayTime));
            }
        }

        private void SaveNewData()
        {
            game.gameLocation = ExeLocationTextBox.Text;
            game.name = GameTitleTextBox.Text;
            game.saveLocation = SaveLocationTextBox.Text;
            game.dateCompleted = "N/A";
            game.timeTo100Percent = "N/A";
            game.genre = GenreTextBox.Text;
            StoreNewSummary();
            game.playTime = "0";
            game.steamPlayTime = "0";
            game.firstPlayed = "N/A";
            game.lastPlayed = "N/A";

            AddNewImage();
            
        }

        // 2015-02-15 2:43 PM - Method Deprecated. 
        //Previously used when multiple images could be added to the GS database.
        /*
        private void AddNewImage()
        {
            string image = PreviewBox.ImageLocation;
            if (File.Exists(image))
            {
                int count = 0;
                foreach (string item in Directory.GetFiles("./Images/"))
                    if (item.Contains(game.name))
                        count++;
                if (count < 1)
                    File.Copy(image, "./Images/" + game.name.ToLower() + ".png");
                else
                    File.Copy(image, "./Images/" + game.name.ToLower() + " (" + (count - 1).ToString() + ").png");
            }
        }
        */

        private void AddNewImage()
        {
            string image = PreviewBox.ImageLocation;
            if (File.Exists(image))
            {
                File.Copy(image, "./images/" + game.name + ".png", true);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            userClickedSave = true;
            if (mode == "Add")
                SaveNewData();
            else
            {
                SaveEditedData();
                RenameCurrentImage();
            }
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            userClickedSave = false;
            game = null;
            this.Close();
        }
    }
}

