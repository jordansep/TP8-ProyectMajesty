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
        static void Main(string[] args)
        {
            Menu();
            /* Simulador de movimientos bancarios (compra con tarjetas) */
        }
        public int opcion = 0;
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
            Console.WriteLine("5) Ingresar a su cuenta");
            Console.WriteLine(linea);

            // Obtener la opción del usuario
            int opcion = Requerimientos.Opcion(1, 5);
            Cliente clienteNuevo = Requerimientos.SolicitarDatosCliente();
            clienteNuevo.DBTransaction();
            // Crear la instancia según la opción
            TDCredito datos = Requerimientos.SolicitarDatosTarjeta();
            datos.MostrarDatos();
        }

    }
}
