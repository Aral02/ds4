using System;

namespace laboratorio21
{
    public class Program
    {
        public static void Main()
        {
            //Asignando valor a la variable estática   
            MyClass.valor = 1;
            Console.WriteLine(MyClass.valor);
        }
    }
    public class MyClass
    {
        //Declarando variable estatica
        public static int valor;

    }
}