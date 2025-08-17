using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    internal class Program
    {
        static int option = 0;
        static void Main(string[] args)
        {
            Menu();
            /* Simulador de movimientos bancarios (compra con tarjetas) */
        }
        public static void Menu()
        {
            string linea = "-------------------------------------------------------------------";
            Console.WriteLine(linea);
            Console.WriteLine("Bienvenido a Red Majestic");
            Console.WriteLine(linea);
            Console.WriteLine("1) Operar con Visa");
            Console.WriteLine("2) Operar con Mastercard");
            Console.WriteLine("3) Operar con Diners Club");
            Console.WriteLine("4) Desconoce la entidad de la tarjeta.");
            Console.WriteLine(linea);
            Requerimientos.Opcion(1, 4);
        }
       
        
    }
}
