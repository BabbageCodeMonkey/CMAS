namespace CMAS
{
    partial class UpdateEvent
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.cboLoc = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEvent = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(216, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 21;
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Location = new System.Drawing.Point(216, 76);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(121, 21);
            this.cboUser.TabIndex = 20;
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(216, 45);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(121, 21);
            this.cboCat.TabIndex = 19;
            // 
            // cboLoc
            // 
            this.cboLoc.FormattingEnabled = true;
            this.cboLoc.Location = new System.Drawing.Point(216, 20);
            this.cboLoc.Name = "cboLoc";
            this.cboLoc.Size = new System.Drawing.Size(121, 21);
            this.cboLoc.TabIndex = 18;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(286, 218);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Update";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(125, 144);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Location:";
            // 
            // dgvEvent
            // 
            this.dgvEvent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvent.Location = new System.Drawing.Point(60, 247);
            this.dgvEvent.Name = "dgvEvent";
            this.dgvEvent.Size = new System.Drawing.Size(301, 157);
            this.dgvEvent.TabIndex = 22;
            this.dgvEvent.SelectionChanged += new System.EventHandler(this.dgvEvent_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(60, 218);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // rdoActive
            // 
            this.rdoActive.AutoSize = true;
            this.rdoActive.Location = new System.Drawing.Point(252, 183);
            this.rdoActive.Name = "rdoActive";
            this.rdoActive.Size = new System.Drawing.Size(55, 17);
            this.rdoActive.TabIndex = 24;
            this.rdoActive.TabStop = true;
            this.rdoActive.Text = "Active";
            this.rdoActive.UseVisualStyleBackColor = true;
            this.rdoActive.Click += new System.EventHandler(this.rdoActive_Click);
            // 
            // UpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 435);
            this.Controls.Add(this.rdoActive);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvEvent);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cboUser);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.cboLoc);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateEvent";
            this.Text = "UpdateEvent";
            this.Load += new System.EventHandler(this.UpdateEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.ComboBox cboLoc;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEvent;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoActive;
    }
}