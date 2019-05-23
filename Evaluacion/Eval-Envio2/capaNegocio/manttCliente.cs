using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
   public class manttCliente
    {
        bdConex test = new bdConex();
        
        public DataTable tabla = new DataTable();

        public string id_cliente, nombre, apellido, direccion, fecha_na, telefono, email, categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Fecha_na
        {
            get { return fecha_na; }
            set { fecha_na = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Id_cliente
        {
            get { return id_cliente; }
            set { id_cliente = value; }
        }


        public void insertProducto()
        {
            try
            {
                String insert = "INSERT INTO cliente(id_cliente, nombre, apellido, direccion, fecha_nacimiento, telefono, email, categoria) VALUES('"+ id_cliente +"','"+nombre+"','"+apellido+"','"+ direccion+"','"+fecha_na+"','"+telefono+"','"+email+"','"+categoria+"')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }


        public void updatecliente()
        {
            try
            {
                String update = "UPDATE [dbo].[cliente]  SET [nombre] = '"+nombre+"',[apellido] = '"+apellido+"',[direccion] = '"+direccion+"',[fecha_nacimiento] = '"+fecha_na+"',[telefono] = '"+telefono+"',[email] = '"+email+"',[categoria] ='"+categoria+"' where id_cliente='"+id_cliente+"'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }

        public void deletecliente()
        {
            try
            {
                String delete = "delete  from cliente where id_cliente='" + id_cliente + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }
        public void mostrarcliente()
        {
            try
            {
                String consulta = "select * from cliente";
                test.Conectar();
                test.mostrarSQL(consulta);
                tabla.Clear();
                test.da.Fill(tabla);
                test.Desconectar();
            }
            catch
            {

            }
        }
    }
}
