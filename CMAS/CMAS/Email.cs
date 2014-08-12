using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace CMAS
{
    public partial class Email : Form
    {
        public Email()
        {
            InitializeComponent();
            //cbEmailAdd.DataBindings = 
            var items = cbEmailAdd.Items;
            items.Add("fbutts@yahoo.com");

        }



        private void btnSend_Click(object sender, EventArgs e)
        {



            try
            {

                string txtfrom = "AvedisianForMayor@gmail.com";
                //Change back to PassEmail.Text 
                string txtpassword = "A4M12345";// PassEmail.Text;
                MailMessage mail = new MailMessage(txtfrom, RecEmail.Text, SubEmail.Text, BodyEmail.Text);
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("AvedisianForMayor@gmail.com", txtpassword);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("Your Message was sent!");
                this.Close();
            }

            catch
            {
                // If Mail Doesnt Send Error Mesage Will Be Displayed
                Status.Text = "Error sending Email, Check the Password you are using";
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
