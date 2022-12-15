using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {

        public string Senha { get; set; }

        // a construtor herda argumentos da classe base, recebe a string cpf e passa para a classe base
        public Diretor(string cpf) : base(cpf, 10000)
        {

        }

        public bool Autenticar(string senha)
        {

            return Senha == senha;

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario + 0.5;
        }

    }
}
