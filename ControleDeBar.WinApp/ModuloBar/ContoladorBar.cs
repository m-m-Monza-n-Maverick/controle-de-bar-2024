using ControladeDeBar.Infra.Orm.Compartilhado;
using ControleDeBar.Dominio.ModuloBar;
using ControleDeBar.WinApp.Compartilhado;
using ControleDeBar.WinApp.ModuloBar;

namespace ControleDeBar.WinApp.ModuloGarcom
{
    public class ControladorBar(IRepositorioBar repositorioBar, ControleDeBarDbContext dbContext) : ControladorBase
    {
        TabelaBarControl tabelaBar;

        #region ToolTips
        public override string TipoCadastro { get => "Bar"; }
        public override string ToolTipAdicionar { get => "Cadastrar um novo Bar"; }
        public override string ToolTipEditar { get => "Editar um Bar existente"; }
        public override string ToolTipExcluir { get => "Excluir um Bar existente"; }
        #endregion

        #region CRUD
        public override void Adicionar()
        {
            TelaBarForm telaBar = new([.. dbContext.Bares]);
            DialogResult resultado = telaBar.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Bar novoRegistro = telaBar.Bar;

            RealizarAcao(
                () => repositorioBar.Cadastrar(novoRegistro),
                novoRegistro, "cadastrado");
        }
        public override void Editar()
        {
            int idSelecionado = tabelaBar.ObterRegistroSelecionado();

            Bar registroSelecionado = repositorioBar.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado)) return;

            List<Bar> BaresCadastrados = repositorioBar.SelecionarTodos();

            TelaBarForm telaBar = new([.. dbContext.Bares])
            {
                Bar = registroSelecionado
            };

            DialogResult resultado = telaBar.ShowDialog();

            if (resultado != DialogResult.OK) return;

            Bar registroEditado = telaBar.Bar;

            RealizarAcao(
                () => repositorioBar.Editar(registroSelecionado.Id, registroEditado),
                registroEditado, "editado");
        }
        public override void Excluir()
        {
            int idSelecionado = tabelaBar.ObterRegistroSelecionado();

            Bar registroSelecionado = repositorioBar.SelecionarPorId(idSelecionado);

            if (SemSeleção(registroSelecionado) || !DesejaRealmenteExcluir(registroSelecionado)) return;
            RealizarAcao(
                () => repositorioBar.Excluir(registroSelecionado.Id),
                registroSelecionado, "excluído");
        }
        #endregion

        public override UserControl ObterListagem()
        {
            tabelaBar ??= new TabelaBarControl();

            CarregarRegistros();

            return tabelaBar;
        }
        public override void CarregarRegistros()
            => tabelaBar.AtualizarRegistros(repositorioBar.SelecionarTodos());
    }   
}

