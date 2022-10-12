// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        // Criação da propriedade
        public static double TaxaOperacao { get; set; }

        public static int TotalDeContasCriadas { get; set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            // Operação matemática o número de contas influencia na taxa de operação, isso gera exception por realizar um divisão por 0
            //TaxaOperacao = 30 / TotalDeContasCriadas;

            if (agencia <= 0)
            {
                throw new ArgumentException("Os argumento agencia devem ser maior que 0.");
            }
            if (numero <= 0)
            {
                throw new ArgumentException("Os argumento numero devem ser maior que 0.");
            }

            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Saldo insuficiente para saque no valor de "+ valor);
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }

            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
