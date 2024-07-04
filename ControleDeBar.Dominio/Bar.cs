using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeBar.Dominio
{
    public class Bar
    {
        public string Nome { get; set; }

        public decimal Faturamento
        {
            get => default;
            set
            {
            }
        }

        public Mesa Mesa
        {
            get => default;
            set
            {
            }
        }

        public Garcom Garcom
        {
            get => default;
            set
            {
            }
        }

        public Produto Produto
        {
            get => default;
            set
            {
            }
        }
    }
}