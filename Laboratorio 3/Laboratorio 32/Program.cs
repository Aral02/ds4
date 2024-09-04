using Laboratorio_31;
namespace laboratorio_32
{
    public class CalculosMatematicos
    {
        public double r { get; set; }
        public double calculoArea(double r)
        {
            double operacion = Math.PI * (Math.Pow(r,2)) ;

            Console.WriteLine("Resultado de la operación: ", operacion);

            return operacion;
        }


    }

    public class Program
    {
        static void Main(string[] args)
        {
            CalculosMatematicos radio = new CalculosMatematicos();
            Console.Write("introduce la radio del circulo: ");
            radio.r = Convert.ToInt32(Console.ReadLine());
            double res = radio.calculoArea(radio.r);
            Console.WriteLine(res);
        }

    }
}