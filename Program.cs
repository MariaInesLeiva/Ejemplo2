using System.Data;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //Objeto HelloWorld 1
        HelloWorld objetoHelloW = new HelloWorld("Hola desde el menú");

        Console.WriteLine (objetoHelloW.ObtenerSaludo());
        objetoHelloW.Saludar();

        objetoHelloW.DefinirNombre("Luis");

        Console.WriteLine(objetoHelloW.ObtenerSaludo() + " " + objetoHelloW.ObtenerNombre());

        //Objeto HelloWorld 2
        HelloWorld helloWorld2 = new HelloWorld("Hola 2");
        Console.WriteLine(helloWorld2.ObtenerSaludo());

        //Objeto Calculadora
        Calculadora objCalculadora = new Calculadora();
        Console.WriteLine(objCalculadora.suma(1,2));

        //Semana 10
        
    }
}