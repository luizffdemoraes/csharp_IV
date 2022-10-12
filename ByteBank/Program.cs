﻿using System;
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
                ContaCorrente conta = new ContaCorrente(5025, 52665);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.Message);
            }
            catch(SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }

            Metodo();
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);

            Console.WriteLine("Resultado da divisão de 10 por" + divisor + " é  " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {

            return numero / divisor;

            Console.WriteLine("Exceção com numero = " + "e divisor = " + divisor);
            //throw ;

        }

        /*
        Dividir <-
        TestaDivisao
        Metodo
        Main
        */
    }
}
