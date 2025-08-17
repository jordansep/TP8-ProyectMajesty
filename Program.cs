using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Simulador de movimientos bancarios (compra con tarjetas) */
            TarjetadeCredito jordan = new TarjetadeCredito("44 444 444","Jordan", "Monier", "4444 4444 4444 4444", "000", "MasterCard");
            jordan.MostrarDatos();
        }
        
    }
}
