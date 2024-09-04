using System;
using System.Reflection.Metadata.Ecma335;

namespace Laboratorio_31
{
    public class CalculosMatematicos
    {
        public int a { get; set; }
        public int b { get; set; }

        public int Calcular(int a, int b)
        {
            int operacion = (a + b) * (a - b);

            Console.WriteLine("Resultado de la operación: ", operacion);

            return operacion;
        }


    }
    public class Program
    {
        static void Main(string[] args)
        {
            CalculosMatematicos calculo = new CalculosMatematicos();
            Console.Write("introduce el primer numero: ");
            calculo.a = Convert.ToInt32(Console.ReadLine());

            Console.Write("introduce el segundo numero: ");
            calculo.b = Convert.ToInt32(Console.ReadLine());
            int res = calculo.Calcular(calculo.a, calculo.b);
            Console.WriteLine(res);
        }
        
    }
}