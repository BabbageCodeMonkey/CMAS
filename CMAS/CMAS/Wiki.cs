using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMAS
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
            //Navigate("http://cmas.wikia.com/wiki/Main_Page#");

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Navigate("http://cmas.wikia.com/wiki/Main_Page#");

        }
    }
}
