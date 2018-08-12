using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaIcesi
{
    public partial class Mapa : Form
    {
        GMapOverlay polygons;
        GMapOverlay markers;

        private String ruta = "..\\..\\..\\Dat\\Reg";

        public Mapa()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {   
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.BingSatelliteMap;
            gMapControl1.Position = new PointLatLng(3.341887875254173, -76.52832338712523);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 18;
            gMapControl1.AutoScroll = true;
            gMapControl1.ShowCenter = false;

            showCuadrantes();
            showMarkers();
            

        }

        //inicializador de los marcadores
        private void showMarkers()
        {
            markers = new GMapOverlay("markers");

            GMapMarker marker0 =
                new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new PointLatLng(3.3428955230271846, -76.53060189679638),
                    GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker0);
            marker0.Tag = "Cuadrante 1";
            marker0.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker0.ToolTipText = "Cuadrante 1";

            GMapMarker marker1 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.3428633912857353, -76.52969531014935),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker1);
            marker1.Tag = "Cuadrante 2";
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker1.ToolTipText = "Cuadrante 2";

            GMapMarker marker2 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.3418458855956312, -76.53060189679638),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker2);
            marker2.Tag = "Cuadrante 3";
            marker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker2.ToolTipText = "Cuadrante 3";

            GMapMarker marker3 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.3417441349685766, -76.52988306478039),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker3);
            marker3.Tag = "Cuadrante 4";
            marker3.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker3.ToolTipText = "Cuadrante 4";

            GMapMarker marker4 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.3409676166778137, -76.5303712268211),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker4);
            marker4.Tag = "Cuadrante 5";
            marker4.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker4.ToolTipText = "Cuadrante 5";

            GMapMarker marker5 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.3410265249834823, -76.5295236487724),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker5);
            marker5.Tag = "Cuadrante 6";
            marker5.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker5.ToolTipText = "Cuadrante 6";

            GMapMarker marker6 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.3423225068134284, -76.52858685086301),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker6);
            marker6.Tag = "Cuadrante 7";
            marker6.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker6.ToolTipText = "Cuadrante 7";

            GMapMarker marker7 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.341031880283825, -76.52863513062528),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker7);
            marker7.Tag = "Cuadrante 8";
            marker7.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker7.ToolTipText = "Cuadrante 8";

            GMapMarker marker8 =
               new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                   new PointLatLng(3.340964031809507, -76.5278379618959),
                   GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot);
            markers.Markers.Add(marker8);
            marker8.Tag = "Cuadrante 9";
            marker8.ToolTipMode = MarkerTooltipMode.OnMouseOver;
            marker8.ToolTipText = "Cuadrante 9";

            gMapControl1.Overlays.Add(markers);
        }


        //inicializador de cuadrantes del mapa
        private void showCuadrantes()
        {
            polygons = new GMapOverlay("polygons");

            List<PointLatLng> points0 = new List<PointLatLng>();
            points0.Add(new PointLatLng(3.3430615370078933, -76.53070359744754));
            points0.Add(new PointLatLng(3.343157932209596, -76.53008132495609));
            points0.Add(new PointLatLng(3.3423332173999425, -76.53007059612003));
            points0.Add(new PointLatLng(3.3422689538791563, -76.53081088580814));
            GMapPolygon polygon0 = new GMapPolygon(points0, "C1");
            polygon0.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon0.Stroke = new Pen(Color.Red, 1);

            List<PointLatLng> points1 = new List<PointLatLng>();
            points1.Add(new PointLatLng(3.343157932209596, -76.53008132495609));
            points1.Add(new PointLatLng(3.3432221956721393, -76.52908354320255));
            points1.Add(new PointLatLng(3.3422154009419587, -76.52912645854678));
            points1.Add(new PointLatLng(3.3423332173999425, -76.53007059612003));
            GMapPolygon polygon1 = new GMapPolygon(points1, "C2");
            polygon1.Fill = new SolidBrush(Color.FromArgb(50, Color.Azure));
            polygon1.Stroke = new Pen(Color.Azure, 1);

            List<PointLatLng> points2 = new List<PointLatLng>();
            points2.Add(new PointLatLng(3.3422689538791563, -76.53081088580814));
            points2.Add(new PointLatLng(3.3423332173999425, -76.53007059612003));
            points2.Add(new PointLatLng(3.3412152847901395, -76.5301565030349));
            points2.Add(new PointLatLng(3.341263482482896, -76.53096116573937));
            GMapPolygon polygon2 = new GMapPolygon(points2, "C3");
            polygon2.Fill = new SolidBrush(Color.FromArgb(50, Color.Green));
            polygon2.Stroke = new Pen(Color.Green, 1);

            List<PointLatLng> points3 = new List<PointLatLng>();
            points3.Add(new PointLatLng(3.3423332173999425, -76.53007059612003));
            points3.Add(new PointLatLng(3.3422154009419587, -76.52912645854678));
            points3.Add(new PointLatLng(3.341593497685624, -76.52915701889088));
            points3.Add(new PointLatLng(3.341598852982863, -76.53014407180837));
            GMapPolygon polygon3 = new GMapPolygon(points3, "C4");
            polygon3.Fill = new SolidBrush(Color.FromArgb(50, Color.Blue));
            polygon3.Stroke = new Pen(Color.Blue, 1);

            List<PointLatLng> points4 = new List<PointLatLng>();
            points4.Add(new PointLatLng(3.341263482482896, -76.53096116573937));
            points4.Add(new PointLatLng(3.3412152847901395, -76.5301565030349));
            points4.Add(new PointLatLng(3.341598852982863, -76.53014407180837));
            points4.Add(new PointLatLng(3.3416038545451454, -76.52970507537344));
            points4.Add(new PointLatLng(3.340506018004331, -76.52976408397177));
            points4.Add(new PointLatLng(3.3404792414879974, -76.5309764424465));
            GMapPolygon polygon4 = new GMapPolygon(points4, "C5");
            polygon4.Fill = new SolidBrush(Color.FromArgb(50, Color.Yellow));
            polygon4.Stroke = new Pen(Color.Yellow, 1);

            List<PointLatLng> points5 = new List<PointLatLng>();
            points5.Add(new PointLatLng(3.3416038545451454, -76.52970507537344));
            points5.Add(new PointLatLng(3.341593497685624, -76.52915701889088));
            points5.Add(new PointLatLng(3.340468530881256, -76.52926058286556));
            points5.Add(new PointLatLng(3.340506018004331, -76.52976408397177));
            GMapPolygon polygon5 = new GMapPolygon(points5, "C6");
            polygon5.Fill = new SolidBrush(Color.FromArgb(50, Color.Lavender));
            polygon5.Stroke = new Pen(Color.Lavender, 1);

            List<PointLatLng> points6 = new List<PointLatLng>();
            points6.Add(new PointLatLng(3.3432221956721393, -76.52908354320255));
            points6.Add(new PointLatLng(3.343290771714091, -76.52817697042354));
            points6.Add(new PointLatLng(3.341550301571651, -76.52822525018581));
            points6.Add(new PointLatLng(3.341593497685624, -76.52915701889088));
            GMapPolygon polygon6 = new GMapPolygon(points6, "C7");
            polygon6.Fill = new SolidBrush(Color.FromArgb(50, Color.Brown));
            polygon6.Stroke = new Pen(Color.Brown, 1);

            List<PointLatLng> points7 = new List<PointLatLng>();
            points7.Add(new PointLatLng(3.341593497685624, -76.52915701889088));
            points7.Add(new PointLatLng(3.341550301571651, -76.52822525018581));
            points7.Add(new PointLatLng(3.3405425638314457, -76.52823212177083));
            points7.Add(new PointLatLng(3.340468530881256, -76.52926058286556));
            GMapPolygon polygon7 = new GMapPolygon(points7, "C8");
            polygon7.Fill = new SolidBrush(Color.FromArgb(50, Color.Coral));
            polygon7.Stroke = new Pen(Color.Coral, 1);

            List<PointLatLng> points8 = new List<PointLatLng>();
            points8.Add(new PointLatLng(3.341550301571651, -76.52822525018581));
            points8.Add(new PointLatLng(3.341660715938414, -76.52737060776195));
            points8.Add(new PointLatLng(3.3412376473926324, -76.52738133659801));
            points8.Add(new PointLatLng(3.341207890135513, -76.52673462059823));
            points8.Add(new PointLatLng(3.3406848073871425, -76.52673636028419));
            points8.Add(new PointLatLng(3.3405425638314457, -76.52823212177083));
            GMapPolygon polygon8 = new GMapPolygon(points8, "C9");
            polygon8.Fill = new SolidBrush(Color.FromArgb(50, Color.Orange));
            polygon8.Stroke = new Pen(Color.Orange, 1);

            polygons.Polygons.Add(polygon0);
            polygons.Polygons.Add(polygon1);
            polygons.Polygons.Add(polygon2);
            polygons.Polygons.Add(polygon3);
            polygons.Polygons.Add(polygon4);
            polygons.Polygons.Add(polygon5);
            polygons.Polygons.Add(polygon6);
            polygons.Polygons.Add(polygon7);
            polygons.Polygons.Add(polygon8);

            gMapControl1.Overlays.Add(polygons);
        }

        //metodos y consultas

        public void lectura(String zona)
        {
            limpiarTextArea();
            String line;
            try
            {
                StreamReader sr = new StreamReader(ruta+"Zona"+zona+".txt");
                line = "";
                
                while ((line = sr.ReadLine()) != null)
                {
                    txtInfoCuadrantes.AppendText(line);
                    txtInfoCuadrantes.AppendText("\n");
                    txtInfoCuadrantes.AppendText("\n");
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public void limpiarTextArea()
        {
            txtInfoCuadrantes.Text = "";
        }

        //Manejo de eventos
        private void gMapControl1_OnPolygonClick(GMapPolygon item, MouseEventArgs e)
        {
            MessageBox.Show("Item " + item.Tag);
        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            String[] zona = item.Tag.ToString().Split();
            
            lectura(zona[1]);
        }

        private void btnLimpiarTexArea_Click(object sender, EventArgs e)
        {
           
           limpiarTextArea();
        }
    }
}
