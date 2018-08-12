using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1.NET
{
    class Registro
    {
        public String Nombre { get; set; }
        public String Codigo { get; set; }
        public String Articulo { get; set; }
        public String Fecha { get; set; }
        public String Hora { get; set; }
        public String Reportante { get; set; }
        public String Ubicacion { get; set; }

        public Registro(String nombre, String codigo, String articulo, String fecha, String hora, String reportante, String ubicacion)
        {
            Nombre = nombre;
            Codigo = codigo;
            Articulo = articulo;
            Fecha = fecha;
            Hora = hora;
            Reportante = reportante;
            Ubicacion = ubicacion;
        }

        public string darRegistro()
        {
            return Nombre + "_" + Codigo + "_" + Articulo + "_" + Fecha + "_" + Hora + "_" + Reportante + "_" + Ubicacion;
        }

    }
}
