using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
}
