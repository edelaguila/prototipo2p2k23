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
            this.fillData();
        }

        public void fillData()
        {
            List<string> tbls = this.ctrl.getList();
            foreach (string str in tbls)
            {
                this.combo.Items.Add(str);
            }
        }
    }
}
