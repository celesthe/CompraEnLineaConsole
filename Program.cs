using System;
using System.Collections.Generic;
using System.Linq;

namespace VentaOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            SolicitarDatosCliente();
           
        }

        public static void SolicitarDatosCliente()
        {
            Random rand = new Random();
            EncabezadoFac Factura = new EncabezadoFac();
            Factura.NoFactura = rand.Next(1, 100);
            Console.WriteLine($"Factura No. {Factura.NoFactura}");
            Console.WriteLine("Ingrese el nombre del Cliente");
            Factura.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el nit del Cliente");
            Factura.nit = int.Parse(Console.ReadLine());
            Console.WriteLine("Seleccione el tipo de pago:");
            Console.WriteLine("1. Efectivo");
            Console.WriteLine("2. Tarjeta");
            Console.WriteLine("3. Transferencia");
            Factura.tipoPago = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los productos");
            Console.WriteLine("*********************************");
            AgregarProductos(ref Factura);
        }

        public static double CalcularIVA(int precio)
        {
            double valorIVA = 0;
            double IVA = 0.12;
            valorIVA = precio * IVA;
            return valorIVA;

        }

        public static void AgregarProductos(ref EncabezadoFac encabezado )
        {
            
            //EncabezadoFac encabezado = new EncabezadoFac();
            int CantidadProducto = 0;
            double IVA = 0, totalPagar = 0;
            

            Console.WriteLine("Cantidad de productos a Ingresar: ");
            CantidadProducto = int.Parse(Console.ReadLine());

            for ( int i = 0; i<CantidadProducto; i++)
            {
                DetalleFactura detalle = new DetalleFactura();
                Console.WriteLine("Nombre del Producto: ");
                detalle.nombreproducto = Console.ReadLine();

                Console.WriteLine("Cantidad: ");
                detalle.cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Precio: ");
                detalle.Precio = int.Parse(Console.ReadLine());

                IVA = CalcularIVA(detalle.Precio);

                Console.WriteLine($"IVA:  {IVA}");
                detalle.iva = IVA;
                detalle.Subtotal = detalle.Precio * detalle.cantidad;

                Console.WriteLine($"Subtotal:  { detalle.Subtotal}");

                totalPagar += detalle.Subtotal;

                encabezado.detalle.Add(detalle);


            }

            Console.WriteLine("*********************************");
            Console.WriteLine("DETALLE DE LA COMPRA");
            Console.WriteLine("*********************************");
            Console.WriteLine($"Factura #  {encabezado.NoFactura}");
            Console.WriteLine($"Cliente :  {encabezado.nombre}");
            Console.WriteLine($"Nit :  {encabezado.nit}");


            foreach (DetalleFactura item in encabezado.detalle)
            {
                Console.WriteLine("*********************************");
                Console.WriteLine($"Producto :  {item.nombreproducto}");
                Console.WriteLine($"Cantidad :  {item.cantidad}");
                Console.WriteLine($"Precio :  {item.Precio}");
                Console.WriteLine($"IVA :  {item.iva}");
                Console.WriteLine($"Subtotal :  {item.Subtotal}");


            }
            Console.WriteLine("*********************************");
            encabezado.Total = totalPagar;
            Console.WriteLine($"Total a pagar :  { encabezado.Total}");




        }
    }
}
