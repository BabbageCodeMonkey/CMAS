namespace CMAS
{
    partial class Map
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbCanvas = new System.Windows.Forms.CheckBox();
            this.cbContrib = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(13, 13);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(850, 619);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(804, 608);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbCanvas
            // 
            this.cbCanvas.AutoSize = true;
            this.cbCanvas.Location = new System.Drawing.Point(804, 562);
            this.cbCanvas.Name = "cbCanvas";
            this.cbCanvas.Size = new System.Drawing.Size(62, 17);
            this.cbCanvas.TabIndex = 2;
            this.cbCanvas.Text = "Canvas";
            this.cbCanvas.UseVisualStyleBackColor = true;
            this.cbCanvas.CheckedChanged += new System.EventHandler(this.cbCanvas_CheckedChanged);
            // 
            // cbContrib
            // 
            this.cbContrib.AutoSize = true;
            this.cbContrib.Location = new System.Drawing.Point(804, 585);
            this.cbContrib.Name = "cbContrib";
            this.cbContrib.Size = new System.Drawing.Size(77, 17);
            this.cbContrib.TabIndex = 3;
            this.cbContrib.Text = "Contributor";
            this.cbContrib.UseVisualStyleBackColor = true;
            this.cbContrib.CheckedChanged += new System.EventHandler(this.cbContrib_CheckedChanged);
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 655);
            this.Controls.Add(this.cbContrib);
            this.Controls.Add(this.cbCanvas);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gMapControl1);
            this.Name = "Map";
            this.Text = "Map";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox cbCanvas;
        private System.Windows.Forms.CheckBox cbContrib;
    }
}