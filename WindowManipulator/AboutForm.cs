using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowManipulator
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://ko-fi.com/bunzhizendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The developer is still figuring out on how this works... Tell them directly", "Info");
        }
    }
}
