using System;

namespace Laboratorio_33
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("introduce el largo del rectangulo: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("introduce el ancho del rectangulo: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int res = 2 * (a + b);
            Console.WriteLine("El perimetro es:", res);
        }

    }
}