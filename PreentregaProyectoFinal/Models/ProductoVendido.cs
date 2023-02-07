using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreentregaProyectoFinal.Models
{
    internal class ProductoVendido
    {
        private long _id;
        private int _stock;
        private long _idProducto;
        private long _idVenta;

        public long Id { get; set; }
        public int Stock { get; set; }
        public long IdProducto { get; set; }
        public long IdVenta { get; set; }

    }
}
