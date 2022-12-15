﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {

        public static int TotalDeFuncionarios { get; private set; }

        // para um atributo ser obrigatório, usamos ela no construtor
        public Funcionario(string cpf, double salario) 
        {
            CPF = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }

        public string Nome { get; set; }
        public string CPF { get; 
           private set; }
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();

    }
}
