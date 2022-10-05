using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaOnline
{
    class DetalleFactura
    {
        public long codigoProducto { get; set; }
        public string nombreproducto { get; set; }
        public int cantidad { get; set; }
        public int Precio { get; set; }
        public double iva { get; set; }
        public int Subtotal { get; set; }
       
    }
}
