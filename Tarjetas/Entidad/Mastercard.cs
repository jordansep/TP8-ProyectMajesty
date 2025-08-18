using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mastercard : TDCredito
{
    public Mastercard(long nroTarjeta, int codSeg, string entidad)
        : base(nroTarjeta, codSeg, entidad)
    {
    }
}
