using System; 
namespace Laboratorio_51;

public class Program
{
    private static int[] sueldos;
    internal class PruebaVector1()
    {
        public void Cargar()
        {
            sueldos = new int[6]; //Declaramos variable en 5
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese el numero del operario" + f + ": ");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea); //Asignamos los 5 sueldos al vector
            }
        }
        //Muestra los sueldos de los operarios en el vector sueldos [f]
        public void Imprimir()
        {
            Console.Write("Los 5 sueldos de los operarios \n");
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("[" + sueldos[f] + "] ");
            }
            Console.ReadKey();
        }
    }
    //Main principal
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1 ();
        pv.Cargar();    
        pv.Imprimir();
    }
  
}
