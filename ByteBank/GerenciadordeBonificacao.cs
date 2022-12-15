using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    internal class GerenciadordeBonificacao
    {
        private double _totalBonificacao;
        public void Registrar(Funcionario funcionario) 
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificação()
        {
            return _totalBonificacao;
        }

    }
}
