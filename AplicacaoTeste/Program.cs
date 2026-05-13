using System;

namespace AplicacaoTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numeroA = 10;
            //int numeroB = 20;

            int numeroA = 10;
            int numeroB = 20;

            int resultadoSoma = numeroA + numeroB;
            Console.WriteLine("O valor da soma de A + B = " + resultadoSoma);

            int resultadoSubtracao = numeroA - numeroB;
            Console.WriteLine("O valor da subtração de A - B = " + resultadoSubtracao);

            int resultadoMultiplicacao = numeroA * numeroB;
            Console.WriteLine("O valor da subtração de A * B = " + resultadoMultiplicacao);

            float resultadoDivisao = (float)numeroA / numeroB;
            Console.WriteLine("O valor da divisão de A / B = " + resultadoDivisao);

        }
    }
}
