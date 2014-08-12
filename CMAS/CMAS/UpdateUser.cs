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

                cboAdd.SelectedText = Convert.ToString(dt.Rows[0]["Address1"]);
                cboType.SelectedValue = dt.Rows[0]["TypeID"];

                txtFname.Text = Convert.ToString(dt.Rows[0]["FName"]);
                txtLName.Text = Convert.ToString(dt.Rows[0]["LName"]);
                txtPass.Text = Convert.ToString(dt.Rows[0]["Password"]);
                txtUsername.Text = Convert.ToString(dt.Rows[0]["Username"]);


            }
        }
    }
}
