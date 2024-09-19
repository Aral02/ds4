using System;
namespace Laboratorio_61;

    public class Program
    {
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el ´número deseado: ");
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("no ha introducido un dígito valido");
            num = -1;
        }
        Console.WriteLine(num);
    }
    }