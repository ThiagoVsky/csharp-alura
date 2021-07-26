using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(1251, 541301);
                ContaCorrente conta2 = new ContaCorrente(125, 541301);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Transferir(50, conta2);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("\n\nExecução finalizada, pessione enter para fechar.");
            Console.ReadLine();
        }
    }
}
