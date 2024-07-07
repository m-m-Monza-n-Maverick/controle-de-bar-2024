using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloProduto;

namespace ControleDeBar.Dominio.ModuloPedido
{
    public class Pedido : EntidadeBase
    {
        public decimal Valor { get; set; }
        public Garcom Garcom { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public Pedido()
        {
            
        }

        public Pedido(decimal valor, Garcom garcom, Produto produto, int quantidade)
        {
            Valor = valor;
            Garcom = garcom;
            Produto = produto;
            Quantidade = quantidade;
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