using System;
namespace Laboratorio_64;

public class Program
{
    static void CheckAge(int age)
    {
        if(age < 18)
        {
            throw new ArithmeticException("Acceso Negado - no cumple con el criterio de edad");
        }
        else
        {
            Console.WriteLine("Acceso Concedido");
        }
    }
    static void Main(string[] args)
    {
        CheckAge(15);
    }
}