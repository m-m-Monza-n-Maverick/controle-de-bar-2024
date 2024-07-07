using ControleDeBar.Dominio.ModuloProduto;
using ControleDeBar.WinApp.Compartilhado.Extensions;
namespace ControleDeBar.WinApp.ModuloPedido
{
    public partial class TabelaPedidoControl : UserControl
    {
        public TabelaPedidoControl()
        {
            InitializeComponent();

            grid.Columns.AddRange(ObterColunas());

            grid.ConfigurarGridSomenteLeitura();
            grid.ConfigurarGridZebrado();
        }

        public void AtualizarRegistros(List<Produto> produtos)
        {
            grid.Rows.Clear();

            foreach (Produto p in produtos)
                grid.Rows.Add(p.Id, p, p.Preco);
        }

        public int ObterRegistroSelecionado() => grid.SelecionarId();
        private DataGridViewColumn[] ObterColunas() =>
        [
            new DataGridViewTextBoxColumn { DataPropertyName = "Id", HeaderText = "Id" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome" },
            new DataGridViewTextBoxColumn { DataPropertyName = "Preco", HeaderText = "Preço" }
        ];
    }
}
