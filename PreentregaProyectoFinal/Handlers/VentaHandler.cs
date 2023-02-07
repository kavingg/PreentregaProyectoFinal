using PreentregaProyectoFinal.DBTool;
using PreentregaProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace PreentregaProyectoFinal.Handlers
{
   internal static class VentaHandler
   {
      // Traer Ventas (recibe el id del usuario y devuelve una lista de Ventas realizadas por ese usuario

      public static List<Venta> OptenerVentas(long usuarioId)
      {
         List<Venta> listVentas = new List<Venta>();

         using (SqlConnection connection = new SqlConnection(UtilidadBD.CadenaConexion()))
         {
            SqlCommand command = new SqlCommand("select * from Venta where IdUsuario=@usuarioId", connection);
            command.Parameters.AddWithValue("@usuarioId", usuarioId);
            connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
               while (dataReader.Read())
               {
                  // Leer datos
                  var venta = new Venta();
                  venta.Id = (long)dataReader["Id"];
                  venta.Comentarios = (string)dataReader["Comentarios"];
                  venta.IdUsuario = (long)dataReader["IdUsuario"];
                  listVentas.Add(venta);
               }
            }
         }
         return listVentas;
      }

   }
}
