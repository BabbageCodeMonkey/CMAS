using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;

namespace CMAS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_MouseClick(object sender, MouseEventArgs e)
        {
            BusinessLayer.Login log = new BusinessLayer.Login();
            Log l = new Log();
            DataTable dt = new DataTable();

            try
            {
                dt = log.getCred(Convert.ToString(txtUsername.Text), Convert.ToString(txtPass.Text));

                BusinessLayer.Auth.role = Convert.ToString(dt.Rows[0]["Descr"]);
                BusinessLayer.Auth.username = Convert.ToString(dt.Rows[0]["Username"]);
                BusinessLayer.Auth.password = Convert.ToString(dt.Rows[0]["Password"]);

                l.insertLog(Convert.ToInt32(dt.Rows[0]["UserID"]), Convert.ToDateTime(DateTime.Now), "Login", "Login Page", "Successfull login!");

                this.Close();
            }
                //here we can log exceptions when they occur on login
            catch (Exception ex)
            {
                MessageBox.Show("Login not found.");
                l.insertLog(8, Convert.ToDateTime(DateTime.Now), "Failed Login", "Login Page", "Un-Successfull login! Here's why     " + ex);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
