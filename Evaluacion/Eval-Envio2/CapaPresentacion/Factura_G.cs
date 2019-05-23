using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using CapaPresentacion;

namespace CapaPresentacion
{
     
    public partial class Factura_G : Form
    {
        MFactura MFactura = new MFactura();

        public Factura_G()
        {
            InitializeComponent();
            cargar();
        }
        public void limpiar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            textBox1.Text = string.Empty;
            comboBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty; 

        }
        public void cargar()
        {
            MFactura.mostrar();
            
             
            
             

              dataGridView1.DataSource = MFactura.tabla;
             
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MFactura.Num_factura = textBox1.Text;
            MFactura.Id_cliente = comboBox1.SelectedValue.ToString();
            MFactura.Fecha = (dateTimePicker1.Value.ToString("dd-MM-yyyy"));
             

            
            MFactura.insertar();
            limpiar();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MFactura.Num_factura = textBox1.Text;
            MFactura.eliminar();
            limpiar();
            cargar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MFactura.Num_factura = textBox1.Text;
            MFactura.Id_cliente = comboBox1.SelectedValue.ToString();



            MFactura.Fecha = (dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            MFactura.actualizar();
            limpiar();
            cargar();
        }

        private void Factura_G_Load(object sender, EventArgs e)
        {

        }

         

        private void comboBox1_Click(object sender, EventArgs e)
        {
            MFactura.llenarCB();

            comboBox1.DataSource = MFactura.tcb;
            comboBox1.ValueMember = "id_cliente";
            comboBox1.DisplayMember = "nombre";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente_G Cliente = new Cliente_G();
            Cliente.Show();
             
             
        }

         
    }
}
