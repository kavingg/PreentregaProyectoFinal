using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreentregaProyectoFinal.Models
{
   internal class Producto
   {
      private long _id;
      private string _descripciones;
      private decimal _costo;
      private decimal _precioVenta;
      private int _stock;
      private long _idUsuario;

      public long Id { get => _id; set => _id = value; }
      public string Descripciones { get => _descripciones; set => _descripciones = value; }
      public decimal Costo { get => _costo; set => _costo = value; }
      public decimal PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
      public int Stock { get => _stock; set => _stock = value; }
      public long IdUsuario { get => _idUsuario; set => _idUsuario = value; }

      public override string ToString()
      {
         return $"Id: {Id}" +
            $"\nDescripciones: {Descripciones}" +
            $"\nCosto: {Costo}" +
            $"\nPrecioVenta: {PrecioVenta}" +
            $"\nStock: {Stock}" +
            $"\nIdUsuario: {IdUsuario}\n";
      }

   }
}
