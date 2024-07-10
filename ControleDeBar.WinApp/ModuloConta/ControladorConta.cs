using ControladeDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloConta;
using ControleDeBar.Dominio.ModuloPedido;
using ControleDeBar.WinApp.Compartilhado;

namespace ControleDeBar.WinApp.ModuloConta
{
    public class ControladorConta(IRepositorioConta repositorioConta, IRepositorioPedido repositorioPedido, ControleDeBarDbContext dbContext) : ControladorBase
    {
        TabelaContaControl tabelaConta;
        IRepositorioConta RepositorioConta = repositorioConta;

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
            int idSelecionado = tabelaConta.ObterIdSelecionado();

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
            int idSelecionado = tabelaConta.ObterIdSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;

            RealizarAcao(
                () => repositorioConta.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion
        public void ExibirFaturamento() 
        {
            TelaFaturamentoForm telaFaturamento = new(repositorioConta);
            DialogResult resultado = telaFaturamento.ShowDialog();

            /*decimal faturamento = 0;
            TipoFiltroFaturamentoEnum filtroSelecionado 
                = telaFaturamento.FiltroSelecionado;
            
            List<Conta> contas = RepositorioConta.SelecionarTodos();
            DateTime startDate, endDate;
            
            if (filtroSelecionado == TipoFiltroFaturamentoEnum.Sempre)
            {
                foreach (Conta c in contas)
                    faturamento =+ c.ValorTotal;
            }
            else if (filtroSelecionado == TipoFiltroFaturamentoEnum.Dia) 
            {
                foreach (Conta c in contas)
                {
                    if (c.Data == DateTime.Today)
                        faturamento =+ c.ValorTotal;
                }
            }
            else if (filtroSelecionado == TipoFiltroFaturamentoEnum.Semana) 
            {
                startDate = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                endDate = startDate.AddDays(6);
                faturamento = contas.Where(c => c.Data.Date >= startDate && c.Data.Date <= endDate).Sum(c => c.ValorTotal);
            }
            else if (filtroSelecionado == TipoFiltroFaturamentoEnum.Mes) 
            {
                startDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                endDate = startDate.AddMonths(1).AddDays(-1);
                faturamento = contas.Where(c => c.Data.Date >= startDate && c.Data.Date <= endDate).Sum(c => c.ValorTotal);
            }
            else if (filtroSelecionado == TipoFiltroFaturamentoEnum.Periodo) 
            {
                startDate = telaFaturamento.DiaInicio();
                endDate = telaFaturamento.DiaFim();
                faturamento = contas.Where(c => c.Data.Date >= startDate && c.Data.Date <= endDate).Sum(c => c.ValorTotal);
            }
                return faturamento;*/
        }

        public void FecharConta()
        {
            int idSelecionado = tabelaConta.ObterIdSelecionado();

            Conta registroSelecionado = repositorioConta.SelecionarPorId(idSelecionado);

            if (registroSelecionado.EmAberto == false)
            {
                MessageBox.Show(
                $"Esta conta já foi fechada",
                $"Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                return;
            }

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
        
        public override void CarregarRegistros()
            => tabelaConta.AtualizarRegistros(repositorioConta.SelecionarTodos());
        public void CarregarContasEmAberto()
            => tabelaConta.AtualizarRegistros(repositorioConta.SelecionarTodos());
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
