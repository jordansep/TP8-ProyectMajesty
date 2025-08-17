using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Visa : TarjetadeCredito
{

    private string dni;
    private string entidad;
    private string nombres;
    private string apellidos;
    private string nroTarjeta;
    private string codSeg;
    public Visa(string dni, string entidad, string nombres, string apellidos, string nroTarjeta, string codSeg) : base(dni, entidad, nombres, apellidos, nroTarjeta, codSeg)
    {
    }
}