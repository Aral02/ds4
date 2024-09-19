using System;
namespace Laboratorio_55;


     class Estudiante
    {
        public string Nombre { get; set; }
        public int edad { get; set; }
    }

public class Program {
    static void Main(String[] args) {
        List<Estudiante> estudiantes = new List<Estudiante>
    {
        new Estudiante { Nombre = "Ana", edad = 12 },
        new Estudiante { Nombre = "Juan", edad = 10 },
        new Estudiante { Nombre = "Sofia", edad = 11}
    };
        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine("Nombre: " + estudiante.Nombre + ", Edad: " + estudiante.edad);
        }
    }        
}