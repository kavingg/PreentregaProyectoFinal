using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PreentregaProyectoFinal.DBTool;
using PreentregaProyectoFinal.Models;

namespace PreentregaProyectoFinal.Handlers
{
   internal static class ProductoHandler
   {
      public static List<Producto> ObtenerProductos(long idUsuario)
      {
         List<Producto> productosCargados = new List<Producto>();

         using (SqlConnection connection = new SqlConnection(UtilidadBD.CadenaConexion()))
         {
            SqlCommand command = new SqlCommand("SELECT * FROM Producto WHERE IdUsuario=@idUsuario", connection);
            command.Parameters.AddWithValue("@idUsuario", idUsuario);
            connection.Open();

            using (SqlDataReader dataReader = command.ExecuteReader())
            {
               if (dataReader.HasRows)
               {
                  while (dataReader.Read())
                  {
                     Producto productoTemp = new()
                     {
                        Id = dataReader.GetInt64(0),
                        Descripciones = dataReader.GetString(1),
                        Costo = dataReader.GetDecimal(2),
                        PrecioVenta = dataReader.GetDecimal(3),
                        Stock = dataReader.GetInt32(4),
                        IdUsuario = dataReader.GetInt64(5),
                     };

                     productosCargados.Add(productoTemp);
                  }
               }
            }
         }
         return productosCargados;
      }

   }
}
