using ControladeDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloPedido;
using ControleDeBar.WinApp.Compartilhado;
namespace ControleDeBar.WinApp.ModuloConta
{
    public class ControladorConta(IRepositorioConta repositorioConta, IRepositorioPedido repositorioPedido, ControleDeBarDbContext dbContext) : ControladorBase, IControladorContasAbertas
    {
        TabelaContaControl tabelaConta;
        TabelaContasAbertasControl tabelaContasAbertas;

        #region ToolTips
        public override string TipoCadastro { get => "Conta"; }
        public override string ToolTipAdicionar { get => "Cadastrar uma nova conta"; }
        public override string ToolTipEditar { get => "Editar uma conta existente"; }
        public override string ToolTipExcluir { get => "Excluir uma conta existente"; }
        public string ToolTipContasAbertas { get => "Visualizar contas abertas"; }
        public string ToolTipFecharConta { get => "Fechar conta"; }
        #endregion

        #region CRUD
        public override void Adicionar()
        {
            TelaContaForm telaProduto = new(dbContext);
            DialogResult resultado = telaProduto.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Conta novoRegistro = telaProduto.Conta;

            foreach (Pedido p in novoRegistro.Pedidos)
                repositorioPedido.Cadastrar(p);

            RealizarAcao(
                () => repositorioConta.Cadastrar(novoRegistro),
                novoRegistro, "cadastrado");
        }
        public override void Editar()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            List<Conta> disciplinasCadastradas = repositorioConta.SelecionarTodos();

            TelaContaForm telaConta = new(dbContext)
            {
                Conta = registroSelecionado
            };

            DialogResult resultado = telaConta.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Conta registroEditado = telaConta.Conta;

            RealizarAcao(
                () => repositorioConta.Editar(registroSelecionado.Id, registroEditado),
                registroEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaConta.ObterRegistroSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;

            RealizarAcao(
                () => repositorioConta.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion

        public void FecharConta()
        {
            int idSelecionado = tabelaContasAbertas.ObterRegistroSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteFecharConta(registroSelecionado)) return;

            registroSelecionado.EmAberto = false;

            RealizarAcao(
                () => repositorioConta.Editar(registroSelecionado.Id, registroSelecionado),
                registroSelecionado);
        }

        public override UserControl ObterListagem()
        {
            tabelaConta ??= new();

            CarregarRegistros();

            return tabelaConta;
        }
        public UserControl ObterListagemContasAbertas()
        {
            tabelaContasAbertas ??= new();

            CarregarContasEmAberto();

            return tabelaContasAbertas;
        }
        public override void CarregarRegistros()
            => tabelaConta.AtualizarRegistros(repositorioConta.SelecionarTodos());
        public void CarregarContasEmAberto()
            => tabelaContasAbertas.AtualizarRegistros(repositorioConta.SelecionarTodos());
        protected bool DesejaRealmenteFecharConta(Conta entidadeSelecionada)
        {
            DialogResult resposta = MessageBox.Show(
                $"Você deseja realmente fechar esta conta \"Valor: {entidadeSelecionada.ValorTotal}\"?",
                $"Confirmar pagamento",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes) return false;
            return true;
        }
        protected void RealizarAcao(Action acao, Conta conta)
        {
            acao();
            CarregarContasEmAberto();

            TelaPrincipalForm
                .Instancia
                .AtualizarRodape($"A conta \"Valor: {conta.ValorTotal}\" foi fechada com sucesso!");
        }
    }
}
