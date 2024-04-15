using System.Data;
using Microsoft.VisualBasic;

class HelloWorld
{
    private string saludo = "Hola";
    private string nombre = "";

    public HelloWorld(string nuevoSaludo)
    {
        saludo = nuevoSaludo;
    }   

    public string ObtenerSaludo()
    {
        return saludo;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public void DefinirNombre(string pNombre)
    {
        nombre = pNombre;
    }

    public void Saludar()
    {
        Console.WriteLine(saludo);
    }
}