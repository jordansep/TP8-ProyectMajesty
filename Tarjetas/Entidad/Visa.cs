using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Visa : TDCredito
{
    public Visa(long nroTarjeta, int codSeg, string entidad)
        : base(nroTarjeta, codSeg, entidad)
    {
    }
}