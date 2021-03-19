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

            Funcionario carlos = new Funcionario("11144477735");
            
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
            
            Diretor roberta = new Diretor("11144477736");


            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Console.WriteLine(Funcionario.TotalDeFuncionarios);


            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            


            Console.WriteLine($"Bonificação de uma referência de Diretor: {roberta.GetBonificacao()}");

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
