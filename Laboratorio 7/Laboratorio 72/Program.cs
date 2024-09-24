using System;
namespace Laboratorio_72;

class Dado
{
    private int Valor;
    private static Random aleatorio;

    public Dado()
    {
        aleatorio = new Random();
    }
    public void Tirar()
    {
        Valor = aleatorio.Next(1,7);
    }

    public void Imprimir()
    {
        Console.WriteLine("El valor del dado es: " + Valor);
    }
    public int RetornarValor()
    {
        return Valor;
    }
}

class JuegoDeDados
{
    private Dado dado1, dado2, dado3;

    public JuegoDeDados()
    {
        dado1 = new Dado();
        dado2 = new Dado();
        dado3 = new Dado();
    }

    public void jugar()
    {
        dado1.Tirar();
        dado1.Imprimir();
        dado2.Tirar();
        dado2.Imprimir();
        dado3.Tirar();
        dado3.Imprimir();
        if (dado1.RetornarValor() == dado2.RetornarValor() && dado1.RetornarValor == dado3.RetornarValor)
        {
            Console.WriteLine("GANÓ");
        }
        else
        {
            Console.WriteLine("PERDIÓ");
        }
        Console.ReadKey();
    }
}


public class Program
{
    static void Main(string[] args)
    {
        JuegoDeDados j = new JuegoDeDados();
        j.jugar();
    }
}