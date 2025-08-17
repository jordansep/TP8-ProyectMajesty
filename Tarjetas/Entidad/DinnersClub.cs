using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DinnerClub: TDCredito
{
    public DinnerClub(string dni, string entidad, string nombres, string apellidos, long nroTarjeta, int codSeg)
        : base(dni, entidad, nombres, nroTarjeta, codSeg, apellidos)
    {
    }
}
