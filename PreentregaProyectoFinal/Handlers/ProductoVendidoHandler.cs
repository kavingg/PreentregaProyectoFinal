using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreentregaProyectoFinal.Models;
using PreentregaProyectoFinal.DBTool;

namespace PreentregaProyectoFinal.Handlers
{
   internal static class ProductoVendidoHandler
   {
      // Trar productosVendidos (recibe el id del usuario y devuelve una lista de productos vendidos por ese usuario)

      // Solo devuelvo la lista de productos con solo las descripciones de los productos (en el command le especifique que solo seleccione las descripciones)

      public static List<Producto> OptenerProductosVendidos(long id)
      {
         List<Producto> productosVendidos = new List<Producto>();

         using (SqlConnection connection = new SqlConnection(UtilidadBD.CadenaConexion()))
         {
            SqlCommand command = new SqlCommand(
               "select Producto.Descripciones from Producto inner join ProductoVendido ON ProductoVendido.IdProducto = Producto.Id where IdUsuario=@id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
               while (dataReader.Read())
               {
                  Producto productoTemp = new Producto();
                  productoTemp.Descripciones = dataReader.GetString(0);
                  productosVendidos.Add(productoTemp);
               }
            }
         }
         return productosVendidos;
      }
   }
}
