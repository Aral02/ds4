using System;
    namespace Laboratorio2
    {
    class Program
    {
        public void Sumar(int valor1, int valor2)
        {
            int variableLocal = valor1 + valor2; //declaración de la variable local
            Console.WriteLine(variableLocal); //resultado de la suma
        }
        static void Main(string[] args)
        {
            Client client = new Client();
            client.FirstName = "Ariel";
            client.LastName = "Chong";
            client.Age = 22;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());

            char caracter = 'A'; //Variable almacenando un caracter
            string cadena = "cadena de caracteres"; //Variable almacenando una cadena de caracteres
            bool condicion = true;

            int valor1 = 28;
            int valor2 = valor1;
            valor2 = 30;
            //Imprimiendo en consolas variables
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);
        MyClass object1 = new MyClass();
            object1.Nombre = "Fulano";
            object1.Edad = 28;
            MyClass object2 = object1;
            object2.Nombre = "Jose";
            //Al imprimir en consola vemos que ambas referencias imprimen el mismo valor jose
            Console.WriteLine(object2);
            Console.WriteLine(object1);
        }
    }
        public class Client
        {
            public int Id { get; set; }
            public string FirstName { get; set;} 
            public string LastName { get; set;} 
            public ushort  Age { get; set;}
            public string GetFullName()
            {
                return FirstName + " " + LastName;
            }
        }
        public class MyClass
        {
            //Declarando variable estática 
            public static int Valor;
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
        

    }