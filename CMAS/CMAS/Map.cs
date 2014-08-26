using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Diagnostics;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;


namespace CMAS
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void Map_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gMapControl1_Load_1(object sender, EventArgs e)
        {

            //Set the map provider
            gMapControl1.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;

            //Set the map center
            gMapControl1.Position = new GMap.NET.PointLatLng(41.7149567, -71.4167);

            //set the settings for the map
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 17;
            gMapControl1.Zoom = 13;
            gMapControl1.Dock = DockStyle.Fill;

        }

        private void cbCanvas_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtMapPin = new DataTable();

            BusinessLayer.MapPin MapList = new BusinessLayer.MapPin();

            int t = 1;

            dtMapPin = MapList.getMapPinByType(t);

            GMapOverlay mark = new GMapOverlay(gMapControl1, "mark");

            if (cbCanvas.Checked)
            {
                for (int j = 0; j < dtMapPin.Rows.Count; j++)
                {
                    int m = Convert.ToInt32(dtMapPin.Rows[j]["CategoryID"]);

                    if (m == 1)
                    {
                        double x = Convert.ToDouble(dtMapPin.Rows[j]["XLOC"]);
                        double y = Convert.ToDouble(dtMapPin.Rows[j]["YLOC"]);
                        mark.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new PointLatLng(x, y)));
                    }

                    //tell the map to add the overlay
                    gMapControl1.Overlays.Add(mark);

                }
            }
            else
            {
                gMapControl1.Overlays.Clear();
            }
        }


        private void cbContrib_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dtMapPin = new DataTable();

            BusinessLayer.MapPin MapList = new BusinessLayer.MapPin();

            int t = 1;

            dtMapPin = MapList.getMapPinByType(t);

            GMapOverlay mark = new GMapOverlay(gMapControl1, "mark");

            if (cbContrib.Checked)
            {
                for (int j = 0; j < dtMapPin.Rows.Count; j++)
                {
                    int m = Convert.ToInt32(dtMapPin.Rows[j]["CategoryID"]);

                    if (m == 2)
                    {
                        double x = Convert.ToDouble(dtMapPin.Rows[j]["XLOC"]);
                        double y = Convert.ToDouble(dtMapPin.Rows[j]["YLOC"]);
                        mark.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(new PointLatLng(x, y)));
                    }

                    //tell the map to add the overlay
                    gMapControl1.Overlays.Add(mark);
                }
            }
            else
            {
                gMapControl1.Overlays.Clear();

            }
        }
    }
}
