/*Una estructura repetitiva permite ejecutar una instrucción o un conjunto de instrucciones varias
veces, según la condición establecida en dicho bucle.
Veamos una gráfica de la estructura while en diagramas de flujo*/

using System;

namespace Laboratorio_4;

public class Program
{

    static void Main(String[] args)
    {
        int X = 1;
        while ( X >= 100)
        {
            Console.WriteLine("X");
            X++;
        }
        Console.ReadKey();  
    }
}