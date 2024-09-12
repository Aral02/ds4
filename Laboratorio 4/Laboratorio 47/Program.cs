using System;
namespace Laboratorio_47;

public class Program
{
    static void Main(string[] args)
    {

        int numeroUno = 70;
        double numeroDos = 67.89;
        double numeroTres = 67.89;
        Console.WriteLine(Suma(numeroUno, numeroDos));
        Console.WriteLine(Suma(numeroUno, numeroDos, numeroTres));
        //compare y analice las dos salidas de la suma
        //respuesta: la primera suma funciona aun sin el numero 3 ya que este tiene asignado opcionalmente el 0 de la 'z'
    }
    static double Suma (int x, double y, double z = 0)
    {
        return x + y + z;
    }
}