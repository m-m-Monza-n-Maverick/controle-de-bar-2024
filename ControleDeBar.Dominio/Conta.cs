using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeBar.Dominio
{
    public class Conta
    {

        public Pedido Pedido { get; set; }
        public decimal ValorTotal { get; set; }
        public bool EmAberto { get; set; }
        public DateTime Data { get; set; }
    }
}