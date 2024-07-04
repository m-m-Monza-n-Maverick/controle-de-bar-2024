using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleDeBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Nome { get; set; }
        public int Id { get; set; }

        public Garcom()
        {
            
        }
        public Garcom(string nome, int id)
        {
            Nome = nome;
            Id = id;
            
        }
    }
}