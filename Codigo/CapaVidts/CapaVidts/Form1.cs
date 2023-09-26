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

namespace CapaVidts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarTablas(comboBox1);
        }

       
        OdbcConnection con = new OdbcConnection("Dsn=siu");
        String tablabusqueda;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void CargarTablas(ComboBox comboBox1)
        {
            OdbcConnection con = new OdbcConnection("Dsn=siu");
            con.Open();
            comboBox1.DataSource = con.GetSchema("Tables");
            comboBox1.DisplayMember = "TABLE_NAME";
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tablabusqueda = "";
            
            tablabusqueda = comboBox1.Text;
            CargarColumnas(comboBox1, tablabusqueda);
        }

        private void CargarColumnas(ComboBox comboBox1, string @string)
        {
            DataTable dt = new DataTable();
            try
            {
                string cadena = " SELECT  * FROM " + tablabusqueda;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgv_prueba.DataSource = dt;
                    int ndgv = dgv_prueba.Columns.Count;

                    for (int i = 0; i < ndgv; i++)
                    {
                        String nameC;
                        nameC = dgv_prueba.Columns[i].HeaderText;
                        int ncbx = comboBox1.Items.Count;
                        if (ncbx < ndgv)
                        {
                            comboBox1.Items.Add(nameC);
                           
                        }
                    }
                }
            }
            catch
            {
                /*  String textalert = " Error al consultar Tabla ";
                  MessageBox.Show(textalert);*/
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CapaControlador.Controlador crud = new CapaControlador.Controlador();
            //bool resultado = crud.InsertBusqueda(comboBox1.Text, null);

            //if (resultado)

            //{
            //    MessageBox.Show("Datos guardados");
            //}

            //comboBox1.Text = (comboBox1.Text + "+");
            //string columnasbd = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ControldeAyuda ayuda = new ControldeAyuda();
            ayuda.Show();
        }
    }
}
