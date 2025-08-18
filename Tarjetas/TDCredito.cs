using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public interface IRequerimientos
{
    void Req1();
    void Req2();
    void Req3();
    void Req4();
    void Req5();
    void Req6();
    void Req7();
    void Req8();
    void Req9();
    void Req10();
}
public class TDCredito
{
    private string entidad;
    private long nroTarjeta;
    private int codSeg;
    public TDCredito(long nroTarjeta, int codSeg, string entidad)
    {
        this.nroTarjeta = nroTarjeta;
        this.codSeg = codSeg;
        this.entidad = entidad;
    }
    public TDCredito(long nroTarjeta, int codSeg)
    {
        this.nroTarjeta = nroTarjeta;
        this.codSeg = codSeg;
        EntidadFinanciera();
    }

    // A que entidad financiera pertenece la tarjeta.
    public void EntidadFinanciera()
    {
        string tarjetaEmpieza = this.nroTarjeta.ToString();
        if (tarjetaEmpieza.StartsWith("4407"))
        {
            this.entidad = "Visa";
        }
        else if (tarjetaEmpieza.StartsWith("3890"))
        {
            this.entidad = "Mastercard";
        }
        else if (tarjetaEmpieza.StartsWith("7401"))
        {
            this.entidad = "DinerClub";
        }
        else
        {
            this.entidad = "Tarjeta no valida";
        }
    }


    // Mostramos los datos de la tarjeta.
    public void MostrarDatos()
    {
        Console.WriteLine($" Emisor: {this.entidad}\n Dni:| Nombre: \n Numero: {this.nroTarjeta}\n Codigo de Seguridad: {this.codSeg}");
    }

    // Sistema de uso.
    public void Usar()
    {
        Console.WriteLine("Usted a realizado una compra.");
    }

    // Almacenar y buscar facturas.
    public void Facturas()
    {
        Console.WriteLine("Local: , Productos: ,Fecha: ");
        string filePath ="";
    }
}