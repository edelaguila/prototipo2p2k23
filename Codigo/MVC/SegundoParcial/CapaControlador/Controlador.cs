using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data;
using System.Data.Odbc;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        // LLenar una tabla CAPA CONTROLADOR
        //Este metodo crea el dataTable en donde se van a pasar los datos que se obtuvieron de la consulta

        public DataTable llenarTbl(string tabla) //lo que hace es obtener esta variable
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla); // y pasarla a esta que pertenece a la capa modelo en la clase sentencias
            DataTable table = new DataTable(); // y entra en esta función
            dt.Fill(table); // intermediario que pasa los datos de la consulta al datagridview
            return table;
        }
    }
}
//2 - se obtiene la consulta de la capamodelo en llenarTbl(tabla), el nombre de todos los empleados
// y se guarda en otra varibale de tipo OdbcDataAdapter y se utiliza para llenar en dataTable= dt.fill