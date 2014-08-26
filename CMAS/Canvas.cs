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
    public partial class Canvas : Form
    {
        public Canvas(String stateClicked )
        {
            InitializeComponent();
            StateClicked = stateClicked;
        }

        //Form Variables
        String StateClicked; 
        DataTable SkuPickList = new DataTable();
        DataTable SkuTypePickList = new DataTable();
        DataTable AddressTypePickList = new DataTable();
        DataTable LocationPickList = new DataTable();
        DataTable Sku = new DataTable();
        BusinessLayer.Supplies Skus = new BusinessLayer.Supplies();
        int frmLoaded = 0;
        int frmLocation = 0;


        private void Canvas_Load(object sender, EventArgs e)
        {

            if (StateClicked == "Add")
            {
                this.Width = 598;
                this.Height = 481;
                btnModSupply.Text = "Add";
                btnModAddress.Text = "Add";
                GetNewSkuList();
                cbxSku.Visible = false;
                //cbxADName.Visible = false;
            }
            else if (StateClicked == "Update")
            {
                this.Width = 598;
                this.Height = 481;
                btnModSupply.Text = "Update";
                btnModAddress.Text = "Update";
                btnLink2.Text = "Update Location";
                GetNewSkuList();
            }
            else if (StateClicked == "Delete")
            {
                this.Width = 598;
                this.Height = 481;
                btnModSupply.Text = "Delete";
                btnModAddress.Text = "Delete";
                btnLink2.Text = "Remove Location";
                GetNewSkuList();
                viewOnlySkuForm();
                viewOnlyAddressForm();
            }
            SetupCanvasDGV();
            btnModCanvas.Text = "Update Canvas";
            frmLoaded = 1;
        }

        private void cbxSku_SelectedValueChanged(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {

            }
            else if (StateClicked == "Update" && frmLoaded == 1)
            {
                updateSupplyFields();
            }
            else if (StateClicked == "Delete" && frmLoaded == 1)
            {
                updateSupplyFields();
            }
        }

        private void cbxSkuType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {

            }
            else if (StateClicked == "Update" && frmLoaded == 1)
            {
                updateSupplyFields();

            }
            else if (StateClicked == "Delete" && frmLoaded == 1)
            {
                updateSupplyFields();
            }
        }

        private void cbxADName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {

            }
            else if (StateClicked == "Update" && frmLoaded == 1)
            {
                updateADFields();

            }
            else if (StateClicked == "Delete" && frmLoaded == 1)
            {
                updateADFields();
            }
        }

        private void cbxLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {

            }
            else if (StateClicked == "Update" && frmLoaded == 1)
            {
                updateLOCFields();

            }
            else if (StateClicked == "Delete" && frmLoaded == 1)
            {
                updateLOCFields();
            }
        }

        private void btnLink_Click_1(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {
                btnLink2.Text = "Link Address";

                Skus.InsertLocation(txtADDescr.Text, Convert.ToInt32(cbxADName.SelectedValue)
                               );
                MessageBox.Show("Location Record Added", "Record Added");
                clearAddressForm();
            }
            else if (StateClicked == "Update")
            {
                btnLink2.Text = "Update Location";

                Skus.UpdateLocation(Convert.ToInt32(cbxLocation.SelectedValue),
                                    Convert.ToInt32(cbxADName.SelectedValue),
                                    txtADDescr.Text
                              );
                MessageBox.Show("Location Record Updated", "Record Updated");
            }
            else if (StateClicked == "Delete")
            {
                btnLink2.Text = "Delete Location";

                Skus.DeleteLocation(Convert.ToInt32(cbxLocation.SelectedValue)
                              );
                MessageBox.Show("Location Record Removed", "Record Removed");
            }
        }

        private void btnModAddress_Click(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {
                btnModAddress.Text = "Add";

                Skus.InsertAddress(txtADDescr.Text,
                               txtADAddress1.Text,
                               txtADAddress2.Text,
                               txtADCity.Text,
                               txtADState.Text,
                               txtADZip.Text,
                               txtADPhonePri.Text,
                               txtADPhoneSec.Text,
                               txtADEmail.Text
                               );
                MessageBox.Show("Address Record Added", "Record Added");
                clearAddressForm();
            }
            else if (StateClicked == "Update")
            {
                btnModAddress.Text = "Update";

                Skus.UpdateAddress(Convert.ToInt32(cbxADName.SelectedValue),
                               txtADDescr.Text,
                               txtADAddress1.Text,
                               txtADAddress2.Text,
                               txtADCity.Text,
                               txtADState.Text,
                               txtADZip.Text,
                               txtADPhonePri.Text,
                               txtADPhoneSec.Text,
                               txtADEmail.Text
                              );
                MessageBox.Show("Address Record Updated", "Record Updated");
            }
            else if (StateClicked == "Delete")
            {
                btnModAddress.Text = "Delete";

                Skus.DeleteAddress(Convert.ToInt32(cbxADName.SelectedValue)
                              );
                MessageBox.Show("Address Record Removed", "Record Removed");
                AddressTypePickList = Skus.getAddressTypeList();
                cbxADName.DataSource = AddressTypePickList;
                cbxADName.DisplayMember = "Descr";
                cbxADName.ValueMember = "AddressID";

            }
        }

        private void btnModSupply_Click(object sender, EventArgs e)
        {
            if (StateClicked == "Add")
            {
                btnModSupply.Text = "Add";

                Skus.InsertSku(Convert.ToInt32(cbxSkuType.SelectedValue), 
                               txtName.Text, 
                               txtDescr.Text, 
                               Convert.ToDecimal(txtUnitPrice.Text), 
                               Convert.ToInt32(txtInStock.Text), 
                               Convert.ToInt32(txtOnOrder.Text));
                MessageBox.Show("Supply Record Added", "Record Added");
                clearSkuForm();
            }
            else if (StateClicked == "Update")
            {
                btnModSupply.Text = "Update";

                Skus.UpdateSku(Convert.ToInt32(cbxSku.SelectedValue),
                               Convert.ToInt32(cbxSkuType.SelectedValue),
                               txtName.Text,
                               txtDescr.Text,
                               Convert.ToDecimal(txtUnitPrice.Text),
                               Convert.ToInt32(txtInStock.Text),
                               Convert.ToInt32(txtOnOrder.Text)
                              );
                MessageBox.Show("Supply Record Updated", "Record Updated");
            }
            else if (StateClicked == "Delete")
            {
                btnModSupply.Text = "Delete";

                Skus.DeleteSku(Convert.ToInt32(cbxSku.SelectedValue),
                               Convert.ToInt32(cbxSkuType.SelectedValue)
                              );
                MessageBox.Show("Supply Record Removed", "Record Updated");

                LocationPickList = Skus.getLocationList();
            }
        }

        private void GetNewSkuList()
        {
            SkuPickList = Skus.getSkuList();
            cbxSku.DataSource = SkuPickList;
            cbxSku.DisplayMember = "Descr";
            cbxSku.ValueMember = "SkuID";


            SkuTypePickList = Skus.getSkuTypeList();
            cbxSkuType.DataSource = SkuTypePickList;
            cbxSkuType.DisplayMember = "Descr";
            cbxSkuType.ValueMember = "SkuTypeID";

            AddressTypePickList = Skus.getAddressTypeList();
            cbxADName.DataSource = AddressTypePickList;
            cbxADName.DisplayMember = "Descr";
            cbxADName.ValueMember = "AddressID";

            LocationPickList = Skus.getLocationList();
            cbxLocation.DataSource = LocationPickList;
            cbxLocation.DisplayMember = "Descr";
            cbxLocation.ValueMember = "LocationID";
        }

        private void clearSkuForm()
        {
            txtName.Text = "";
            txtDescr.Text = "";
            txtUnitPrice.Text = "";
            txtInStock.Text = "";
            txtOnOrder.Text = "";
        }

        private void clearAddressForm()
        {
            txtADDescr.Text = "";
            txtADAddress1.Text = "";
            txtADAddress2.Text = "";
            txtADCity.Text = "";
            txtADState.Text = "";
            txtADZip.Text = "";
            txtADPhonePri.Text = "";
            txtADPhoneSec.Text = "";
            txtADEmail.Text = "";
        }

        private void viewOnlySkuForm()
        {
            txtName.ReadOnly = true;
            txtDescr.ReadOnly = true;
            txtUnitPrice.ReadOnly = true;
            txtInStock.ReadOnly = true;
            txtOnOrder.ReadOnly = true;
        }

        private void viewOnlyAddressForm()
        {
            txtADDescr.ReadOnly = true;
            txtADAddress1.ReadOnly = true;
            txtADAddress2.ReadOnly = true;
            txtADCity.ReadOnly = true;
            txtADState.ReadOnly = true;
            txtADZip.ReadOnly = true;
            txtADPhonePri.ReadOnly = true;
            txtADPhoneSec.ReadOnly = true;
            txtADEmail.ReadOnly = true;
        }

        private void updateSupplyFields()
        {

            DataTable dt = new DataTable();
            dt = Skus.getSkuByIDs(Convert.ToInt32(cbxSku.SelectedValue),
                                  Convert.ToInt32(cbxSkuType.SelectedValue)
                          );
            if (dt.Rows.Count == 0)
            {
                clearSkuForm();
                MessageBox.Show("SKU does not exist.", "SKU Invalid");
                btnModSupply.Visible = false;
            }
            else
            {
                foreach (DataRow col in dt.Rows)
                {
                    txtName.Text = Convert.ToString(col["Name"]);
                    txtDescr.Text = Convert.ToString(col["Descr"]);
                    txtUnitPrice.Text = Convert.ToString(col["UnitPrice"]);
                    txtInStock.Text = Convert.ToString(col["InStock"]);
                    txtOnOrder.Text = Convert.ToString(col["OnOrder"]);
                }
                btnModSupply.Visible = true;
            }
        }

        private void updateADFields()
        {

            DataTable dt = new DataTable();
            dt = Skus.getAddressByID((cbxADName.SelectedValue == null) ? 0 : Convert.ToInt32(cbxADName.SelectedValue)
                          );
            if (dt.Rows.Count == 0)
            {
                clearAddressForm();
                MessageBox.Show("Address does not exist.", "Address Invalid");
                btnModAddress.Visible = false;
            }
            else
            {
                foreach (DataRow col in dt.Rows)
                {
                    txtADDescr.Text = Convert.ToString(col["Descr"]);
                    txtADAddress1.Text = Convert.ToString(col["Address1"]);
                    txtADAddress2.Text = Convert.ToString(col["Address2"]);
                    txtADCity.Text = Convert.ToString(col["City"]);
                    txtADState.Text = Convert.ToString(col["State"]);
                    txtADZip.Text = Convert.ToString(col["Zip"]);
                    txtADPhonePri.Text = Convert.ToString(col["PhonePri"]);
                    txtADPhoneSec.Text = Convert.ToString(col["PhoneSec"]);
                    txtADEmail.Text = Convert.ToString(col["ContactEmail"]);
                }
                btnModAddress.Visible = true;
            }
        }

        private void updateLOCFields()
        {
            DataTable dt = new DataTable();
            dt = Skus.getLocationByID(Convert.ToInt32(cbxLocation.SelectedValue)
                          );
            if (dt.Rows.Count == 0)
            {
                clearAddressForm();
                MessageBox.Show("Address does not exist.", "Address Invalid");
                btnModAddress.Visible = false;
            }
            else
            {
                foreach (DataRow col in dt.Rows)
                {
                    txtADDescr.Text = Convert.ToString(col["Descr"]);
                    txtADAddress1.Text = Convert.ToString(col["Address1"]);
                    txtADAddress2.Text = Convert.ToString(col["Address2"]);
                    txtADCity.Text = Convert.ToString(col["City"]);
                    txtADState.Text = Convert.ToString(col["State"]);
                    txtADZip.Text = Convert.ToString(col["Zip"]);
                    txtADPhonePri.Text = Convert.ToString(col["PhonePri"]);
                    txtADPhoneSec.Text = Convert.ToString(col["PhoneSec"]);
                    txtADEmail.Text = Convert.ToString(col["ContactEmail"]);
                }
                btnModAddress.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (frmLocation == 0)
            {
                btnSearch.Text = "Hide Location";
                this.Width = 904;
                frmLocation = 1;

                AddressTypePickList = Skus.getAddressTypeList();
                cbxADName.DataSource = AddressTypePickList;
                cbxADName.DisplayMember = "Descr";
                cbxADName.ValueMember = "AddressID";
            }
            else if (frmLocation == 1)
            {
                btnSearch.Text = "Show Location";
                this.Width = 598;
                frmLocation = 0;
            }
        }

        private void SetupCanvasDGV()
        {
            DataTable dt = new DataTable();
            dt = Skus.getCanvasList();
            dgvCanvas.DataSource = dt;
        }

    }
}
