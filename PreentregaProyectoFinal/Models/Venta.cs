using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreentregaProyectoFinal.Models
{
    internal class Venta
    {
        private long _id;
        private string _comentarios;
        private long _idUsuario;

        public long Id { get => _id; set => _id = value; }
        public string Comentarios { get => _comentarios; set => _comentarios = value; }
        public long IdUsuario { get => _idUsuario; set => _idUsuario = value; }

    }
}
