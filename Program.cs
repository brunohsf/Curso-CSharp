using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();

            Console.ReadKey();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor(5000, "157.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta(4000, "326.985.628-89");
            camila.Nome = "Camila";
            camila.Salario = "abc";


            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");

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

            Desenvolvedor guilherme = new Desenvolvedor(3000, "456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine($"Total de Bonificações do Mês: {gerenciadorBonificacao.GetTotalBonificacao()}");


        }
    }
}
