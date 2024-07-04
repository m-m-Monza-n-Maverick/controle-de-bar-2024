using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.Dominio.Estabelecimento
{
    public class Bar : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal Faturamento { get; set; }
        public Mesa Mesa { get; set; }
        public Garcom Garcom { get; set; }
        public Produto Produto { get; set; }

        public Bar()
        {
            
        }

        public Bar(string nome, decimal faturamento, Mesa mesa, Garcom garcom, Produto produto)
        {
            Nome = nome;
            Faturamento = faturamento;
            Mesa = mesa;
            Garcom = garcom;
            Produto = produto;
        }
    }
}