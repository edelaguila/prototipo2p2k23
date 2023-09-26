using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensaje = "Desea Salir";
            string titulo = "Salir";
            MessageBoxButtons boton = MessageBoxButtons.YesNo;
            DialogResult resultado;

            resultado = MessageBox.Show(mensaje, titulo, boton);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                // Closes the parent form.
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combo1.llenarse("maestros", "codigo_maestro", "nombre_maestro");
        }
    }
}
