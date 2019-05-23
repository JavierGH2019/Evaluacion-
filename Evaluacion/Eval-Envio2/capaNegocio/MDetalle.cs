using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace capaNegocio
{
   public class MDetalle
    {
       bdConex test = new bdConex();
       private String num_detalle, id_factura, id_producto, stock;
       private int cantidad;
       private double precio;
       
       public DataTable tabla = new DataTable();
       public DataTable tcb1 = new DataTable();
       public DataTable tcb2 = new DataTable();

       public double Precio
       {
           get { return precio; }
           set { precio = value; }
       }
       
       public int Cantidad
       {
           get { return cantidad; }
           set { cantidad = value; }
       }
       


       public String Stock
       {
           get { return stock; }
           set { stock = value; }
       }

       public String Id_producto
       {
           get { return id_producto; }
           set { id_producto = value; }
       }

       public String Id_factura
       {
           get { return id_factura; }
           set { id_factura = value; }
       }

       public String Num_detalle
       {
           get { return num_detalle; }
           set { num_detalle = value; }
       }
       

      

      
       public void insertar()
       {
           try
           {
               String insert = "INSERT INTO [dbo].[detalle] ([num_detalle] ,[id_factura],[id_producto],[cantidad],[precio]) VALUES ('" + Num_detalle + "' ,'" + Id_factura + "','" + id_producto + "' ,'" + Cantidad + "' ,'" + Precio + "')";


               test.Conectar();
               test.consultaSQL(insert);
               test.Desconectar();
           }
           catch
           {

           }
       }


       public void actualizar()
       {
           try
           {
               String update = "UPDATE [dbo].[detalle] SET [num_detalle] = '" + Num_detalle + "' ,[id_factura] = '" + Id_factura + "' ,[id_producto] ='" + id_producto + "' ,[cantidad] = '" + Cantidad + "' ,[precio] = '" + Precio + "' WHERE num_detalle= '" + Num_detalle+ "'";
               test.Conectar();
               test.consultaSQL(update);
               test.Desconectar();
           }
           catch
           {
               
           }
       }

       public void eliminar()
       {
           try
           {
               String delete = "delete  from detalle where num_detalle= '" + Num_detalle+ "'";
               test.Conectar();
               test.consultaSQL(delete);
               test.Desconectar();
           }
           catch
           {

           }
       }
       public void mostrar()
       {
           try
           {
               String consulta = "select * from detalle";
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

       public void llenarCB()
       {
           String consulta = "SELECT [num_factura] FROM [dbo].[factura]";
           String consulta2 = "SELECT [id_producto],[nombre] FROM [dbo].[producto]";
           
           test.Conectar();
           test.mostrarSQL(consulta);
           tcb1.Clear();
           test.da.Fill(tcb1);
           test.Desconectar();

           test.Conectar();
           test.mostrarSQL(consulta2);
           tcb2.Clear();
           test.da.Fill(tcb2);
           test.Desconectar();


       }
    }
}
