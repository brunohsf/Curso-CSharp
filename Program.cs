using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(0);
            Diretor roberta = new Diretor(1);


            carlos.Nome = "Carlos";
            carlos.CPF = "11144477735";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);


            roberta.Nome = "Roberta";
            roberta.CPF = "11144477736";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());


            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());
            Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");

            Console.ReadKey();
        }
    }
}
