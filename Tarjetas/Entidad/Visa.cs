using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Visa : TDCredito
{
    public Visa(string dni, string entidad, string nombres, string apellidos, long nroTarjeta, int codSeg)
        : base(dni, nombres, apellidos, nroTarjeta, codSeg, entidad)
    {
    }
}