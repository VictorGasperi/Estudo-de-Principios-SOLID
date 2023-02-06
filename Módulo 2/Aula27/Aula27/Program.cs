namespace Aula27
{
    /// <summary>
    /// Aula sobre Heranca
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new ();
            cp.Saldo = cp.Deposito(110);
            cp.Saldo = cp.Saque(10);


        }
    }
}