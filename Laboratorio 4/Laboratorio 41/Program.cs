using System;
namespace Laboratorio_41;

public class Program
{
    static void Main(string[] args)
    {
        int n, x;
        string linea;
        Console.Write("Introduzca el valor n: ");
        linea = Console.ReadLine();
        n = int.Parse(linea);
        x = 1;
        while (x <= n)
        {
            Console.Write(x);
            Console.Write(", ");
            x = x + 1;
        }
        Console.ReadKey();
    }
}
