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
    public partial class InsertEvent : Form
    {
        public InsertEvent()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Event ev = new Event();

            ev.insertEvent(Convert.ToInt32(cboLoc.SelectedValue), Convert.ToInt32(cboCat.SelectedValue), Convert.ToInt32(cboUser.SelectedValue), Convert.ToString(txtDesc.Text), Convert.ToDateTime(dtpDate.Text));
        }

        private void InsertEvent_Load(object sender, EventArgs e)
        {
            DataTable dtLoc = new DataTable();
            DataTable dtCat = new DataTable();
            DataTable dtUse = new DataTable();

            Category cat = new Category();
            User use = new User();
            BusinessLayer.Location loc = new Location();

            dtLoc = loc.getLocaitonPickList();
            dtCat = cat.getCategoryPickList();
            dtUse = use.getPersonList();

            cboCat.DataSource = dtCat;
            cboLoc.DataSource = dtLoc;
            cboUser.DataSource = dtUse;

            cboCat.DisplayMember = "Descr";
            cboCat.ValueMember = "CategoryID";

            cboLoc.DisplayMember = "Descr";
            cboLoc.ValueMember = "LocationID";

            cboUser.DisplayMember = "Display";
            cboUser.ValueMember = "UserID";



        }
    }
}
