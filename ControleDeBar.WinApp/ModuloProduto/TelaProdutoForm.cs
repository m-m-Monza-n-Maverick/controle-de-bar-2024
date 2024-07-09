using ControladeDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.Compartilhado.Extensions;
using ControleDeBar.Dominio.ModuloProduto;
namespace ControleDeBar.WinApp.ModuloProduto
{
    public partial class TelaProdutoForm : Form
    {
        public Produto Produto
        {
            get => produto;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = nomeAtual = value.Nome;
                txtPreco.Value = value.Preco;
            }
        }
        private Produto produto;
        private ControleDeBarDbContext dbContext;
        private string nomeAtual;

        public TelaProdutoForm(ControleDeBarDbContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            MostrarId();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            produto = new Produto(txtNome.Text, txtPreco.Value);

            Validar();
        }

        #region Auxiliares
        private void Validar()
        {
            List<string> erros = produto.Validar();

            if (ProdutoTemNomeDuplicado())
                erros.Add("Já existe um produto com este nome, tente utilizar outro!");

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
        private bool ProdutoTemNomeDuplicado()
        {
            if (nomeAtual == produto.Nome) return false;
            return dbContext.Produtos.ToList().Any(p => p.Nome.Validation() == produto.Nome.Validation());
        }
        private void MostrarId()
        {
            if (txtId.Text == "0")
            {
                if (dbContext.Produtos.ToList().Count > 0)
                    txtId.Text = (dbContext.Produtos.ToList().Last().Id + 1).ToString();
                else txtId.Text = "1";
            }
        }
        #endregion
    }
}
