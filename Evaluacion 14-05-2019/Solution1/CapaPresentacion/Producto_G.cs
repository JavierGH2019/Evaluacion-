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
     
    public partial class Producto_G : Form
    {
        
        manttProducto MPro = new manttProducto();
        public Producto_G()
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
            MPro.mostrarProducto();
            dataGridView1.DataSource = MPro.tabla;
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MPro.Id_producto = textBox1.Text;
            MPro.Nombre = textBox2.Text;
            MPro.Precio = textBox3.Text;
            MPro.Stock = textBox4.Text;

            MPro.insertProducto();
            limpiar();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MPro.Id_producto = textBox1.Text;
            MPro.deleteProducto();
            limpiar();
            cargar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MPro.Id_producto = textBox1.Text;
            MPro.Nombre = textBox2.Text;
            MPro.Precio = textBox3.Text;
            MPro.Stock = textBox4.Text;

            MPro.updateProducto();
            limpiar();
            cargar();
        }
    }
}
