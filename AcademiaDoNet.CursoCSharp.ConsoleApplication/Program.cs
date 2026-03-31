using System;

namespace AcademiaDoNet.CursoCSharp.ConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var nomeCorrentista = "Ray carneiro";
            //Console.WriteLine("Nome da variavel: " + nomeCorrentista);

            //var nomeCorrentista1 = Console.ReadLine();
            //Console.WriteLine("Nome da variavel: " + nomeCorrentista);

            //var dataAniversario = Convert.ToDateTime("13/03/1987");

            //double saldo = 100.0;
            //saldo = saldo - 10.0;
            //Console.WriteLine("Saldo atual: " + saldo);

            //string[] nomes = new string[2];

            //nomes[0] = "Ray carneiro";
            //nomes[1] = "Fulano de Silva";

            //string[] nomes1 = new string[2] { "Ray carneiro", "Fulano da Silva" };

            const double Pi = 3.14;
            double raio = 5.3;
            double area = Pi * (raio * raio);
            Console.WriteLine("O valor da area é: " + area);
        }
    }
}
