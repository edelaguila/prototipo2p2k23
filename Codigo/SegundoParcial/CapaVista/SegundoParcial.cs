using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class SegundoParcial : Form
    {
        Controlador cont = new Controlador();

        public SegundoParcial()
        {
            InitializeComponent();
        }

        void insertarRegistro()
        {
            /*string cadena = "INSERT INTO empleados (codigo_seccion, nombre_seccion, estatus_seccion) VALUES ('" + Txt_codigo.Text + "', '" + Txt_nombre.Text + "', '" + Txt_estatus.Text + "');";
            OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
            consulta.ExecuteNonQuery();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*insertarRegistro();
            Txt_codigo.Text = " ";
            Txt_nombre.Text = " ";
            Txt_estatus.Text = " ";*/
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }
    }
}
