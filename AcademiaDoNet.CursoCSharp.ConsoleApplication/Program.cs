using System;

namespace AcademiaDoNet.CursoCSharp.ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nomeCorrentista = "Ray carneiro";
            Console.WriteLine("Nome da variavel: " + nomeCorrentista);

            var nomeCorrentista1 = Console.ReadLine();
            Console.WriteLine("Nome da variavel: " + nomeCorrentista);

            var dataAniversario = Convert.ToDateTime("13/03/1987");

            double saldo = 100.0;
            saldo = saldo - 10.0;
            Console.WriteLine("Saldo atual: " + saldo);

        }
    }
}
