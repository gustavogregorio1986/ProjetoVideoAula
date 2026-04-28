using AcademiaDoNet.CursoCSharp.ConsoleApplication.Entidade;
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

            //List<string> nomes = new List<string>();
            //nomes.Add("Fulando da Silva");
            //nomes.Add("Beltrano da Silva");
            //nomes.Add("Ray");

            //Console.WriteLine("Posição Inicial da lista: " + nomes[0] + " com tamanho de lista: " + nomes.Count);

            //bool existeNaLista = nomes.Contains("Ray");
            //Console.WriteLine("Existe na lista?: " + existeNaLista);

            //var diaDasemana = DiasDaSemana.DomingoFeira;
            //Console.WriteLine("Hoje é dia: " + diaDasemana);

            //int diasemana = (int)DiasDaSemana.DomingoFeira;
            //Console.WriteLine("Hoje é dia: " + diasemana);

            //int tamanho = 10;
            //for (int i = 0; i < tamanho; i++)
            //{
            //    Console.WriteLine("Valor da variavel de i: " + i);

            //}

            //double saldoConta = 100.0;
            //Console.WriteLine("Digite um valor para debitar da sua conta: ");
            //var debitar = Convert.ToDouble(Console.ReadLine());

            //saldoConta = saldoConta - debitar;

            //if(saldoConta > 0)
            //{
            //    Console.WriteLine("Seu saldo é positivo. Ainda restam {0} em conta", saldoConta);
            //}
            //else
            //{
            //    Console.WriteLine("Seu saldo é negativo");
            //}

            //List<string> nomes = new List<string> { "Ray Carneiro", "Pollyanna Carneiro", "Fernando mendes" };

            //foreach (string item in nomes)
            //{
            //    {
            //        Console.WriteLine("O nome da pessoa é: " + item);
            //    }
            //}

            //double saldoConta = 100.0;
            //Console.WriteLine("Digite um valor para debitar da sua conta: ");
            //var debitar = Convert.ToDouble(Console.ReadLine());

            //saldoConta = saldoConta - debitar;

            //switch (saldoConta) {
            //    case 50.0:
            //        Console.WriteLine("Você depositou 50 da sua conta");
            //        break;
            //    case 10.0:
            //        Console.WriteLine("Você depositoy 90 da sua conta");
            //        break;
            //    default:
            //        Console.WriteLine("Você depoistou {0} da sua conta", debitar);
            //        break;
            //}


            //saldoConta = saldoConta - debitar;

            //if(saldoConta > 0)
            //{
            //    Console.WriteLine("Seu saldo é positivo. Ainda {0} em conmta", saldoConta);
            //}
            //else
            //{
            //    Console.WriteLine("Seu saldo é negativo!");
            //}

            //Pessoa pessoa1 = new Pessoa();
            //pessoa1.Nome = "Ray Carneiro";
            //pessoa1.CPF = "123456789";
            //pessoa1.NumeroContaCorrente = "010204";


            //Pessoa pessoa2 = new Pessoa()
            //{
            //    Nome = "Pollyanna Carneiro",
            //    CPF = "123456789",
            //    NumeroContaCorrente = "010204"

            //};

            //List<Pessoa> ListaDePessoas = new List<Pessoa>();
            //ListaDePessoas.Add(pessoa1);
            //ListaDePessoas.Add(pessoa2);

            //foreach(var pessoa in ListaDePessoas)
            //{
            //    Console.WriteLine("Nome: " + pessoa.Nome);
            //    Console.WriteLine("CPF: " + pessoa.CPF);
            //    Console.WriteLine("Número da Conta Corrente: " + pessoa.NumeroContaCorrente);
            //    Console.WriteLine();
            //}

            //Console.WriteLine(pessoa1.EfetuarDeposito(50.0));

            //#region Região de deposito

            //double valorDeposito = 50.0;
            //Console.WriteLine("O saldo da vconta é de: " + pessoa1.EfetuarDeposito(valorDeposito));

            //#endregion

            //Console.WriteLine("Qual será o nome do seu pagamwento: ");
            //string nomePagamento = Console.ReadLine();

            //Console.WriteLine("Ola, " + nomePagamento);

            Console.WriteLine("Qual será o nome do seu personagem: ");
            string nomePersonagem = Console.ReadLine();

            Console.WriteLine("Ola, " + nomePersonagem);

            bool personagemView = true;

            if (personagemView)
            {
                Console.WriteLine("O personagem está vivo");
            }
            else
            {
                Console.WriteLine("O personagem não está morto");
            }
        }
    }
}