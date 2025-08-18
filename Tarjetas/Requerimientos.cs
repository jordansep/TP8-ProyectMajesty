using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
public class Requerimientos
{
    public static int Opcion(int min = 0, int max = 999999999, string msg = "Ingrese una opcion: ")
    {
        
        bool esNumero = false;
        int nroIngresado=0;
        do {
            Console.Write(msg);
            try
            {
                nroIngresado = int.Parse(Console.ReadLine());
                if (nroIngresado >= min && nroIngresado <= max) {
                    esNumero = true; 
                }
                else throw new Exception($"El numero debe estar entre {min}-{max}"); 
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No se puede ingresar un valor vacío.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Formato inválido: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Número fuera del rango permitido: {ex.Message}");
            }
            catch (Exception ex) {  Console.WriteLine(ex.Message); }

        } while (!esNumero);
        return nroIngresado;
    }
    public static string ValidarDNI(string mensaje = "Ingrese DNI: ")
    {
        string dni = "";
        bool esValido = false;

        do
        {
            Console.Write(mensaje);
            dni = Console.ReadLine();

            try
            {
                // Verificar que no esté vacío
                if (string.IsNullOrWhiteSpace(dni))
                {
                    throw new ArgumentException("El DNI no puede estar vacío.");
                }

                // Remover espacios y puntos si los hay
                dni = dni.Replace(".", "").Replace(" ", "");

                // Verificar que tenga exactamente 8 dígitos
                if (dni.Length != 8)
                {
                    throw new ArgumentException("El DNI debe tener exactamente 8 dígitos.");
                }

                // Verificar que solo contenga números
                if (!Regex.IsMatch(dni, @"^\d{8}$"))
                {
                    throw new ArgumentException("El DNI solo debe contener números.");
                }

                // Verificar que no sea un DNI obviamente inválido (todos iguales)
                if (Regex.IsMatch(dni, @"^(\d)\1{7}$"))
                {
                    throw new ArgumentException("DNI inválido (no puede tener todos los dígitos iguales).");
                }

                esValido = true;
                Console.WriteLine($"✓ DNI válido: {dni}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

        } while (!esValido);

        return dni;
    }

    // Validador de Nombres y Apellidos
    public static string ValidarNombre(string mensaje = "Ingrese nombre: ")
    {
        string nombre = "";
        bool esValido = false;

        do
        {
            Console.Write(mensaje);
            nombre = Console.ReadLine();

            try
            {
                // Verificar que no esté vacío
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }

                // Limpiar espacios extra
                nombre = nombre.Trim();

                // Verificar longitud mínima y máxima
                if (nombre.Length < 2)
                {
                    throw new ArgumentException("El nombre debe tener al menos 2 caracteres.");
                }

                if (nombre.Length > 50)
                {
                    throw new ArgumentException("El nombre no puede tener más de 50 caracteres.");
                }

                // Verificar que solo contenga letras, espacios y acentos
                if (!Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑüÜ\s]+$"))
                {
                    throw new ArgumentException("El nombre solo debe contener letras, espacios y acentos.");
                }

                // Capitalizar primera letra de cada palabra
                nombre = CapitalizarNombre(nombre);

                esValido = true;
                Console.WriteLine($"✓ Nombre válido: {nombre}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

        } while (!esValido);

        return nombre;
    }

    // Validador de número de tarjeta
    public static long ValidarNumeroTarjeta(string mensaje = "Ingrese número de tarjeta: ")
    {
        long numeroTarjeta = 0;
        bool esValido = false;

        do
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();

            try
            {
                // Verificar que no esté vacío
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("El número de tarjeta no puede estar vacío.");
                }

                // Remover espacios y guiones si los hay
                input = input.Replace(" ", "").Replace("-", "");

                // Verificar que solo contenga números
                if (!Regex.IsMatch(input, @"^\d+$"))
                {
                    throw new ArgumentException("El número de tarjeta solo debe contener dígitos.");
                }

                // Verificar longitud (generalmente 13-19 dígitos)
                if (input.Length < 13 || input.Length > 19)
                {
                    throw new ArgumentException("El número de tarjeta debe tener entre 13 y 19 dígitos.");
                }

                // Convertir a long
                numeroTarjeta = long.Parse(input);

                // Validar con algoritmo de Luhn (opcional pero recomendado)
                if (!ValidarLuhn(input))
                {
                    throw new ArgumentException("El número de tarjeta no pasa la validación de Luhn.");
                }

                esValido = true;
                Console.WriteLine($"✓ Número de tarjeta válido: {numeroTarjeta}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("❌ Error: El número es demasiado grande.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

        } while (!esValido);

        return numeroTarjeta;
    }

    // Validador de código de seguridad
    public static int ValidarCodigoSeguridad(string mensaje = "Ingrese código de seguridad (CVV): ")
    {
        int codigoSeguridad = 0;
        bool esValido = false;

        do
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();

            try
            {
                // Verificar que no esté vacío
                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("El código de seguridad no puede estar vacío.");
                }

                // Verificar que solo contenga números
                if (!Regex.IsMatch(input, @"^\d+$"))
                {
                    throw new ArgumentException("El código de seguridad solo debe contener números.");
                }

                // Verificar longitud (3 o 4 dígitos)
                if (input.Length < 3 || input.Length > 4)
                {
                    throw new ArgumentException("El código de seguridad debe tener 3 o 4 dígitos.");
                }

                codigoSeguridad = int.Parse(input);

                esValido = true;
                Console.WriteLine($"✓ Código de seguridad válido: {new string('*', input.Length)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Error: {ex.Message}");
            }

        } while (!esValido);

        return codigoSeguridad;
    }

    // Método auxiliar para capitalizar nombres
    private static string CapitalizarNombre(string nombre)
    {
        string[] palabras = nombre.Split(' ');
        for (int i = 0; i < palabras.Length; i++)
        {
            if (!string.IsNullOrEmpty(palabras[i]))
            {
                palabras[i] = char.ToUpper(palabras[i][0]) + palabras[i].Substring(1).ToLower();
            }
        }
        return string.Join(" ", palabras);
    }

    // Algoritmo de Luhn para validar números de tarjeta
    private static bool ValidarLuhn(string numero)
    {
        int suma = 0;
        bool alternar = false;

        // Procesar de derecha a izquierda
        for (int i = numero.Length - 1; i >= 0; i--)
        {
            int digito = int.Parse(numero[i].ToString());

            if (alternar)
            {
                digito *= 2;
                if (digito > 9)
                    digito -= 9;
            }

            suma += digito;
            alternar = !alternar;
        }

        return suma % 10 == 0;
    }
    public static Cliente SolicitarDatosCliente()
    {
        Console.WriteLine("=== INGRESO DE DATOS DE TARJETA ===");
        string dni = ValidarDNI("Ingrese DNI (8 dígitos): ");
        string nombres = ValidarNombre("Ingrese nombres: ");
        string apellidos = ValidarNombre("Ingrese apellidos: ");
        Console.WriteLine("\n✅ Todos los datos han sido validados correctamente.");
        return new Cliente(dni, nombres, apellidos);
    }
    public static TDCredito SolicitarDatosTarjeta()
    {
        Console.WriteLine("=== INGRESO DE DATOS DE TARJETA ===");
        long nroTarjeta = ValidarNumeroTarjeta("Ingrese número de tarjeta: ");
        int codSeg = ValidarCodigoSeguridad("Ingrese código de seguridad: ");

        Console.WriteLine("\n✅ Todos los datos han sido validados correctamente.");

        return new TDCredito(nroTarjeta, codSeg);
    }
    // Método para solicitar todos los datos con validación
    private bool ValidarEntidadSeleccionada(int opcion, long numeroTarjeta)
    {
        string numero = numeroTarjeta.ToString();

        switch (opcion)
        {
            case 1: // Visa
                return numero.StartsWith("4407");
            case 2: // Mastercard
                return numero.StartsWith("3890");
            case 3: // Diners Club
                return numero.StartsWith("7401");
            default:
                return true;
        }
    }
}
