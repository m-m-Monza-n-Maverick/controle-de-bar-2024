using ControleDeBar.Dominio.ModuloBar;
using ControleDeBar.WinApp.Compartilhado.Extensions;
namespace ControleDeBar.WinApp.ModuloBar
{
    public partial class TabelaBarControl : UserControl
    {
        public TabelaBarControl()
        {
            InitializeComponent();
            
            grid.Columns.AddRange(ObterColunas());
            
            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Bar> bares)
        {
            grid.Rows.Clear();

            foreach (Bar b in bares)
                grid.Rows.Add(b.Id, b);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" }
        ];
    }
}
