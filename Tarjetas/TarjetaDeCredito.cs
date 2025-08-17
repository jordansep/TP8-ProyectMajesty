using System;
using System.Collections.Generic;
using System.Linq;
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
public class TarjetadeCredito:IRequerimientos
{
    private string dni;
    private string entidad;
    private string nombres;
    private string apellidos;
    private string nroTarjeta;
    private string codSeg;
    public TarjetadeCredito(string dni, string nombres, string apellidos, string nroTarjeta, string codSeg, string entidad ="")
    {
        this.dni = dni;
        this.entidad = entidad.ToLower();
        this.nombres = nombres.ToLower();
        this.apellidos = apellidos.ToLower();
        this.nroTarjeta = nroTarjeta;
        this.codSeg = codSeg;
    }
    public void MostrarDatos()
    {
        Console.WriteLine($" Emisor: {this.entidad}\n Dni: {this.dni} | Nombre: {nombres} {this.apellidos}\n Numero: {this.nroTarjeta}\n Codigo de Seguridad: {this.codSeg}");
    }
    public void Usar()
    {
        Console.WriteLine("Usted a realizado una compra.");
    }
    public void Facturas()
    {
        Console.WriteLine("Local: , Productos: ,Fecha: ");
    }
    public void EntidadFinanciera()
    {
        if (this.nroTarjeta.Contains(15666.ToString()))
        {
            this.entidad = "Visa";
        }
        else
        {
            this.entidad = "Mastercard";
        }
    }
    public void Req1()
    {
        Console.WriteLine("ReqUno");
    }
    public void Req2()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req3()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req4()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req5()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req6()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req7()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req8()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req9()
    {
        Console.WriteLine("ReqUno");

    }
    public void Req10()
    {
        Console.WriteLine("ReqUno");

    }
}