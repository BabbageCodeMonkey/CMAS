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
    public partial class InsertEvent : Form
    {
        public InsertEvent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void InsertEvent_Load(object sender, EventArgs e)
        {
            DataTable dtLoc = new DataTable();
            DataTable dtCat = new DataTable();
            DataTable dtUse = new DataTable();


        }
    }
}
