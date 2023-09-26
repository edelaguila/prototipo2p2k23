using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

       
     public DataTable Buscar(string tabla, string columna, string dato)
        {
           return sn.Buscar(tabla, columna, dato);
        }

        
        public bool Eliminar(string tabla, string columna, string valor)
        {
            return sn.Eliminar(tabla, columna, valor);
        }
        public bool GuardarDatos(string tabla, Dictionary<string, object> valores)
        {
            return sn.Guardar(tabla, valores);
        }

        
        public bool Modificar(string tabla, Dictionary<string, object> valores, string condicion)
        {
            return sn.Modificar(tabla, valores, condicion);
        }


       
        public string Encriptacion(string str)
        {
            return sn.Encriptacion(str);
        }

   

        public List<string> ObtenerDatosM(string columna1,string columna2, string tabla)
        {
            return sn.ObtenerDatosM(columna1,columna2, tabla);
        }


      



        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
    }
}
