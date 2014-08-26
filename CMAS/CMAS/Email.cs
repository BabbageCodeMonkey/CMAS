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
        //string email = "";

        public Email()
        {
            InitializeComponent();

            DataTable dtEmail = new DataTable();

            BusinessLayer.Email EmailList = new BusinessLayer.Email();

            dtEmail = EmailList.getEmailList();

            for (int i = 0; i < dtEmail.Rows.Count; i++)
            {

                cbEmailAdd.Items.Add(Convert.ToString(dtEmail.Rows[i]["ContactEmail"])); /*Convert.ToString(dtEmail.Rows[i]["First"]) + */

            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {


            if (cbEmailAdd.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.
                string s = "";
                for (int x = 0; x <= cbEmailAdd.CheckedItems.Count - 1; x++)
                {
                    s = cbEmailAdd.CheckedItems[x].ToString();

                    try
                    {
                        //compose and send the email
                        string txtfrom = "AvedisianForMayor@gmail.com";
                        string txtpassword = PassEmail.Text;
                        //s = "fbutts@yahoo.com";
                        MailMessage mail = new MailMessage(txtfrom, s, SubEmail.Text, BodyEmail.Text);
                        SmtpClient client = new SmtpClient("smtp.gmail.com");
                        client.Port = 587;
                        client.Credentials = new System.Net.NetworkCredential("AvedisianForMayor@gmail.com", txtpassword);
                        client.EnableSsl = true;
                        client.Send(mail);

                    }

                    catch
                    {
                        // If Mail Doesnt Send Error Mesage Will Be Displayed
                        Status.Text = "Error sending Email, Check the Password you are using";
                    }

                }
                MessageBox.Show("Your Messages were sent!");
                this.Close();
            }

        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

