using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {

        public bool Logar(Autenticavel diretor, string senha)
        {
            bool usuarioAutenticado = diretor.Autenticar(senha);

            if (!diretor.Autenticar(senha))
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
            Console.WriteLine($"Bem vindo ao sistema, {diretor.Nome}!");
            return true;
        }

    }
}
