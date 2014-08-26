namespace CMAS
{
    partial class ExportData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExportData = new System.Windows.Forms.Button();
            this.gbxExportDataList = new System.Windows.Forms.GroupBox();
            this.ckbFiles = new System.Windows.Forms.CheckBox();
            this.ckbEventForm = new System.Windows.Forms.CheckBox();
            this.ckbEvent = new System.Windows.Forms.CheckBox();
            this.ckbCategory = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ckbAddress = new System.Windows.Forms.CheckBox();
            this.ckbForm = new System.Windows.Forms.CheckBox();
            this.ckbLog = new System.Windows.Forms.CheckBox();
            this.ckbMapOptions = new System.Windows.Forms.CheckBox();
            this.ckbMemo = new System.Windows.Forms.CheckBox();
            this.ckbPerson = new System.Windows.Forms.CheckBox();
            this.ckbPersonType = new System.Windows.Forms.CheckBox();
            this.ckbPin = new System.Windows.Forms.CheckBox();
            this.ckbSku = new System.Windows.Forms.CheckBox();
            this.ckbSkuType = new System.Windows.Forms.CheckBox();
            this.ckbLocation = new System.Windows.Forms.CheckBox();
            this.gbxExportDataList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportData
            // 
            this.btnExportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportData.Location = new System.Drawing.Point(209, 280);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(189, 31);
            this.btnExportData.TabIndex = 17;
            this.btnExportData.Text = "&Export Data";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExecuteDump_Click);
            // 
            // gbxExportDataList
            // 
            this.gbxExportDataList.Controls.Add(this.ckbLocation);
            this.gbxExportDataList.Controls.Add(this.ckbSkuType);
            this.gbxExportDataList.Controls.Add(this.ckbSku);
            this.gbxExportDataList.Controls.Add(this.ckbPin);
            this.gbxExportDataList.Controls.Add(this.ckbPersonType);
            this.gbxExportDataList.Controls.Add(this.ckbPerson);
            this.gbxExportDataList.Controls.Add(this.ckbMemo);
            this.gbxExportDataList.Controls.Add(this.ckbMapOptions);
            this.gbxExportDataList.Controls.Add(this.ckbLog);
            this.gbxExportDataList.Controls.Add(this.ckbForm);
            this.gbxExportDataList.Controls.Add(this.ckbFiles);
            this.gbxExportDataList.Controls.Add(this.ckbEventForm);
            this.gbxExportDataList.Controls.Add(this.ckbEvent);
            this.gbxExportDataList.Controls.Add(this.ckbCategory);
            this.gbxExportDataList.Controls.Add(this.lblTitle);
            this.gbxExportDataList.Controls.Add(this.ckbAddress);
            this.gbxExportDataList.Controls.Add(this.btnExportData);
            this.gbxExportDataList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxExportDataList.Location = new System.Drawing.Point(12, 6);
            this.gbxExportDataList.Name = "gbxExportDataList";
            this.gbxExportDataList.Size = new System.Drawing.Size(412, 326);
            this.gbxExportDataList.TabIndex = 1;
            this.gbxExportDataList.TabStop = false;
            this.gbxExportDataList.Text = "Export Data Tables:";
            // 
            // ckbFiles
            // 
            this.ckbFiles.AutoSize = true;
            this.ckbFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFiles.Location = new System.Drawing.Point(6, 181);
            this.ckbFiles.Name = "ckbFiles";
            this.ckbFiles.Size = new System.Drawing.Size(122, 28);
            this.ckbFiles.TabIndex = 6;
            this.ckbFiles.Tag = "Files";
            this.ckbFiles.Text = "Files Table";
            this.ckbFiles.UseVisualStyleBackColor = true;
            // 
            // ckbEventForm
            // 
            this.ckbEventForm.AutoSize = true;
            this.ckbEventForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEventForm.Location = new System.Drawing.Point(6, 147);
            this.ckbEventForm.Name = "ckbEventForm";
            this.ckbEventForm.Size = new System.Drawing.Size(180, 28);
            this.ckbEventForm.TabIndex = 5;
            this.ckbEventForm.Tag = "EventForm";
            this.ckbEventForm.Text = "Event Form Table";
            this.ckbEventForm.UseVisualStyleBackColor = true;
            // 
            // ckbEvent
            // 
            this.ckbEvent.AutoSize = true;
            this.ckbEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEvent.Location = new System.Drawing.Point(6, 113);
            this.ckbEvent.Name = "ckbEvent";
            this.ckbEvent.Size = new System.Drawing.Size(130, 28);
            this.ckbEvent.TabIndex = 4;
            this.ckbEvent.Tag = "Event";
            this.ckbEvent.Text = "Event Table";
            this.ckbEvent.UseVisualStyleBackColor = true;
            // 
            // ckbCategory
            // 
            this.ckbCategory.AutoSize = true;
            this.ckbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbCategory.Location = new System.Drawing.Point(6, 79);
            this.ckbCategory.Name = "ckbCategory";
            this.ckbCategory.Size = new System.Drawing.Size(157, 28);
            this.ckbCategory.TabIndex = 3;
            this.ckbCategory.Tag = "Category";
            this.ckbCategory.Text = "Category Table";
            this.ckbCategory.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(7, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Check the checkboxes next to the tables that you wish to save to your desktop. ";
            // 
            // ckbAddress
            // 
            this.ckbAddress.AutoSize = true;
            this.ckbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAddress.Location = new System.Drawing.Point(6, 45);
            this.ckbAddress.Name = "ckbAddress";
            this.ckbAddress.Size = new System.Drawing.Size(152, 28);
            this.ckbAddress.TabIndex = 1;
            this.ckbAddress.Tag = "Address";
            this.ckbAddress.Text = "Address Table";
            this.ckbAddress.UseVisualStyleBackColor = true;
            // 
            // ckbForm
            // 
            this.ckbForm.AutoSize = true;
            this.ckbForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbForm.Location = new System.Drawing.Point(6, 215);
            this.ckbForm.Name = "ckbForm";
            this.ckbForm.Size = new System.Drawing.Size(127, 28);
            this.ckbForm.TabIndex = 7;
            this.ckbForm.Tag = "Form";
            this.ckbForm.Text = "Form Table";
            this.ckbForm.UseVisualStyleBackColor = true;
            // 
            // ckbLog
            // 
            this.ckbLog.AutoSize = true;
            this.ckbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLog.Location = new System.Drawing.Point(6, 283);
            this.ckbLog.Name = "ckbLog";
            this.ckbLog.Size = new System.Drawing.Size(114, 28);
            this.ckbLog.TabIndex = 9;
            this.ckbLog.Tag = "Log";
            this.ckbLog.Text = "Log Table";
            this.ckbLog.UseVisualStyleBackColor = true;
            // 
            // ckbMapOptions
            // 
            this.ckbMapOptions.AutoSize = true;
            this.ckbMapOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMapOptions.Location = new System.Drawing.Point(209, 45);
            this.ckbMapOptions.Name = "ckbMapOptions";
            this.ckbMapOptions.Size = new System.Drawing.Size(189, 28);
            this.ckbMapOptions.TabIndex = 10;
            this.ckbMapOptions.Tag = "MapOptions";
            this.ckbMapOptions.Text = "Map Options Table";
            this.ckbMapOptions.UseVisualStyleBackColor = true;
            // 
            // ckbMemo
            // 
            this.ckbMemo.AutoSize = true;
            this.ckbMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMemo.Location = new System.Drawing.Point(209, 79);
            this.ckbMemo.Name = "ckbMemo";
            this.ckbMemo.Size = new System.Drawing.Size(136, 28);
            this.ckbMemo.TabIndex = 11;
            this.ckbMemo.Tag = "Memo";
            this.ckbMemo.Text = "Memo Table";
            this.ckbMemo.UseVisualStyleBackColor = true;
            // 
            // ckbPerson
            // 
            this.ckbPerson.AutoSize = true;
            this.ckbPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPerson.Location = new System.Drawing.Point(209, 113);
            this.ckbPerson.Name = "ckbPerson";
            this.ckbPerson.Size = new System.Drawing.Size(142, 28);
            this.ckbPerson.TabIndex = 12;
            this.ckbPerson.Tag = "Person";
            this.ckbPerson.Text = "Person Table";
            this.ckbPerson.UseVisualStyleBackColor = true;
            // 
            // ckbPersonType
            // 
            this.ckbPersonType.AutoSize = true;
            this.ckbPersonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPersonType.Location = new System.Drawing.Point(209, 147);
            this.ckbPersonType.Name = "ckbPersonType";
            this.ckbPersonType.Size = new System.Drawing.Size(190, 28);
            this.ckbPersonType.TabIndex = 13;
            this.ckbPersonType.Tag = "PersonType";
            this.ckbPersonType.Text = "Person Type Table";
            this.ckbPersonType.UseVisualStyleBackColor = true;
            // 
            // ckbPin
            // 
            this.ckbPin.AutoSize = true;
            this.ckbPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPin.Location = new System.Drawing.Point(209, 181);
            this.ckbPin.Name = "ckbPin";
            this.ckbPin.Size = new System.Drawing.Size(109, 28);
            this.ckbPin.TabIndex = 14;
            this.ckbPin.Tag = "Pin";
            this.ckbPin.Text = "Pin Table";
            this.ckbPin.UseVisualStyleBackColor = true;
            // 
            // ckbSku
            // 
            this.ckbSku.AutoSize = true;
            this.ckbSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSku.Location = new System.Drawing.Point(209, 215);
            this.ckbSku.Name = "ckbSku";
            this.ckbSku.Size = new System.Drawing.Size(114, 28);
            this.ckbSku.TabIndex = 15;
            this.ckbSku.Tag = "Sku";
            this.ckbSku.Text = "Sku Table";
            this.ckbSku.UseVisualStyleBackColor = true;
            // 
            // ckbSkuType
            // 
            this.ckbSkuType.AutoSize = true;
            this.ckbSkuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSkuType.Location = new System.Drawing.Point(209, 249);
            this.ckbSkuType.Name = "ckbSkuType";
            this.ckbSkuType.Size = new System.Drawing.Size(162, 28);
            this.ckbSkuType.TabIndex = 16;
            this.ckbSkuType.Tag = "SkuType";
            this.ckbSkuType.Text = "Sku Type Table";
            this.ckbSkuType.UseVisualStyleBackColor = true;
            // 
            // ckbLocation
            // 
            this.ckbLocation.AutoSize = true;
            this.ckbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLocation.Location = new System.Drawing.Point(6, 249);
            this.ckbLocation.Name = "ckbLocation";
            this.ckbLocation.Size = new System.Drawing.Size(153, 28);
            this.ckbLocation.TabIndex = 8;
            this.ckbLocation.Tag = "Location";
            this.ckbLocation.Text = "Location Table";
            this.ckbLocation.UseVisualStyleBackColor = true;
            // 
            // ExportData
            // 
            this.AcceptButton = this.btnExportData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 346);
            this.Controls.Add(this.gbxExportDataList);
            this.Name = "ExportData";
            this.ShowIcon = false;
            this.Text = "Export Data";
            this.gbxExportDataList.ResumeLayout(false);
            this.gbxExportDataList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportData;
        private System.Windows.Forms.GroupBox gbxExportDataList;
        private System.Windows.Forms.CheckBox ckbAddress;
        private System.Windows.Forms.CheckBox ckbFiles;
        private System.Windows.Forms.CheckBox ckbEventForm;
        private System.Windows.Forms.CheckBox ckbEvent;
        private System.Windows.Forms.CheckBox ckbCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox ckbLocation;
        private System.Windows.Forms.CheckBox ckbSkuType;
        private System.Windows.Forms.CheckBox ckbSku;
        private System.Windows.Forms.CheckBox ckbPin;
        private System.Windows.Forms.CheckBox ckbPersonType;
        private System.Windows.Forms.CheckBox ckbPerson;
        private System.Windows.Forms.CheckBox ckbMemo;
        private System.Windows.Forms.CheckBox ckbMapOptions;
        private System.Windows.Forms.CheckBox ckbLog;
        private System.Windows.Forms.CheckBox ckbForm;
    }
}