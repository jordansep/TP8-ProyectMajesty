using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Requerimientos
{
    private string entidad;
    private string nroTarjeta;
    public Requerimientos(string nroTarjeta, string entidad = "")
    {
        this.entidad = entidad;
        this.nroTarjeta = nroTarjeta;
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
    
}
