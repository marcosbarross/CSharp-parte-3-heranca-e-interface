using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
       static void Main(string[] args)
        {

            //CalcularBonificacao(); //todos o métodos chamados dentro da classe main precisam ser estáticos
            UsarSistema();

        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "ab");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
            
        }

        public static void CalcularBonificacao()
        {

            GerenciadordeBonificacao gerenciadordeBonificacao = new GerenciadordeBonificacao();

            Designer pedro = new Designer("833.222.048-39")
            {
                Nome = "Pedro"
            };

            Diretor roberta = new Diretor("159.753.398-04")
            {
                Nome = "Roberta"
               
            };

            Auxiliar igor = new Auxiliar("981.198.778-53")
            {
                Nome = "Igor"
            };

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89")
            {
                Nome = "Camila"
            };

            gerenciadordeBonificacao.Registrar(pedro);
            gerenciadordeBonificacao.Registrar(roberta);
            gerenciadordeBonificacao.Registrar(igor);
            gerenciadordeBonificacao.Registrar(camila);

            Console.WriteLine($"Total de bonificações do mês {gerenciadordeBonificacao.GetTotalBonificação()}");

        }

    }
}
