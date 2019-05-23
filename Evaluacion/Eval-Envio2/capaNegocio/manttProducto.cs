using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
   public class manttProducto
    {
       bdConex test = new bdConex();
       private String id_producto, nombre, precio, stock;
       public DataTable tabla = new DataTable();

       public String Stock
       {
           get { return stock; }
           set { stock = value; }
       }

       public String Precio
       {
           get { return precio; }
           set { precio = value; }
       }

       public String Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }

       public String Id_producto
       {
           get { return id_producto; }
           set { id_producto = value; }
       }

       public void insertProducto()
       {
           try
           {
               String insert = "INSERT INTO Producto(id_producto,NOMBRE, PRECIO, STOCK)VALUES('" + id_producto + "','" + nombre + "','" + precio + "','" + stock + "' )";
               test.Conectar();
               test.consultaSQL(insert);
               test.Desconectar();
           }
           catch
           {

           }
       }


       public void updateProducto()
       {
           try
           {
               String update = "UPDATE [dbo].[producto] SET [id_producto] = '" + id_producto + "',[nombre] = '" + nombre + "',[precio] = '" + precio + "',[stock] = '" + stock + "' WHERE id_producto='"+id_producto+"'";
               test.Conectar();
               test.consultaSQL(update);
               test.Desconectar();
           }
           catch
           {

           }
       }

       public void deleteProducto()
       {
           try
           {
               String delete = "delete  from PRODUCTO where id_producto='"+ id_producto +"'";
               test.Conectar();
               test.consultaSQL(delete);
               test.Desconectar();
           }
           catch
           {

           }
       }
       public void mostrarProducto()
       {
           try
           {
               String consulta = "select * from producto";
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
