using System;

namespace ByteBank
{
    class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(string message) : base (message) {

        } 

        public SaldoInsuficienteException(double saldo, double valorSaque) :
            this("O valor do saldo " + saldo + " é menor do que o valor do saque " + valorSaque + ".")
        {
            
        }

    }
}
