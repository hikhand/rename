using System.Diagnostics;
using rename.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rename
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            Image icon = Resources.simpleRennamerM;
            pictureBox1.Image = icon;
            pictureBox1.Height = icon.Height;
            pictureBox1.Width = icon.Height;

            label4.Text =
                "there is to 2 way to rename files/folders:\n" +
                "     -replace: with this feature you can find and replace the name of file and folders.\n" +
                "     -Add: with this feautre you can add text to the end or first of file and folders.";

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://sourcekade.ir");
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
