using ControladeDeBar.Infra.SQL.ModuloGarcom;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.WinApp.Compartilhado;

namespace ControleDeBar.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        public static TelaPrincipalForm Instancia { get; private set; }

        ControladorBase controlador;

        IRepositorioGarcom repositorioGarcom;

        public TelaPrincipalForm()
        {
            InitializeComponent();

            //lblTipoCadastro.Text = string.Empty;
            GeradorTestesDbContext dbContext = new GeradorTestesDbContext(db);

            repositorioGarcom = new RepositorioGarcomEmOrm(dbContext);

            Instancia = this;
        }
        //public void AtualizarRodape(string texto) => statusLabelPrincipal.Text = texto;


        #region Seleção de módulo
/*        private void disciplinasMenuItem_Click(object sender, EventArgs e)
            => SelecionaModulo(ref controlador, () => controlador = new ControladorDisciplina(repositorioDisciplina, contexto),
                contexto.Disciplinas.Count);*/        
        #endregion

        #region Botões
/*        private void btnAdicionar_Click(object sender, EventArgs e)
            => controlador.Adicionar();*/        
        #endregion

        #region Auxiliares
        private void SelecionaModulo(ref ControladorBase controlador, Action controladorSelecionado, int numRegistros)
        {
            controladorSelecionado();
            //lblTipoCadastro.Text = "Cadastro de " + controlador.TipoCadastro;

            ConfigurarToolBox(controlador);
            ConfigurarListagem(controlador);
            AtualizarRodape($"Visualizando {numRegistros} registro(s)...");
        }
        private void ConfigurarToolBox(ControladorBase controladorSelecionado)
        {
/*            btnAdicionar.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
*/
            ConfigurarToolTips(controladorSelecionado);
        }
        private void ConfigurarToolTips(ControladorBase controladorSelecionado)
        {
/*            btnAdicionar.ToolTipText = controladorSelecionado.ToolTipAdicionar;
            btnEditar.ToolTipText = controladorSelecionado.ToolTipEditar;
            btnExcluir.ToolTipText = controladorSelecionado.ToolTipExcluir;
*/        }
        private void ConfigurarListagem(ControladorBase controladorSelecionado)
        {
/*            UserControl listagemContato = controladorSelecionado.ObterListagem();

            listagemContato.Dock = DockStyle.Fill;
            pnlRegistros.Controls.Clear();
            pnlRegistros.Controls.Add(listagemContato);
*/        }
        #endregion
    }
}
