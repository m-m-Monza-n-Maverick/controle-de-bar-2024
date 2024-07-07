using ControleDeBar.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ControleDeBar.Dominio.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Id { get; set; }

        public Produto()
        {
            
        }

        public Produto(string nome, decimal preco, int id)
        {
            Nome = nome;
            Preco = preco;
            Id = id;
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