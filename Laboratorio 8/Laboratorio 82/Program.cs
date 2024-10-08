using System;
namespace Laboratorio_82;
public class Cuenta
{
    private string IdCuenta;
    public Cuenta(string prmtIdCuenta)
    {
        this.IdCuenta = prmtIdCuenta;
        System.Console.WriteLine("Constructor clase base para cuenta {0}", this.IdCuenta);
    }
    public virtual void CalcularIntereses()
    {
        System.Console.WriteLine("Cuenta.Calcularintereses() efectuado por {0}", this.IdCuenta);
    }
    public string getIdCuenta() { return this.IdCuenta; }

}
public class CuentaCorriente : Cuenta
{
    public CuentaCorriente(string prmtIdCuenta) : base(prmtIdCuenta)
    {    
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine("CuentaCorriente.CalcularIntereses() efectuado para" + "la cuenta {0}", getIdCuenta());
    }
}
public class CuentaAhorro : Cuenta
{
    public CuentaAhorro(string prmtIdCuenta) : base(prmtIdCuenta)
    {
    }

    public override void CalcularIntereses()
    {
        System.Console.WriteLine("CuentaAhorro.CalcularIntereses() efectuado para" + "la cuenta {0}", getIdCuenta());
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        const string CUENTA = "100";
        Cuenta cuenta = new Cuenta(CUENTA);
        CuentaCorriente cuentaCorriente = new CuentaCorriente(CUENTA);
        CuentaAhorro cuentaAhorro
    }
}