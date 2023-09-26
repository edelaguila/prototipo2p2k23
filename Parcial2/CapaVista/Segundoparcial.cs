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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaVista
{
    public partial class Segundoparcial : Form
    {
        string mst = "maestros";
        Controlador cn = new Controlador();

        public Segundoparcial()
        {
            InitializeComponent();
        }

        //Mostrar los datos CAPA VISTA

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            DataTable dt = cn.llenarcmb(comboBox1);
            Btn_cargar.DataSource = dt;

        }

        private void Segundoparcial_Load(object sender, EventArgs e)
        {

        }
    }
}
