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

            CalcularBonificacao();


            Console.ReadKey();
        }

        public static void CalcularBonificacao()
        {

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer(3000, "833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor(5000, "157.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar(2000, "981.198.778.53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta(4000, "326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine($"Total de Bonificações do Mês: {gerenciadorBonificacao.GetTotalBonificacao()}");


        }
    }
}
