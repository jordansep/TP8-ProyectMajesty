using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente
{
    string dni;
    string nombres;
    string apellidos;
    public Cliente(string dni, string nombres, string apellidos)
    {
        this.dni = dni;
        this.nombres = nombres;
        this.apellidos = apellidos;
    }
}
