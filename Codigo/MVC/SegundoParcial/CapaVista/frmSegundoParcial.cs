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
        string emp = "jornadas";
        Controlador cn = new Controlador();

        public frmSegundoParcial()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA


        //public void actualizardatagriew()
       // {
            //DataTable dt = cn.llenarTbl(emp); //funcion llenarTbl que pertenece a la capa controlador...
            //Dgv_registros.DataSource = dt;   //...se le pasa un parametro que sería la tabla que queremos consultar

        //}



        private void Btn_consultar_Click(object sender, EventArgs e)
        {
           // actualizardatagriew();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = cn.llenarTbl(emp);
        }

        private void cmb_auto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btm_reporte_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
              
        }
    }
}
