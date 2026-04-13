using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaDoNet.CursoCSharp.ConsoleApplication.Entidade
{
    public class Pessoa
    {
        //propriedades
        public string Nome { get; set; }
        public string CPF { get; set; }

        public string NumeroContaCorrente { get; set; }

        //métodos (ações)
        public double EfetuarDeposito(double valorDeposito)
        {
            double saldo = 100.0;
            saldo = valorDeposito * saldo;;
            return saldo;
        }
    }
}
