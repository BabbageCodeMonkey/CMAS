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
    public partial class UpdateUser : Form
    {
        int frmLoaded = 0;

        public UpdateUser()
        {
            InitializeComponent();
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            //Use this snippet to authenticate any user.
            //the role may need to be changed.
            if (BusinessLayer.Auth.role != "Admin")
            {
                MessageBox.Show("You do not have permission to use this page.");
                this.Close();
            }

            DataTable dtPersonType = new DataTable();
            DataTable dtAddress = new DataTable();
            DataTable dtPerson = new DataTable();

            BusinessLayer.Address add = new BusinessLayer.Address();
            BusinessLayer.PersonType pType = new BusinessLayer.PersonType();
            BusinessLayer.User user = new BusinessLayer.User();


            dgvUser.DataSource = user.getPersonList();

            cboAdd.DataSource = add.getAllAddress();
            cboAdd.DisplayMember = "Address1";
            cboAdd.ValueMember = "AddressID";

            cboType.DataSource = pType.getPersonTypePickList();
            cboType.DisplayMember = "Descr";
            cboType.ValueMember = "TypeID";

            frmLoaded = 1;
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            BusinessLayer.User user = new BusinessLayer.User();

            if (dgvUser.SelectedCells.Count > 0 && frmLoaded == 1)
            {
                int rowIndex = dgvUser.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvUser.Rows[rowIndex];

                int ID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                dt = user.getPersonByID(ID);

               
                //Must use selected value
                //cboAdd.Text = "";
                //cboAdd.SelectedText = Convert.ToString(dt.Rows[0]["Address1"]);

                cboAdd.SelectedValue = dt.Rows[0]["AddressID"];

                cboType.SelectedValue = dt.Rows[0]["TypeID"];

                txtFname.Text = Convert.ToString(dt.Rows[0]["FName"]);
                txtLName.Text = Convert.ToString(dt.Rows[0]["LName"]);
                txtPass.Text = Convert.ToString(dt.Rows[0]["Password"]);
                txtUsername.Text = Convert.ToString(dt.Rows[0]["Username"]);


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DataTable dtPerson = new DataTable();
            //I really want to change how this works but in the name of speed I'll fo this now...
            if (Convert.ToString(txtFname.Text) == "" && Convert.ToString(txtLName.Text) == "")
            {
                MessageBox.Show("Please sleect a user from the list.");
            }
            else
            {
                BusinessLayer.User user = new BusinessLayer.User();
                UpdateUser up = new UpdateUser();

                int rowIndex = dgvUser.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvUser.Rows[rowIndex];

                int ID = Convert.ToInt32(selectedRow.Cells["UserID"].Value);

                user.updatePerson(ID, Convert.ToString(txtFname.Text), Convert.ToString(txtLName.Text), Convert.ToString(txtUsername.Text), Convert.ToString(txtPass.Text), Convert.ToInt32(cboAdd.SelectedValue), Convert.ToInt32(cboType.SelectedValue), true);

                dgvUser.DataSource = user.getPersonList();
            }
        }

    }
}
