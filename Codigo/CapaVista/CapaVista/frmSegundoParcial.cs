using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmSegundoParcial : Form
    {
        String tabla = "alumnos";
        Controlador cn = new Controlador();
        public frmSegundoParcial()
        {
            InitializeComponent();
        }

        private void frmSegundoParcial_Load(object sender, EventArgs e)
        {

        }

        public void actualizardatagridview()
        {
            DataTable dt = cn.llenarTbl(tabla);
            Dgv_consulta.DataSource = dt;
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            actualizardatagridview();
        }

        private void btn_ayudas_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "prototipo2p2k23/Ayuda.chm", "Ayuda.html");
        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }
    }
}
