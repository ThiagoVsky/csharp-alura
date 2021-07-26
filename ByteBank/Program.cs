using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(1251, 541301);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(-500);
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
