using CapaControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Form1 : Form
    {
        Controlador ctrl;
        public Form1()
        {
            this.ctrl = new Controlador();
            InitializeComponent();
        }

        public void fillData()
        {
            List<string> tbls = this.ctrl.getList();
            foreach (string str in tbls) this.combo.Items.Add(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos cargados");
            this.fillData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "test3.chm", "index.html");
        }
    }
}
