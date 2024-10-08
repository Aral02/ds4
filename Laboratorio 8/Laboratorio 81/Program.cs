using System;
namespace Laboratorio_81;

public class Program
{
    internal class Persona
    {

        //Campo de cada objeto persona que almacena su nombre
        public string Nombre;
        public int Edad;
        public string NIF;

        void Cumpleaños()
        {
            Edad++;
        }

        public Persona(string nombre,  int edad, string nif)
        {
            Nombre = nombre;
            Edad = edad;
            NIF = nif;

        }
    }

    internal class Trabajador : Persona
    {
        public int Sueldo;
        public Trabajador(string nombre,int edad, string nif ,int sueldo) : base(nombre, edad, nif)
        {
            Sueldo = sueldo;
        }
    }


    static void Main(string[] args)
    {
        Trabajador p = new Trabajador("josan", 22, "77588260-Z", 100000);
        Console.WriteLine("Nombre=" + p.Nombre);
        Console.WriteLine("Edad=" + p.Edad);
        Console.WriteLine("NIF=" + p.NIF);
        Console.WriteLine("Sueldo=" + p.Sueldo);
        Console.ReadKey();
    }
}