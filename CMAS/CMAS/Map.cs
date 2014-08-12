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

            //Create an Overlay to hold marks
            GMapOverlay mark = new GMapOverlay(gMapControl1, "mark");

            //add the marks
            //this needs to populate marks for all the tags
            mark.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleGreen(new PointLatLng(41.7149967, -71.369163)));
            mark.Markers.Add(new GMap.NET.WindowsForms.Markers.GMapMarkerGoogleRed(new PointLatLng(41.7149967, -71.379163)));


            //tell the map to add the overlay
            gMapControl1.Overlays.Add(mark);

            //set the settings for the map
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 17;
            gMapControl1.Zoom = 13;
            gMapControl1.Dock = DockStyle.Fill;

        }
    }
}