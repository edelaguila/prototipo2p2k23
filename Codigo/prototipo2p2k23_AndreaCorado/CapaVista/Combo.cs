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
using System.Data.Odbc;

namespace CapaVista
{
    public partial class Combo : UserControl
    {
        public Combo()
        {
            InitializeComponent();
            cargardatos();
        }


        Controlador cn = new Controlador();

        public void llenarse(string tabla, string campo1, string campo2, string campo3, string campo4)
        {

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;
            combo1.ValueMember = "codigo_carrera";
            combo1.DisplayMember = "nombre_carrera";

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

        void cargardatos()
        {
            combo1.llenarse("codigo_carrera", "nombre_carrera", "codigo_facultad", "estatus_carrera");
        }

        private void combo1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
