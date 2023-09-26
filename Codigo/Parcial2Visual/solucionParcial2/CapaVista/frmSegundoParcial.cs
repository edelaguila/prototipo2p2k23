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

        Controlador cont = new Controlador();
        public frmSegundoParcial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llenarse("maestros", "codigo_maestro", "nombre_maestro");
            MessageBox.Show("Datos cargador revisar combobox");
        }

       


        void cargardatos()
        {



            llenarse("maestros", "codigo_maestro", "nombre_maestro");


        }
        public void llenarse(string tabla, string campo1, string campo2)
        {

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;



            comboMaestros.ValueMember = "numero";
            comboMaestros.DisplayMember = "nombre";

            string[] items = cont.items(tabla, campo1, campo2);



            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        comboMaestros.Items.Add(items[i]);
                    }
                }

            }

            var dt2 = cont.enviar(tabla, campo1, campo2);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]) + "-" + Convert.ToString(row[campo2]));
                coleccion.Add(Convert.ToString(row[campo2]) + "-" + Convert.ToString(row[campo1]));


            }

            comboMaestros.AutoCompleteCustomSource = coleccion;
            comboMaestros.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboMaestros.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void btn_reportes_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudahtml/ayuda.chm", "ayuda.html");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo del programa");
            this.Close();
        }
    }
}
