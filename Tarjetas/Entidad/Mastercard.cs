using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mastercard : TarjetadeCredito
{
    public Mastercard(string dni, string entidad, string nombres, string apellidos, string nroTarjeta, string codSeg) : base(dni, entidad, nombres, apellidos, nroTarjeta, codSeg)
    {
    }
}
