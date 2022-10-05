using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOnline
{
    class Producto
    {
        public long codigoProducto { get; set; }
        public string nombreproducto { get; set; }
        public int cantidad { get; set; }
        public int disponible { get; set; }
    }
}
