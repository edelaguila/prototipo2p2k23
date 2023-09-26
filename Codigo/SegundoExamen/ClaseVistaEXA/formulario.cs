using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseVistaEXA
{
    public partial class formulario : Form
    {
        public formulario()
        {
            InitializeComponent();
            cargardatos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //SALIR
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CARGAR DATOS

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //AYUDA
            Help.ShowHelp(this, "AyudaRisko/AyudaRiskoAS2.chm", "Venta.html");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //REPORTE
            Reporte frm = new Reporte();
            frm.Show();
        }

        void cargardatos()
        {



            combo1.llenarse("codigo_curso", "nombre_curso", "estatus_curso");


        }

    }
}
