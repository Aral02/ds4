using System;
namespace Laboratorio_62;

public class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Digite el número deseado: ");
        try
        {
            num = Int16.Parse(Console.ReadLine());
        }
        catch (FormatException ex)
        {
            Console.WriteLine("no ha introducido un dígito valido");
            num = -1;
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("El número introducido es muy grande");
            num = -1;
        }
        Console.WriteLine(num);
    }
}