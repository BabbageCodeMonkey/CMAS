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
    public partial class UpdateEvent : Form
    {
        public UpdateEvent()
        {
            InitializeComponent();
        }
        int frmLoaded;
        private void UpdateEvent_Load(object sender, EventArgs e)
        {
            DataTable dtEv = new DataTable();

            DataTable dtLoc = new DataTable();
            DataTable dtCat = new DataTable();
            DataTable dtUse = new DataTable();

            Category cat = new Category();
            User use = new User();
            BusinessLayer.Location loc = new Location();
            Event ev = new Event();


            dtEv = ev.getEventList();
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

            dgvEvent.DataSource = dtEv;

            frmLoaded = 1;

        }

        private void dgvEvent_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BusinessLayer.Event ev = new BusinessLayer.Event();

            if (dgvEvent.SelectedCells.Count > 0 && frmLoaded == 1)
            {
                int rowIndex = dgvEvent.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvEvent.Rows[rowIndex];

                int ID = Convert.ToInt32(selectedRow.Cells["EventID"].Value);

                dt = ev.getEventByID(ID);

               
                //Must use selected value
                //cboAdd.Text = "";
                //cboAdd.SelectedText = Convert.ToString(dt.Rows[0]["Address1"]);

                cboCat.SelectedValue = dt.Rows[0]["CategoryID"];
                cboLoc.SelectedValue = dt.Rows[0]["LocationID"];
                cboUser.SelectedValue = dt.Rows[0]["UserID"];

                txtDesc.Text = Convert.ToString(dt.Rows[0]["Descr"]);
                dtpDate.Text = Convert.ToString(dt.Rows[0]["EventDate"]);
                rdoActive.Checked = Convert.ToBoolean(dt.Rows[0]["Active"]);


        }
    }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (rdoActive.Checked == false)
            {
                DialogResult test;
                test = MessageBox.Show("You are about to set this event to inactive. Are you sure you want to do that?","Validate",MessageBoxButtons.YesNo);

                if (test == DialogResult.No)
                {
                    return;
                }
                
            }

            Event ev = new Event();

            int rowIndex = dgvEvent.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgvEvent.Rows[rowIndex];

            int ID = Convert.ToInt32(selectedRow.Cells["EventID"].Value);

            ev.updateEvent(Convert.ToInt32(ID), Convert.ToInt32(cboLoc.SelectedValue), Convert.ToInt32(cboCat.SelectedValue), Convert.ToInt32(cboUser.SelectedValue), Convert.ToString(txtDesc.Text), Convert.ToDateTime(dtpDate.Text), Convert.ToBoolean(rdoActive.Checked));

            dgvEvent.DataSource = ev.getEventList();
        }

        private void rdoActive_Click(object sender, EventArgs e)
        {
            if (rdoActive.Checked)
            {
                rdoActive.Checked = false;
            }
            else
            {
                rdoActive.Checked = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            Event ev = new Event();

            DataTable dt = new DataTable();
            DataTable dtF = new DataTable();

            dt = ev.getEventList();

            dtF = s.searchOneCriteria(dt, Convert.ToString(cboCat.SelectedValue), "CategoryID");

            dgvEvent.DataSource = dtF;
        }
}
}
