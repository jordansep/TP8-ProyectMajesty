using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mastercard : TDCredito
{
    public Mastercard(string dni, string nombres, string apellidos, long nroTarjeta, int codSeg, string entidad) 
        : base(dni, nombres, apellidos, nroTarjeta, codSeg, entidad)
    {
    }
}
