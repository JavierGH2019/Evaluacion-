using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
namespace capaNegocio
{
   public class MFactura
    {
       bdConex test = new bdConex();
       private String num_factura, id_cliente, fecha;
       public DataTable tabla = new DataTable();
       public DataTable tcb = new DataTable();
        
       

       public String Fecha
       {
           get { return fecha; }
           set { fecha = value; }
       }

       public String Id_cliente
       {
           get { return id_cliente; }
           set { id_cliente = value; }
       }

       public String Num_factura
       {
           get { return num_factura; }
           set { num_factura = value; }
       }
           
       public void insertar()
       {
           try
           {
               String insert = "INSERT INTO [dbo].[factura] ([num_factura] ,[id_cliente] ,[fecha]) VALUES ('"+num_factura+"','"+id_cliente+"','"+Fecha+"')";
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
               String update = "UPDATE [dbo].[factura] SET [num_factura] = '"+Num_factura+"' ,[id_cliente] = '"+Id_cliente+"','"+Fecha+"',> WHERE num_factura='"+Num_factura+"'";
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
               String delete = "delete  from factura where num_factura='" + Num_factura + "'";
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
               String consulta = "SELECT [num_factura] ,[id_cliente] ,[fecha] FROM [dbo].[factura]";
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

       public void llenarCB() {
           String consulta = "SELECT [id_cliente],[nombre] FROM [dbo].[cliente]";

           tcb.Clear();
           test.Conectar();
           test.mostrarSQL(consulta);            
           test.da.Fill(tcb);
           test.Desconectar();

           
       }

      


    }
}
