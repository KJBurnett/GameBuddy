using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Buddy
{
    public static class DialogUtil
    {
        public static string OpenFileDialog(string filter)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string res = "";

            // Set default initial directory.
            ofd.InitialDirectory = "c:/";

            // Set filter options and filter index.
            ofd.Filter = filter;
            ofd.FilterIndex = 1;

            // Toggle true/false for allowing user to select multiple files.
            ofd.Multiselect = false;

            // Call the ShowDialog method to show the dialogbox.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                res = ofd.FileName;
            }
            return res;
        }

        public static string OpenFolderDialog()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            string res = "";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                res = fbd.SelectedPath;
            }
            return res;
        }

        public static string GetExeFilter()
        {
            return "Exe Files (*.exe)|*.exe|All Files (*.*)|*.*";
        }

        public static string GetImageFilter()
        {
            return "PNG Files (*.png)|*.png|All Files (*.*)|*.*";
        }

    }// end class
}// end namespace
