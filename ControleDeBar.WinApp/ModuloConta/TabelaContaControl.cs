using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.WinApp.Compartilhado.Extensions;
namespace ControleDeBar.WinApp.ModuloConta
{
    public partial class TabelaContaControl : UserControl
    {
        public TabelaContaControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Conta> contas)
        {
            string emAberto = "Em aberto";
            grid.Rows.Clear();

            foreach (Conta c in contas)
            {
                if (!c.EmAberto) emAberto = "Fechada";
                grid.Rows.Add(c.Id, c.Mesa, c.Garcom, c.ValorTotal, c.Data.ToShortDateString(), emAberto);
            }
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Mesa", HeaderText = "Mesa" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Garcom", HeaderText = "Garçom" },
            new DataGridViewTextBoxColumn { DataPropertyName = "ValorTotal", HeaderText = "Valor total" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Data", HeaderText = "Data" },
            new DataGridViewTextBoxColumn { DataPropertyName = "EmAberto", HeaderText = "Situação" },
        ];
    }
}
