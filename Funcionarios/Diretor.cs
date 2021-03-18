using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor
    {
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Diretor(int tipo)
        {
            this._tipo = tipo;
        }

        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
