using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Taller1.NET
{
    public partial class PanelRegistro : UserControl
    {
        private String ruta = "..\\..\\..\\Dat\\Registros.txt";
        private String rutaZonas = "..\\..\\..\\Dat\\Reg";
        ArrayList registros;

        public PanelRegistro()
        {
            InitializeComponent();
            registros = new ArrayList();
            generarRegistros();
        }

        public void generarRegistros()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(ruta);

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    String[] cadena = line.Split('_');

                    Registro registroNuevo = new Registro(cadena[0], cadena[1], cadena[2], cadena[3], cadena[4], cadena[5], cadena[6]);
                    registros.Add(registroNuevo);

                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCodigo.Text = "";
            txtArtículo.Text = "";
            dtpFecha.Text = "";
            cbxHora.Text = "";
            cbxReportadoPor.Text = "";
            cbxUbicacion.Text = "";
        }

        public void lectura()
        {
            limpiarTextArea();
            String line;
            try
            {
                StreamReader sr = new StreamReader(ruta);

                line = "";

                while ((line = sr.ReadLine()) != null)
                {
                    txtCarga.AppendText(line);
                    txtCarga.AppendText("\n");
                    txtCarga.AppendText("\n");


                }

                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public void escritura()
        {
            try
            {
                if (!obtenerDatos().Equals(""))
                {
                    StreamWriter sw = new StreamWriter(ruta, true);
                    StreamWriter sw1 = new StreamWriter("" + rutaZonas + cbxUbicacion.Text + ".txt", true);
                    sw.WriteLine(obtenerDatos());
                    sw1.WriteLine(obtenerDatos());
                    Registro registroNuevoEscritura = new Registro(txtNombre.Text, txtCodigo.Text, txtArtículo.Text, dtpFecha.Text, cbxHora.Text, cbxReportadoPor.Text, cbxUbicacion.Text);
                    registros.Add(registroNuevoEscritura);

                    sw.Close();
                    sw1.Close();
                    MessageBox.Show("Se registró el reporte satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("Llene todos los campos");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public String obtenerDatos()
        {
            if (!txtNombre.Text.Equals("") && !txtCodigo.Text.Equals("") && !txtArtículo.Text.Equals("") && !cbxHora.Text.Equals("") && !cbxReportadoPor.Text.Equals("") && !cbxUbicacion.Text.Equals(""))
            {
                String registro = txtNombre.Text + "_" + txtCodigo.Text + "_" + txtArtículo.Text + "_" + dtpFecha.Text + "_" + cbxHora.Text + "_" + cbxReportadoPor.Text + "_" + cbxUbicacion.Text;
                return registro;
            }
            else
            {
                return "";
            }
        }

        public void limpiarTextArea()
        {
            txtCarga.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            escritura();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lectura();
        }

        private void btnConsultaCuadrantes_Click(object sender, EventArgs e)
        {
            Process.Start("..\\..\\..\\MapaIcesi\\bin\\Debug\\MapaIcesi.exe");
        }
    }
}
