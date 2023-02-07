using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreentregaProyectoFinal.Models
{
   internal class Usuario
   {
      private long _id;
      private string _nombre;
      private string _apellido;
      private string _nombreUsuario;
      private string _contrasena;
      private string _mail;

      public long Id { get => _id; set => _id = value; }
      public string Nombre { get => _nombre; set => _nombre = value; }
      public string Apellido { get => _apellido; set => _apellido = value; }
      public string NombreUsuario { get => _nombreUsuario; set => _nombreUsuario = value; }
      public string Contrasena { get => _contrasena; set => _contrasena = value; }
      public string Mail { get => _mail; set => _mail = value; }

      public override string ToString() // Aqui solo modifique el metodo ToString() para mostrar los datos, si no es necesario despues simplemente lo elimino
      {
         string usuaroInfo = 
            $"Id: {Id}" +
            $"\nNombre: {Nombre}" +
            $"\nApellido: {Apellido}" +
            $"\nNombreUsuario: {NombreUsuario}" +
            $"\nContrasena: {Contrasena} " +
            $"\nMail: {Mail}";

         return usuaroInfo;
      }

   }
}
