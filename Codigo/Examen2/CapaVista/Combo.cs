using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlado;
namespace CapaVista
{
    public partial class Combo : UserControl
    {
        public Combo()
        {
            InitializeComponent();
        }
        Controlador cn = new Controlador();

        public void llenarse(string tabla, string campo1, string campo2)
        {

            string tbl = tabla;
            string cmp1 = campo1;
            string cmp2 = campo2;
          

           
            comboBox1.ValueMember = "numero";
            comboBox1.DisplayMember = "nombre";

            string[] items = cn.items(tabla, campo1, campo2);



            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        comboBox1.Items.Add(items[i]);
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

            comboBox1.AutoCompleteCustomSource = coleccion;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }


    }
}
