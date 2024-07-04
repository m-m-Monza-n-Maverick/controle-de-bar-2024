using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ControleDeBar.Dominio.ModuloPedido;

namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Pedido Pedido { get; set; }
        public decimal ValorTotal { get; set; }
        public bool EmAberto { get; set; }
        public DateTime Data { get; set; }

        public Conta()
        {
            
        }

        public Conta(Pedido pedido, decimal valorTotal, bool emAberto, DateTime data)
        {
            Pedido = pedido;
            ValorTotal = valorTotal;
            EmAberto = emAberto;
            Data = data;
        }
    }
}