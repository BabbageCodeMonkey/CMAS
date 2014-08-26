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
    public partial class ExportData : Form
    {
        public ExportData()
        {
            InitializeComponent();
        }


        private void btnExecuteDump_Click(object sender, EventArgs e)
        {
            string[,] tables;

            string[] exported = BusinessLayer.DataDump.ExportTables(
                tables = new string[15,2]
                {
                    { ckbAddress.Checked.ToString(), ckbAddress.Tag.ToString()}, 
                    { ckbCategory.Checked.ToString(), ckbCategory.Tag.ToString()},
                    { ckbEvent.Checked.ToString(), ckbEvent.Tag.ToString()}, 
                    { ckbEventForm.Checked.ToString(), ckbEventForm.Tag.ToString()},
                    { ckbFiles.Checked.ToString(), ckbFiles.Tag.ToString()}, 
                    { ckbForm.Checked.ToString(), ckbForm.Tag.ToString()},
                    { ckbLocation.Checked.ToString(), ckbLocation.Tag.ToString()},
                    { ckbLog.Checked.ToString(), ckbLog.Tag.ToString()}, 
                    { ckbMapOptions.Checked.ToString(), ckbMapOptions.Tag.ToString()},
                    { ckbMemo.Checked.ToString(), ckbMemo.Tag.ToString()}, 
                    { ckbPerson.Checked.ToString(), ckbPerson.Tag.ToString()},
                    { ckbPersonType.Checked.ToString(), ckbPersonType.Tag.ToString()}, 
                    { ckbPin.Checked.ToString(), ckbPin.Checked.ToString()},
                    { ckbSku.Checked.ToString(), ckbSku.Tag.ToString()},
                    { ckbSkuType.Checked.ToString(), ckbSkuType.Tag.ToString()}
                });

            String display = "\n";
            foreach(string i in exported)
                {
                    if (i != null)
                    {
                        display = display + i + ".csv\n";
                    }
                }
            MessageBox.Show("The following data has been exported to your desktop and is in the file(s) " + display,"Data Dumped");
        }

    }
}
