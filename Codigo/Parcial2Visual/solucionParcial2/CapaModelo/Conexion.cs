using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;

namespace CapaModelo
{
    class Conexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection con = new OdbcConnection("Dsn=umg_prototipo2k23");
            try
            {

                con.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("no conecto");
            }
            return con;
        }

        public void desconexion(OdbcConnection con)
        {
            try
            {

                con.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No se pudo desconectar");
            }
        }

    }
}
