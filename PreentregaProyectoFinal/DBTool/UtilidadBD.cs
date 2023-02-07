using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreentregaProyectoFinal.DBTool
{
   internal static class UtilidadBD
   {
      static string stringConnection = "Data Source=DESKTOP-DV7R3I2\\SQLEXPRESS;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

      public static string CadenaConexion()
      {
         return stringConnection;
      }

   }
}
