using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial_2
{
    public partial class frmSegundoParcial : Form
    {
        public frmSegundoParcial()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas salir del sistema?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit(); // Cierra la aplicación.
                }
            
        }

        private void btn_ayuda_Click(object sender, EventArgs e)
        {
            string mensajeAyuda = "Explicación de los botones:\n\n" +
                          "1. Botón 1: Cargar Datos.\n" +
                          "2. Botón 2: Ayuda.\n" +
                          "3. Botón 3: Crea un Reporte.\n" +
                          "4. Botón 4: Salir.";

            MessageBox.Show(mensajeAyuda, "Ayuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
