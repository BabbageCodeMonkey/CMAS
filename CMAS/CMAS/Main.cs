﻿using System;
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
            this.Size = new Size(1355, 900);

            Login log = new Login();
            log.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Map temp = new Map();
            temp.Show();
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
            
        }

        private void MainTicker1_Paint(object sender, PaintEventArgs e)
        {
         /*   do not delete gives an error!!  */
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            DataTable dtTicker = new DataTable();

            BusinessLayer.Ticker EventList = new BusinessLayer.Ticker();

            dtTicker = EventList.getEventList();
            string news = "";
            for (int i = 0; i < dtTicker.Rows.Count; i++)
            {
                news = news + dtTicker.Rows[i]["Descr"].ToString() + "        --------        ";
            }

            MainTicker.Text = news;
        }

        private void Logout_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUpdate add = new AddUpdate();

            add.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertUser user = new InsertUser();

            user.Show();
        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser user = new UpdateUser();

            user.Show();
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Email temp = new Email();

            temp.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Canvas can = new Canvas("Add");

            can.Show();
        }

        private void updateToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Canvas can = new Canvas("Update");

            can.Show();
        }

        private void deleteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Canvas can = new Canvas("Delete");

            can.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InsertEvent ev = new InsertEvent();

            ev.Show();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UpdateEvent ev = new UpdateEvent();

            ev.Show();
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportData ed = new ExportData();
            ed.Show();
        }
       
        }
}
