using ControladeDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedido;
using ControleDeBar.Dominio.ModuloProduto;
namespace ControleDeBar.WinApp.ModuloMesa
{
    public partial class TelaMesaForm : Form
    {
        public Mesa Mesa
        {
            get => mesa;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNumero.Value = Convert.ToDecimal(value.Numero);
                cmbConta.SelectedItem = value.Conta;
            }
        }
        private Mesa mesa;

        ControleDeBarDbContext dbContext;

        public TelaMesaForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;

            MostrarId([.. dbContext.Mesas]);
            CarregarContas();
        }

        private void CarregarContas()
        {
            List<Conta> contasCadastradas = [.. dbContext.Contas];

            foreach (Conta c in contasCadastradas)
                cmbConta.Items.Add(c);
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            mesa = new(txtNumero.Value, (Conta)cmbConta.SelectedItem);

            Validar();
        }

        #region Auxiliares
        private void MostrarId(List<Mesa> mesasCadastradas)
        {
            if (txtId.Text == "0")
            {
                if (mesasCadastradas.Count > 0)
                    txtId.Text = (mesasCadastradas.Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        private void Validar()
        {
            List<string> erros = mesa.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        #endregion
    }
}
