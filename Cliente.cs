using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Cliente
{
    protected string dni { get; private set; }
    protected string nombres { get; private set; }
    protected string apellidos { get; private set; }
    protected string filePath { get; private set; }
    public string folderPath { get; private set; }
    protected Dictionary<int, string> Transacciones { get; private set; }
    public Cliente(string dni, string nombres, string apellidos)
    {
        this.dni = dni;
        this.nombres = nombres;
        this.apellidos = apellidos;
    }
    public void DBTransaction()
    {
        string directoryPath = Directory.GetCurrentDirectory();
        string folderPath = Path.Combine(directoryPath, "Clientes");
        string filePath = Path.Combine(folderPath, $"{this.dni}-{this.nombres}-{this.apellidos}.txt");
        if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);
        if (!File.Exists(filePath)) File.Create(filePath);
    }
    
    public string GetFolderPath() => folderPath;
    public string GetFilePath() => filePath;
}
