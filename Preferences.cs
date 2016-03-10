using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Buddy
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            textBox1.Text = File.ReadAllText("./SteamID.txt");
        }

        private void Preferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText("./SteamID.txt", textBox1.Text);
        }
    }// end class
}// end namespace
