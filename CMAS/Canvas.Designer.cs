namespace CMAS
{
    partial class Canvas
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
            this.components = new System.ComponentModel.Container();
            this.lblSku = new System.Windows.Forms.Label();
            this.lblSkuType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescr = new System.Windows.Forms.TextBox();
            this.lblDescr = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtInStock = new System.Windows.Forms.TextBox();
            this.lblInStock = new System.Windows.Forms.Label();
            this.txtOnOrder = new System.Windows.Forms.TextBox();
            this.lblOnOrder = new System.Windows.Forms.Label();
            this.lblSupply = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnModSupply = new System.Windows.Forms.Button();
            this.lblCanvas = new System.Windows.Forms.Label();
            this.dgvCanvas = new System.Windows.Forms.DataGridView();
            this.spGetCanvasListBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.cMASDataSet = new CMAS.CMASDataSet();
            this.btnModCanvas = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtADAddress2 = new System.Windows.Forms.TextBox();
            this.lblADAddress2 = new System.Windows.Forms.Label();
            this.txtADAddress1 = new System.Windows.Forms.TextBox();
            this.lblADAddress1 = new System.Windows.Forms.Label();
            this.txtADDescr = new System.Windows.Forms.TextBox();
            this.lblADDescr = new System.Windows.Forms.Label();
            this.txtADZip = new System.Windows.Forms.TextBox();
            this.lblADZip = new System.Windows.Forms.Label();
            this.txtADState = new System.Windows.Forms.TextBox();
            this.lblADState = new System.Windows.Forms.Label();
            this.txtADCity = new System.Windows.Forms.TextBox();
            this.lblADCity = new System.Windows.Forms.Label();
            this.txtADEmail = new System.Windows.Forms.TextBox();
            this.lblADEmail = new System.Windows.Forms.Label();
            this.txtADPhoneSec = new System.Windows.Forms.TextBox();
            this.lblADPhoneSec = new System.Windows.Forms.Label();
            this.txtADPhonePri = new System.Windows.Forms.TextBox();
            this.lblADPhonePri = new System.Windows.Forms.Label();
            this.btnModAddress = new System.Windows.Forms.Button();
            this.gbxADLocation = new System.Windows.Forms.GroupBox();
            this.btnLink2 = new System.Windows.Forms.Button();
            this.cbxLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cbxADName = new System.Windows.Forms.ComboBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbxSkuType = new System.Windows.Forms.ComboBox();
            this.cbxSku = new System.Windows.Forms.ComboBox();
            //this.sp_GetCanvasListTableAdapter = new CMAS.CMASDataSetTableAdapters.sp_GetCanvasListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCanvasListBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.cMASDataSet)).BeginInit();
            this.gbxADLocation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSku.Location = new System.Drawing.Point(14, 35);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(50, 20);
            this.lblSku.TabIndex = 0;
            this.lblSku.Text = "SKU: ";
            // 
            // lblSkuType
            // 
            this.lblSkuType.AutoSize = true;
            this.lblSkuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkuType.Location = new System.Drawing.Point(14, 67);
            this.lblSkuType.Name = "lblSkuType";
            this.lblSkuType.Size = new System.Drawing.Size(88, 20);
            this.lblSkuType.TabIndex = 2;
            this.lblSkuType.Text = "SKU Type: ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(121, 96);
            this.txtName.MaxLength = 99;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 26);
            this.txtName.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(14, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name: ";
            // 
            // txtDescr
            // 
            this.txtDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescr.Location = new System.Drawing.Point(121, 128);
            this.txtDescr.MaxLength = 249;
            this.txtDescr.Name = "txtDescr";
            this.txtDescr.Size = new System.Drawing.Size(163, 26);
            this.txtDescr.TabIndex = 7;
            // 
            // lblDescr
            // 
            this.lblDescr.AutoSize = true;
            this.lblDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescr.Location = new System.Drawing.Point(14, 131);
            this.lblDescr.Name = "lblDescr";
            this.lblDescr.Size = new System.Drawing.Size(97, 20);
            this.lblDescr.TabIndex = 6;
            this.lblDescr.Text = "Description: ";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(408, 32);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(163, 26);
            this.txtUnitPrice.TabIndex = 9;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(301, 35);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(85, 20);
            this.lblUnitPrice.TabIndex = 8;
            this.lblUnitPrice.Text = "Unit Price: ";
            // 
            // txtInStock
            // 
            this.txtInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInStock.Location = new System.Drawing.Point(408, 64);
            this.txtInStock.Name = "txtInStock";
            this.txtInStock.Size = new System.Drawing.Size(163, 26);
            this.txtInStock.TabIndex = 11;
            // 
            // lblInStock
            // 
            this.lblInStock.AutoSize = true;
            this.lblInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInStock.Location = new System.Drawing.Point(301, 67);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(76, 20);
            this.lblInStock.TabIndex = 10;
            this.lblInStock.Text = "In Stock: ";
            // 
            // txtOnOrder
            // 
            this.txtOnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnOrder.Location = new System.Drawing.Point(408, 96);
            this.txtOnOrder.Name = "txtOnOrder";
            this.txtOnOrder.Size = new System.Drawing.Size(163, 26);
            this.txtOnOrder.TabIndex = 13;
            // 
            // lblOnOrder
            // 
            this.lblOnOrder.AutoSize = true;
            this.lblOnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnOrder.Location = new System.Drawing.Point(301, 99);
            this.lblOnOrder.Name = "lblOnOrder";
            this.lblOnOrder.Size = new System.Drawing.Size(82, 20);
            this.lblOnOrder.TabIndex = 12;
            this.lblOnOrder.Text = "On Order: ";
            // 
            // lblSupply
            // 
            this.lblSupply.AutoSize = true;
            this.lblSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupply.Location = new System.Drawing.Point(3, 3);
            this.lblSupply.Name = "lblSupply";
            this.lblSupply.Size = new System.Drawing.Size(83, 24);
            this.lblSupply.TabIndex = 14;
            this.lblSupply.Text = "Supplies";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(888, 442);
            this.shapeContainer1.TabIndex = 15;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 588;
            this.lineShape2.X2 = 588;
            this.lineShape2.Y1 = 18;
            this.lineShape2.Y2 = 421;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 18;
            this.lineShape1.X2 = 571;
            this.lineShape1.Y1 = 172;
            this.lineShape1.Y2 = 172;
            // 
            // btnModSupply
            // 
            this.btnModSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModSupply.Location = new System.Drawing.Point(409, 131);
            this.btnModSupply.Name = "btnModSupply";
            this.btnModSupply.Size = new System.Drawing.Size(163, 26);
            this.btnModSupply.TabIndex = 16;
            this.btnModSupply.Text = "Mod";
            this.btnModSupply.UseVisualStyleBackColor = true;
            this.btnModSupply.Click += new System.EventHandler(this.btnModSupply_Click);
            // 
            // lblCanvas
            // 
            this.lblCanvas.AutoSize = true;
            this.lblCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanvas.Location = new System.Drawing.Point(3, 176);
            this.lblCanvas.Name = "lblCanvas";
            this.lblCanvas.Size = new System.Drawing.Size(72, 24);
            this.lblCanvas.TabIndex = 17;
            this.lblCanvas.Text = "Canvas";
            // 
            // dgvCanvas
            // 
            this.dgvCanvas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanvas.Location = new System.Drawing.Point(12, 208);
            this.dgvCanvas.Name = "dgvCanvas";
            this.dgvCanvas.Size = new System.Drawing.Size(554, 203);
            this.dgvCanvas.TabIndex = 18;
            // 
            // spGetCanvasListBindingSource
            // 
            this.spGetCanvasListBindingSource.DataMember = "sp_GetCanvasList";
            //this.spGetCanvasListBindingSource.DataSource = this.cMASDataSet;
            // 
            // cMASDataSet
            // 
            //this.cMASDataSet.DataSetName = "CMASDataSet";
            //this.cMASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnModCanvas
            // 
            this.btnModCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModCanvas.Location = new System.Drawing.Point(408, 413);
            this.btnModCanvas.Name = "btnModCanvas";
            this.btnModCanvas.Size = new System.Drawing.Size(163, 26);
            this.btnModCanvas.TabIndex = 19;
            this.btnModCanvas.Text = "Mod";
            this.btnModCanvas.UseVisualStyleBackColor = true;
            this.btnModCanvas.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(6, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(85, 24);
            this.lblAddress.TabIndex = 28;
            this.lblAddress.Text = "Address:";
            // 
            // txtADAddress2
            // 
            this.txtADAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADAddress2.Location = new System.Drawing.Point(113, 182);
            this.txtADAddress2.Name = "txtADAddress2";
            this.txtADAddress2.Size = new System.Drawing.Size(163, 26);
            this.txtADAddress2.TabIndex = 27;
            // 
            // lblADAddress2
            // 
            this.lblADAddress2.AutoSize = true;
            this.lblADAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADAddress2.Location = new System.Drawing.Point(6, 185);
            this.lblADAddress2.Name = "lblADAddress2";
            this.lblADAddress2.Size = new System.Drawing.Size(85, 20);
            this.lblADAddress2.TabIndex = 26;
            this.lblADAddress2.Text = "Address2: ";
            // 
            // txtADAddress1
            // 
            this.txtADAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADAddress1.Location = new System.Drawing.Point(113, 150);
            this.txtADAddress1.Name = "txtADAddress1";
            this.txtADAddress1.Size = new System.Drawing.Size(163, 26);
            this.txtADAddress1.TabIndex = 25;
            // 
            // lblADAddress1
            // 
            this.lblADAddress1.AutoSize = true;
            this.lblADAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADAddress1.Location = new System.Drawing.Point(6, 153);
            this.lblADAddress1.Name = "lblADAddress1";
            this.lblADAddress1.Size = new System.Drawing.Size(85, 20);
            this.lblADAddress1.TabIndex = 24;
            this.lblADAddress1.Text = "Address1: ";
            // 
            // txtADDescr
            // 
            this.txtADDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDescr.Location = new System.Drawing.Point(113, 118);
            this.txtADDescr.Name = "txtADDescr";
            this.txtADDescr.Size = new System.Drawing.Size(163, 26);
            this.txtADDescr.TabIndex = 23;
            // 
            // lblADDescr
            // 
            this.lblADDescr.AutoSize = true;
            this.lblADDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADDescr.Location = new System.Drawing.Point(6, 121);
            this.lblADDescr.Name = "lblADDescr";
            this.lblADDescr.Size = new System.Drawing.Size(97, 20);
            this.lblADDescr.TabIndex = 22;
            this.lblADDescr.Text = "Description: ";
            // 
            // txtADZip
            // 
            this.txtADZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADZip.Location = new System.Drawing.Point(113, 278);
            this.txtADZip.Name = "txtADZip";
            this.txtADZip.Size = new System.Drawing.Size(163, 26);
            this.txtADZip.TabIndex = 34;
            // 
            // lblADZip
            // 
            this.lblADZip.AutoSize = true;
            this.lblADZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADZip.Location = new System.Drawing.Point(6, 281);
            this.lblADZip.Name = "lblADZip";
            this.lblADZip.Size = new System.Drawing.Size(39, 20);
            this.lblADZip.TabIndex = 33;
            this.lblADZip.Text = "Zip: ";
            // 
            // txtADState
            // 
            this.txtADState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADState.Location = new System.Drawing.Point(113, 246);
            this.txtADState.Name = "txtADState";
            this.txtADState.Size = new System.Drawing.Size(163, 26);
            this.txtADState.TabIndex = 32;
            // 
            // lblADState
            // 
            this.lblADState.AutoSize = true;
            this.lblADState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADState.Location = new System.Drawing.Point(6, 249);
            this.lblADState.Name = "lblADState";
            this.lblADState.Size = new System.Drawing.Size(56, 20);
            this.lblADState.TabIndex = 31;
            this.lblADState.Text = "State: ";
            // 
            // txtADCity
            // 
            this.txtADCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADCity.Location = new System.Drawing.Point(113, 214);
            this.txtADCity.Name = "txtADCity";
            this.txtADCity.Size = new System.Drawing.Size(163, 26);
            this.txtADCity.TabIndex = 30;
            // 
            // lblADCity
            // 
            this.lblADCity.AutoSize = true;
            this.lblADCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADCity.Location = new System.Drawing.Point(6, 217);
            this.lblADCity.Name = "lblADCity";
            this.lblADCity.Size = new System.Drawing.Size(43, 20);
            this.lblADCity.TabIndex = 29;
            this.lblADCity.Text = "City: ";
            // 
            // txtADEmail
            // 
            this.txtADEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADEmail.Location = new System.Drawing.Point(113, 374);
            this.txtADEmail.Name = "txtADEmail";
            this.txtADEmail.Size = new System.Drawing.Size(163, 26);
            this.txtADEmail.TabIndex = 40;
            // 
            // lblADEmail
            // 
            this.lblADEmail.AutoSize = true;
            this.lblADEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADEmail.Location = new System.Drawing.Point(6, 377);
            this.lblADEmail.Name = "lblADEmail";
            this.lblADEmail.Size = new System.Drawing.Size(56, 20);
            this.lblADEmail.TabIndex = 39;
            this.lblADEmail.Text = "Email: ";
            // 
            // txtADPhoneSec
            // 
            this.txtADPhoneSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADPhoneSec.Location = new System.Drawing.Point(113, 342);
            this.txtADPhoneSec.Name = "txtADPhoneSec";
            this.txtADPhoneSec.Size = new System.Drawing.Size(163, 26);
            this.txtADPhoneSec.TabIndex = 38;
            // 
            // lblADPhoneSec
            // 
            this.lblADPhoneSec.AutoSize = true;
            this.lblADPhoneSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADPhoneSec.Location = new System.Drawing.Point(6, 345);
            this.lblADPhoneSec.Name = "lblADPhoneSec";
            this.lblADPhoneSec.Size = new System.Drawing.Size(101, 20);
            this.lblADPhoneSec.TabIndex = 37;
            this.lblADPhoneSec.Text = "Phone(Sec): ";
            // 
            // txtADPhonePri
            // 
            this.txtADPhonePri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADPhonePri.Location = new System.Drawing.Point(113, 310);
            this.txtADPhonePri.Name = "txtADPhonePri";
            this.txtADPhonePri.Size = new System.Drawing.Size(163, 26);
            this.txtADPhonePri.TabIndex = 36;
            // 
            // lblADPhonePri
            // 
            this.lblADPhonePri.AutoSize = true;
            this.lblADPhonePri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADPhonePri.Location = new System.Drawing.Point(6, 313);
            this.lblADPhonePri.Name = "lblADPhonePri";
            this.lblADPhonePri.Size = new System.Drawing.Size(91, 20);
            this.lblADPhonePri.TabIndex = 35;
            this.lblADPhonePri.Text = "Phone(Pri): ";
            // 
            // btnModAddress
            // 
            this.btnModAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModAddress.Location = new System.Drawing.Point(113, 406);
            this.btnModAddress.Name = "btnModAddress";
            this.btnModAddress.Size = new System.Drawing.Size(163, 26);
            this.btnModAddress.TabIndex = 41;
            this.btnModAddress.Text = "Mod";
            this.btnModAddress.UseVisualStyleBackColor = true;
            this.btnModAddress.Click += new System.EventHandler(this.btnModAddress_Click);
            // 
            // gbxADLocation
            // 
            this.gbxADLocation.Controls.Add(this.btnLink2);
            this.gbxADLocation.Controls.Add(this.cbxLocation);
            this.gbxADLocation.Controls.Add(this.lblLocation);
            this.gbxADLocation.Controls.Add(this.cbxADName);
            this.gbxADLocation.Controls.Add(this.lblAddress);
            this.gbxADLocation.Controls.Add(this.btnModAddress);
            this.gbxADLocation.Controls.Add(this.txtADEmail);
            this.gbxADLocation.Controls.Add(this.lblADEmail);
            this.gbxADLocation.Controls.Add(this.lblADDescr);
            this.gbxADLocation.Controls.Add(this.txtADPhoneSec);
            this.gbxADLocation.Controls.Add(this.txtADDescr);
            this.gbxADLocation.Controls.Add(this.lblADPhoneSec);
            this.gbxADLocation.Controls.Add(this.lblADAddress1);
            this.gbxADLocation.Controls.Add(this.txtADPhonePri);
            this.gbxADLocation.Controls.Add(this.txtADAddress1);
            this.gbxADLocation.Controls.Add(this.lblADPhonePri);
            this.gbxADLocation.Controls.Add(this.lblADAddress2);
            this.gbxADLocation.Controls.Add(this.txtADZip);
            this.gbxADLocation.Controls.Add(this.txtADAddress2);
            this.gbxADLocation.Controls.Add(this.lblADZip);
            this.gbxADLocation.Controls.Add(this.lblADCity);
            this.gbxADLocation.Controls.Add(this.txtADState);
            this.gbxADLocation.Controls.Add(this.txtADCity);
            this.gbxADLocation.Controls.Add(this.lblADState);
            this.gbxADLocation.Controls.Add(this.shapeContainer2);
            this.gbxADLocation.Location = new System.Drawing.Point(599, 0);
            this.gbxADLocation.Name = "gbxADLocation";
            this.gbxADLocation.Size = new System.Drawing.Size(285, 439);
            this.gbxADLocation.TabIndex = 42;
            this.gbxADLocation.TabStop = false;
            // 
            // btnLink2
            // 
            this.btnLink2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLink2.Location = new System.Drawing.Point(113, 47);
            this.btnLink2.Name = "btnLink2";
            this.btnLink2.Size = new System.Drawing.Size(163, 26);
            this.btnLink2.TabIndex = 47;
            this.btnLink2.Text = "Link Address";
            this.btnLink2.UseVisualStyleBackColor = true;
            this.btnLink2.Click += new System.EventHandler(this.btnLink_Click_1);
            // 
            // cbxLocation
            // 
            this.cbxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLocation.FormattingEnabled = true;
            this.cbxLocation.Location = new System.Drawing.Point(113, 16);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Size = new System.Drawing.Size(163, 28);
            this.cbxLocation.TabIndex = 45;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(6, 16);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(86, 24);
            this.lblLocation.TabIndex = 46;
            this.lblLocation.Text = "Location:";
            // 
            // cbxADName
            // 
            this.cbxADName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxADName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxADName.FormattingEnabled = true;
            this.cbxADName.Location = new System.Drawing.Point(113, 85);
            this.cbxADName.Name = "cbxADName";
            this.cbxADName.Size = new System.Drawing.Size(163, 28);
            this.cbxADName.TabIndex = 21;
            this.cbxADName.SelectedValueChanged += new System.EventHandler(this.cbxADName_SelectedValueChanged);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(279, 420);
            this.shapeContainer2.TabIndex = 48;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = -1;
            this.lineShape3.X2 = 278;
            this.lineShape3.Y1 = 61;
            this.lineShape3.Y2 = 61;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(200, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 26);
            this.textBox1.TabIndex = 43;
            this.textBox1.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(479, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 26);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Show Location";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbxSkuType
            // 
            this.cbxSkuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSkuType.FormattingEnabled = true;
            this.cbxSkuType.Location = new System.Drawing.Point(121, 64);
            this.cbxSkuType.Name = "cbxSkuType";
            this.cbxSkuType.Size = new System.Drawing.Size(163, 28);
            this.cbxSkuType.TabIndex = 3;
            this.cbxSkuType.SelectedValueChanged += new System.EventHandler(this.cbxSkuType_SelectedValueChanged);
            // 
            // cbxSku
            // 
            this.cbxSku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSku.FormattingEnabled = true;
            this.cbxSku.Location = new System.Drawing.Point(121, 32);
            this.cbxSku.Name = "cbxSku";
            this.cbxSku.Size = new System.Drawing.Size(163, 28);
            this.cbxSku.TabIndex = 1;
            this.cbxSku.SelectedValueChanged += new System.EventHandler(this.cbxSku_SelectedValueChanged);
            // 
            // sp_GetCanvasListTableAdapter
            // 
            //this.sp_GetCanvasListTableAdapter.ClearBeforeFill = true;
            // 
            // Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 442);
            this.Controls.Add(this.cbxSku);
            this.Controls.Add(this.cbxSkuType);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gbxADLocation);
            this.Controls.Add(this.btnModCanvas);
            this.Controls.Add(this.dgvCanvas);
            this.Controls.Add(this.lblCanvas);
            this.Controls.Add(this.btnModSupply);
            this.Controls.Add(this.lblSupply);
            this.Controls.Add(this.txtOnOrder);
            this.Controls.Add(this.lblOnOrder);
            this.Controls.Add(this.txtInStock);
            this.Controls.Add(this.lblInStock);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtDescr);
            this.Controls.Add(this.lblDescr);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSkuType);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Canvas";
            this.ShowIcon = false;
            this.Text = "Canvas";
            this.Load += new System.EventHandler(this.Canvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spGetCanvasListBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.cMASDataSet)).EndInit();
            this.gbxADLocation.ResumeLayout(false);
            this.gbxADLocation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.Label lblSkuType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDescr;
        private System.Windows.Forms.Label lblDescr;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtInStock;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.TextBox txtOnOrder;
        private System.Windows.Forms.Label lblOnOrder;
        private System.Windows.Forms.Label lblSupply;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btnModSupply;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Label lblCanvas;
        private System.Windows.Forms.DataGridView dgvCanvas;
        private System.Windows.Forms.Button btnModCanvas;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtADAddress2;
        private System.Windows.Forms.Label lblADAddress2;
        private System.Windows.Forms.TextBox txtADAddress1;
        private System.Windows.Forms.Label lblADAddress1;
        private System.Windows.Forms.TextBox txtADDescr;
        private System.Windows.Forms.Label lblADDescr;
        private System.Windows.Forms.TextBox txtADZip;
        private System.Windows.Forms.Label lblADZip;
        private System.Windows.Forms.TextBox txtADState;
        private System.Windows.Forms.Label lblADState;
        private System.Windows.Forms.TextBox txtADCity;
        private System.Windows.Forms.Label lblADCity;
        private System.Windows.Forms.TextBox txtADEmail;
        private System.Windows.Forms.Label lblADEmail;
        private System.Windows.Forms.TextBox txtADPhoneSec;
        private System.Windows.Forms.Label lblADPhoneSec;
        private System.Windows.Forms.TextBox txtADPhonePri;
        private System.Windows.Forms.Label lblADPhonePri;
        private System.Windows.Forms.Button btnModAddress;
        private System.Windows.Forms.GroupBox gbxADLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbxSkuType;
        private System.Windows.Forms.ComboBox cbxADName;
        private System.Windows.Forms.ComboBox cbxSku;
        private System.Windows.Forms.ComboBox cbxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnLink2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
       // private CMASDataSet cMASDataSet;
        private System.Windows.Forms.BindingSource spGetCanvasListBindingSource;
       // private CMASDataSetTableAdapters.sp_GetCanvasListTableAdapter sp_GetCanvasListTableAdapter;
    }
}