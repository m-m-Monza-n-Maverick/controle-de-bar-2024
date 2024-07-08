using System;
using System.Collections.Generic;
using System.Linq;
using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloPedido;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta() : EntidadeBase
    {
        public Pedido Pedido { get; set; }
        public decimal ValorTotal { get; set; }
        public bool EmAberto { get; set; }
        public DateTime Data { get; set; }

        public Conta(Pedido pedido, decimal valorTotal, bool emAberto, DateTime data) : this()
        {
            Pedido = pedido;
            ValorTotal = valorTotal;
            EmAberto = emAberto;
            Data = data;
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