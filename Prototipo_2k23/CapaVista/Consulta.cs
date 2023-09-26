using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CapaControlador;

namespace CapaVista
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
           
        }

        Controlador cn = new Controlador();

        public void Llenarse(string tabla, string campo1, string campo2)
        {

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;
          

           
            combo1.ValueMember = "numero";
            combo1.DisplayMember = "nombre";

            string[] items = cn.items(tabla, campo1, campo2);



            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        combo1.Items.Add(items[i]);
                    }
                }

            }

            var dt2 = cn.enviar(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));


            }

            combo1.AutoCompleteCustomSource = coleccion;
            combo1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            combo1.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            //combo1.Llenarse("empleados", "codigo_empleado", "puesto");
        }
    }
}
