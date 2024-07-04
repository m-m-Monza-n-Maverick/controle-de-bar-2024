using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeBar.Dominio.ModuloConta;

namespace ControleDeBar.Dominio.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public int Numero { get; set; }
        public Conta Conta { get; set; }

        public Mesa()
        {
            
        }

        public Mesa(int numero, Conta conta)
        {
            Numero = numero;
            Conta = conta;
        }
    }
}

