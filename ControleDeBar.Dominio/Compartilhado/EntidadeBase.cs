using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.Dominio.Compartilhado
{
    public abstract class EntidadeBase
    {
        public abstract List<string> Validar();

        public abstract void AtualizarRegistro(EntidadeBase novoRegistro);
    }
}
