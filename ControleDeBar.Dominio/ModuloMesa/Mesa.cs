using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeBar.Dominio.Compartilhado;
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

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }
    }
}

