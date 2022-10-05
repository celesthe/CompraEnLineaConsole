using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOnline
{
    class Cliente
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long nit { get; set; }
        public string direccion { get; set; }
        public int tipoPago { get; set; }
    }
}
