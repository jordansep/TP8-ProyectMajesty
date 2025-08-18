using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DinnerClub: TDCredito
{
    public DinnerClub(long nroTarjeta, int codSeg, string entidad)
        : base(nroTarjeta, codSeg, entidad)
    {
    }
}
