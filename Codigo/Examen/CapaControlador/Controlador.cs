using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias sn;
        public Controlador()
        {
            this.sn = new Sentencias();
        }
        public List<string> getList()
        {
            return this.sn.getTables();
        }
    }
}
