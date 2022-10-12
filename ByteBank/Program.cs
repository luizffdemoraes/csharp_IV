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
            //ContaCorrente conta = new ContaCorrente(7480, 874250);
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            try
            {
                Metodo();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Não é possível dividir um número por 0!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Ocorreu um erro!");
            }
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
            ContaCorrente conta = null;

            return numero / divisor;
        }

        /*
        Dividir <-
        TestaDivisao
        Metodo
        Main
        */
    }
}
