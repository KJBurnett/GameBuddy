using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Buddy
{
    public static class ViewMode
    {
        public static void ChangeView(GB gb, string mode)
        {
            if (mode == "Game")
                SetGameMode(gb);
            else if (mode == "Backup")
                SetBackupMode(gb);
            else if (mode == "Restore")
                SetRestoreMode(gb);
        }

        private static void SetGameMode(GB gb)
        {
            if (gb.GamesListBox.Visible != true)
            {
                gb.GamesListBox.SelectedItem = gb.GetSelectedGame();
                gb.ChangeCurrentGame();

                // Listbox visibility.
                gb.GamesListBox.Visible             = true;
                gb.BackupCheckedListBox.Visible     = false;
                gb.RestoreCheckedListBox.Visible    = false;

                // Button visibility.
                gb.PlayGameButton.Visible       = true;
                gb.SaveGameButton.Visible       = false;
                gb.RestoreGamesButton.Visible   = false;
                gb.SelectAllButton.Visible      = false;
                gb.ClearAllButton.Visible       = false;

                // LinkLabel visibility.
                gb.GameModeLink.LinkColor       = Color.Red;
                gb.BackupModeLink.LinkColor     = Color.Blue;
                gb.RestoreModeLink.LinkColor    = Color.Blue;
                gb.ListBoxLabel.Text = "Available Games";
            }
        }

        private static void SetBackupMode(GB gb)
        {
            if (gb.BackupCheckedListBox.Visible != true)
            {
                if (!gb.BackupCheckedListBox.Items.Contains(gb.GetSelectedGame()))
                {
                    gb.BackupCheckedListBox.SelectedIndex = 0;
                    gb.SetSelectedGame(gb.BackupCheckedListBox.SelectedItem.ToString());
                }
                else
                    gb.BackupCheckedListBox.SelectedItem = gb.GetSelectedGame();

                gb.ChangeCurrentGame();

                // Listbox visibility.
                gb.GamesListBox.Visible             = false;
                gb.BackupCheckedListBox.Visible     = true;
                gb.RestoreCheckedListBox.Visible    = false;

                // Button visibility.
                gb.PlayGameButton.Visible       = false;
                gb.SaveGameButton.Visible       = true;
                gb.RestoreGamesButton.Visible   = false;
                gb.SelectAllButton.Visible      = true;
                gb.ClearAllButton.Visible       = true;

                // LinkLabel visibility.
                gb.GameModeLink.LinkColor       = Color.Blue;
                gb.BackupModeLink.LinkColor     = Color.Red;
                gb.RestoreModeLink.LinkColor    = Color.Blue;
                gb.ListBoxLabel.Text = "Available to Backup";
            }
        }

        private static void SetRestoreMode(GB gb)
        {
            if (gb.RestoreCheckedListBox.Visible != true)
            {
                if (!gb.RestoreCheckedListBox.Items.Contains(gb.GetSelectedGame()))
                {
                    if (gb.RestoreCheckedListBox.Items.Count > 0)
                    {
                        gb.RestoreCheckedListBox.SelectedIndex = 0;
                        gb.SetSelectedGame(gb.RestoreCheckedListBox.SelectedItem.ToString());
                    }
                }
                else
                    gb.RestoreCheckedListBox.SelectedItem = gb.GetSelectedGame();

                gb.ChangeCurrentGame();

                // Listbox visibility.
                gb.GamesListBox.Visible             = false;
                gb.BackupCheckedListBox.Visible     = false;
                gb.RestoreCheckedListBox.Visible    = true;

                // Button visibility.
                gb.PlayGameButton.Visible       = false;
                gb.SaveGameButton.Visible       = false;
                gb.RestoreGamesButton.Visible   = true;
                gb.SelectAllButton.Visible      = false;
                gb.ClearAllButton.Visible       = false;

                // LinkLabel visibility.
                gb.GameModeLink.LinkColor       = Color.Blue;
                gb.BackupModeLink.LinkColor     = Color.Blue;
                gb.RestoreModeLink.LinkColor    = Color.Red;
                gb.ListBoxLabel.Text = "Available to Restore";
            }
        }
    }
}
