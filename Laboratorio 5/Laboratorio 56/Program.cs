using System;
namespace Laboratorio_56;

public class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> paisesYCapitales = new Dictionary<string, string>()
        {
            {"Francia", "Paris" },
            {"España", "Madrid" },
            {"italia", "Roma" }
        };
        foreach(KeyValuePair<string, string> par in paisesYCapitales)
        {
            Console.WriteLine("La capital de " + par.Key + "es" + par.Value);
        }
    }

}