using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecutable_0901_20_2841
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reportes frm = new Reportes();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayuda/AyudaAS2.chm", "Ayuda2p2.html");
        }

        private void combo1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
           
        }
    }
}
