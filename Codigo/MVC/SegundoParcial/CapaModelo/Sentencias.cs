using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
   public class Sentencias
    {
        Conexion con = new Conexion();

        // obtener datos de una tabla CAPA MODELO

        //Consultar la base de datos y la tabla que se le pase como parametro
        //Luego lo pasa a la siguiente capa: controlador
        //Todos los datos a consultar estan dentro de un dataTable
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro 

            string sql = "SELECT * FROM " + tabla + "  ;"; //consulta la tabla pasada como parametro
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion()); // se guarda en una variable
            return dataTable; //y retorna lo que obtenga de la consulta
        }

    }
}
