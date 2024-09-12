using System;
namespace Laboratorio_42;

public class Program
{
    static void Main(string[] args)
    {
        int fac = 1, n;
        string linea;
        Console.Write("Introduzca el valor n: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        for (int i = 1; i <= n; i++)
        {
            fac = fac * i;
        }
        Console.WriteLine("la factorial es: " + fac);
        Console.ReadKey();
    }
}