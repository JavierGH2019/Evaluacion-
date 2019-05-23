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
     
    public partial class Detalle : Form
    {
        MDetalle Mdetalle = new MDetalle();
         
        public Detalle()
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
            Mdetalle.mostrar();
            dataGridView1.DataSource = Mdetalle.tabla;
             
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Mdetalle.Num_detalle = textBox1.Text;
            Mdetalle.Id_factura = comboBox1.SelectedValue.ToString();
            Mdetalle.Id_producto = comboBox2.SelectedValue.ToString();
            Mdetalle.Cantidad =Convert.ToInt16(textBox4.Text);
            Mdetalle.Precio = Convert.ToDouble(textBox5.Text);

            Mdetalle.insertar();
            limpiar();
            cargar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mdetalle.Id_producto = textBox1.Text;
            Mdetalle.eliminar();
            limpiar();
            cargar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mdetalle.Num_detalle = textBox1.Text;
            Mdetalle.Id_factura = comboBox1.SelectedValue.ToString();
            Mdetalle.Id_producto = comboBox2.SelectedValue.ToString();
            Mdetalle.Cantidad = Convert.ToInt16(textBox4.Text);
            Mdetalle.Precio = Convert.ToDouble(textBox5.Text);
            Mdetalle.actualizar();
            limpiar();
            cargar();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Mdetalle.llenarCB();

            comboBox1.DataSource = Mdetalle.tcb1;
            comboBox1.ValueMember = "num_factura";
            comboBox1.DisplayMember = "num_factura";
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Mdetalle.llenarCB();

            comboBox2.DataSource = Mdetalle.tcb2;
            comboBox2.ValueMember = "id_producto";
            comboBox2.DisplayMember = "nombre";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Factura_G f = new Factura_G();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Producto_G p = new Producto_G();
            p.Show();
        }
    }
}
