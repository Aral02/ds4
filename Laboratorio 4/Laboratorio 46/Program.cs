using System;
namespace Laboratorio_46;

public class Program
{
    static void Main(string[] args)
    {
       
       Console.WriteLine("Digite el radio  del circulo");
        double radio = double.Parse(Console.ReadLine());
        double area = Math.Pow(radio, 2) * Math.PI;
        Console.WriteLine($"El área del circulo es: {area}");
    }
}