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
    public partial class AddUpdate : Form
    {
        public AddUpdate()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void AddUpdate_Load(object sender, EventArgs e)
        {
            DataTable dtAllForms = new DataTable();
            DataTable dtCat = new DataTable();

            DataTable dtUser = new DataTable();

            BusinessLayer.Category cat = new BusinessLayer.Category();
            BusinessLayer.Forms forms = new BusinessLayer.Forms();
            BusinessLayer.User user = new BusinessLayer.User();

            dtUser = user.getUserPickListFName();
            dtCat = cat.getCategoryPickList();

            cboUser.DataSource = dtUser;
            cboUser.ValueMember = "UserID";
            cboUser.DisplayMember = "Fname";

            cboCategory.DataSource = dtCat;
            cboCategory.ValueMember = "CategoryID";
            cboCategory.DisplayMember = "Descr";

            dtAllForms = forms.getAllForms();

            dgView.DataSource = dtAllForms;
        }
    }
}
