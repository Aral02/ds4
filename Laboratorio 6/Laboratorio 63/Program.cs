using System;
namespace Laboratorio_63;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            int[] myNumbers = { 1, 2, 3 };
            Console.WriteLine(myNumbers[10]);
        }
        catch (Exception e)
        {
            Console.WriteLine("Algo salió mal, valide el índice de arreglo");
        }
        finally
        {
            Console.WriteLine("Continuación de la aplicación luego del try/catch");
        }
    }
}