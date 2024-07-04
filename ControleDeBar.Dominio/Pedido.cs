using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeBar.Dominio
{
    public class Pedido
    {

        public decimal Valor { get; set; }

        public Garcom Garcom { get; set; }

        public Produto Produto { get; set; }

        public int Quantidade
        {
            get => default;
            set
            {
            }
        }
    }
}