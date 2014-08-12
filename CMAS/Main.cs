using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Diagnostics;

namespace CMAS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //this.Size = new Size(1300, 900);
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://cmas.wikia.com/wiki/Main_Page#");
            Process.Start(sInfo); 
            //Wiki temp = new Wiki();
            //temp.Show();

 
        }

        private void newsTicker1_Paint(object sender, PaintEventArgs e)
        {
            string news = "This is the news ticker that we can add events too!";
            //MainTicker. = news;
        }

        private void MainTicker1_Paint(object sender, PaintEventArgs e)
        {
            string news = "This is the news ticker that we can add events too!";
            MainTicker.Text = news;
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            string news = "This is the news ticker that we can add events too!";
            MainTicker.Text = news;
        }

        private void Logout_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
       
        }
}
