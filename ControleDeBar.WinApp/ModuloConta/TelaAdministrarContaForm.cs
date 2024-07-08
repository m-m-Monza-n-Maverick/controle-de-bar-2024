using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloPedido;
namespace ControleDeBar.WinApp.ModuloConta
{
    public partial class TelaAdministrarContaForm : Form
    {
        public Conta Conta
        {
            get => conta;
            set
            {
                txtNumeroMesa.Text = numeroMesa.ToString();

                foreach (Pedido p in value.Pedidos)
                    listPedidos.Items.Add(p);
            }
        }
        private Conta conta;
        readonly int numeroMesa;

        public TelaAdministrarContaForm(int numeroMesa)
        {
            InitializeComponent();

            this.numeroMesa = numeroMesa;
        }

        private void btnRemoverlist_Click(object sender, EventArgs e)
        {
            Pedido pedidoSelecionado = (Pedido)listPedidos.SelectedItem;

            if (pedidoSelecionado == null) return;

            Conta.Pedidos.Remove(pedidoSelecionado);
            listPedidos.Items.Remove(pedidoSelecionado);
        }
    }
}
