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
                txtNumero.Value = numeroAtual = Convert.ToDecimal(value.Numero);
            }
        }
        private Mesa mesa;
        private ControleDeBarDbContext dbContext;
        private decimal numeroAtual;

        public TelaMesaForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            MostrarId();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            mesa = new(txtNumero.Value);

            Validar();
        }

        #region Auxiliares
        private void MostrarId()
        {
            if (txtId.Text == "0")
            {
                if (dbContext.Mesas.ToList().Count > 0)
                    txtId.Text = (dbContext.Mesas.ToList().Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        private void Validar()
        {
            List<string> erros = mesa.Validar();

            if (MesaTemNumeroDuplicado())
                erros.Add("Já existe uma mesa com este número, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);
                DialogResult = DialogResult.None;
            }
        }
        private bool MesaTemNumeroDuplicado()
        {
            if (numeroAtual == mesa.Numero) return false;
            return dbContext.Mesas.ToList().Any(m => m.Numero == mesa.Numero);
        }
        #endregion
    }
}
