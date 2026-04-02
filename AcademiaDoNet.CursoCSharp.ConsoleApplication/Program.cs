using System;
using System.Collections.Generic;

namespace AcademiaDoNet.CursoCSharp.ConsoleApplication
{
    internal class Program
    {
        enum DiasDaSemana
        {
            DomingoFeira = 0,
            SegundaFeira = 1,
            TercaFeira = 2,
            QuartaFeira = 3,
            QuintaFeira = 4,
            SextaFeira = 5,
            Sabado = 6
        }

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

            //const double Pi = 3.14;
            //double raio = 5.3;
            //double area = Pi * (raio * raio);
            //Console.WriteLine("O valor da area é: " + area);

            //List<string> nomes = new List<string> { "Fulando da Silva","Beltrano da Silva"};

            List<string> nomes = new List<string>();
            nomes.Add("Fulando da Silva");
            nomes.Add("Beltrano da Silva");
            nomes.Add("Ray");

            Console.WriteLine("Posição Inicial da lista: " + nomes[0] + " com tamanho de lista: " + nomes.Count);

            bool existeNaLista = nomes.Contains("Ray");
            Console.WriteLine("Existe na lista?: " + existeNaLista);

            var diaDasemana = DiasDaSemana.DomingoFeira;
            Console.WriteLine("Hoje é dia: " + diaDasemana);

            int diasemana = (int)DiasDaSemana.DomingoFeira;
            Console.WriteLine("Hoje é dia: " + diasemana);

        }
    }
}
