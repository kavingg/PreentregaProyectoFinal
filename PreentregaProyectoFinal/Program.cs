using PreentregaProyectoFinal.Handlers;
using PreentregaProyectoFinal.Models;

namespace PreentregaProyectoFinal
{
   internal class Program
   {
      static void Main(string[] args)
      {

         // 1.
         Console.WriteLine(" --> Consigna 1 ");

         Usuario usuario = UsuarioHandler.ObtenerUsuario("Tobias");
         Console.WriteLine(usuario.ToString());


         // 2.
         Console.WriteLine("\n --> consigna 2 ");

         List<Producto> listproduc = ProductoHandler.ObtenerProductos(1);

         foreach (Producto producto in listproduc)
         {
            Console.WriteLine(producto.ToString());
         }


         // 3.
         Console.WriteLine("\n --> Consigna 3");

         List<Producto> productosVendidos = ProductoVendidoHandler.OptenerProductosVendidos(1);

         foreach (Producto producto in productosVendidos)
         {
            Console.WriteLine(producto.Descripciones);
         }


         // 4.
         Console.WriteLine("\n --> Consigna 4");

         List<Venta> ventasPorUsuario = VentaHandler.OptenerVentas(1);

         foreach (Venta venta in ventasPorUsuario)
         {
            Console.WriteLine($"IdVenta: {venta.Id}" +
               $"\nComentarios: {venta.Comentarios}" +
               $"\nIdUsuario: {venta.IdUsuario}\n");
         }


         // 5.
         Console.WriteLine("\n --> Consigna 5");

         Usuario usuarioAIniciarSesion = UsuarioHandler.IniciarSesion("Tobias", "SoyTobiasCasazza");
         Console.WriteLine(usuarioAIniciarSesion.ToString());

      }
   }
}
