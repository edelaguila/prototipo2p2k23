using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class Sentencias : Conexion
    {


        public List<string> getTables()
        {
            List<string> tables = new List<string>();
            string sql = "show tables";
            OdbcCommand cmd = new OdbcCommand(sql, this.connection());
            OdbcDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd.GetString(0);
                tables.Add(name);
            }
            return tables;
        }

    }
}
