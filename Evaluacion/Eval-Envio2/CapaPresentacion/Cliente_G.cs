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
    public partial class Cliente_G : Form
    {
        manttCliente mcliente = new manttCliente();
        public Cliente_G()
        {
            InitializeComponent();
            cargar();

        }
        public void limpiar()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
        }
        public void cargar()
        {
            mcliente.mostrarcliente();
            dataGridView1.DataSource = mcliente.tabla;

        }
        private void Cliente_G_Load(object sender, EventArgs e)
        {

        }

         private void button1_Click(object sender, EventArgs e)
        {
            mcliente.id_cliente = textBox1.Text;
            mcliente.Nombre = textBox2.Text;
            mcliente.apellido = textBox3.Text;
            mcliente.direccion = textBox4.Text;
             mcliente.fecha_na = textBox5.Text;
             mcliente.telefono = textBox6.Text;
             mcliente.email = textBox7.Text;
             mcliente.categoria = textBox8.Text;


            mcliente.insertProducto();
            limpiar();
            cargar();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            
    }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mcliente.id_cliente = textBox1.Text;
            mcliente.deletecliente();
            limpiar();
            cargar();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mcliente.id_cliente = textBox1.Text;
            mcliente.Nombre = textBox2.Text;
            mcliente.apellido = textBox3.Text;
            mcliente.direccion = textBox4.Text;
            mcliente.fecha_na = textBox5.Text;
            mcliente.telefono = textBox6.Text;
            mcliente.email = textBox7.Text;
            mcliente.categoria = textBox8.Text;


            mcliente.updatecliente();
            limpiar();
            cargar();
     
        }
    }
}
