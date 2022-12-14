using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;


namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GerenciadordeBonificacao gerenciador = new GerenciadordeBonificacao();


            Funcionario marcos = new Funcionario();

            marcos.Nome = "Marcos";
            marcos.CPF = "123.564.254-89";
            marcos.Salario = 5000;
            gerenciador.Registrar(marcos);

            Console.WriteLine(marcos.Nome);
            Console.WriteLine($"A bonificação de {marcos.Nome} será de {marcos.GetBonificacao()}");


            Diretor larissa = new Diretor();
            {


                larissa.Nome = "Larissa";
                larissa.CPF = "454.879.654-58";
                larissa.Salario = 10000;

                gerenciador.Registrar(larissa);

                Console.WriteLine(larissa.Nome);
                Console.WriteLine($"A bonificação de {larissa.Nome} será de {larissa.GetBonificacao()}");

            }

        }
    }
}
