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
    public partial class InsertUser : Form
    {
        public InsertUser()
        {
            InitializeComponent();
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            BusinessLayer.User user = new BusinessLayer.User();

            string FName, LName, Username, Password;
            int AddressID, pType;
            bool Active;

            FName = txtFname.Text;
            LName = txtLName.Text;
            Username = txtUsername.Text;
            Password = txtPass.Text;

            AddressID = Convert.ToInt32(cboAdd.SelectedValue);
            pType = Convert.ToInt32(cboType.SelectedValue);

            Active = true;

            user.insertPerson(FName, LName, Username, Password, AddressID, pType, Active);

        }

        private void InsertUser_Load(object sender, EventArgs e)
        {
            DataTable dtPersonType = new DataTable();
            DataTable dtAddress = new DataTable();

            BusinessLayer.Address add = new BusinessLayer.Address();
            BusinessLayer.PersonType pType = new BusinessLayer.PersonType();

            cboAdd.DataSource = add.getAllAddress();
            cboAdd.DisplayMember = "Address1";
            cboAdd.ValueMember = "AddressID";

            cboType.DataSource = pType.getPersonTypePickList();
            cboType.DisplayMember = "Descr";
            cboType.ValueMember = "TypeID";

        }
    }
}
