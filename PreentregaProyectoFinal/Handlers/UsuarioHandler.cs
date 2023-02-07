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
   internal static class UsuarioHandler
   {
      public static Usuario ObtenerUsuario(string nombre) // Devuelve el usuario segun su nombre
      {
         Usuario usuario = new Usuario();

         using (SqlConnection connection = new SqlConnection(UtilidadBD.CadenaConexion()))
         {
            SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE Nombre=@nombre", connection);
            command.Parameters.AddWithValue("@nombre", nombre);
            connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
               dataReader.Read();
               usuario.Id = dataReader.GetInt64(0);
               usuario.Nombre = dataReader.GetString(1);
               usuario.Apellido = dataReader.GetString(2);
               usuario.NombreUsuario = dataReader.GetString(3);
               usuario.Contrasena = dataReader.GetString(4);
               usuario.Mail = dataReader.GetString(5);
            }
         }
         return usuario;
      }

      // Inicio de sesion(recibe un usuario y contrasena y devuelve un objeto Usuario)
      public static Usuario IniciarSesion(string nombre, string contrasena)
      {
         Usuario usuario = new Usuario();

         using (SqlConnection connection = new SqlConnection(UtilidadBD.CadenaConexion()))
         {
            SqlCommand command = new SqlCommand("SELECT * FROM Usuario WHERE Nombre=@nombre AND Contraseña=@contrasena", connection);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@contrasena", contrasena);
            connection.Open();

            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.HasRows)
            {
               dataReader.Read();
               usuario.Id = dataReader.GetInt64(0);
               usuario.Nombre = dataReader.GetString(1);
               usuario.Apellido = dataReader.GetString(2);
               usuario.NombreUsuario = dataReader.GetString(3);
               usuario.Contrasena = dataReader.GetString(4);
               usuario.Mail = dataReader.GetString(5);
            }
            else { usuario.Id = 0; }
         }

         return usuario;
      }

   }
}
