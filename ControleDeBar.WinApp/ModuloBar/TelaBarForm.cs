using ControleDeBar.Dominio.ModuloBar;

namespace ControleDeBar.WinApp.ModuloBar
{
    public partial class TelaBarForm : Form
    {
        public Bar Bar
        {
            get => bar;
            set
            {
                txtId.Text = value.Id.ToString();
                txtNome.Text = value.Nome;
            }
        }
        private Bar bar;

        private List<Bar> baresCadastrados;

        public TelaBarForm(List<Bar> baresCadastrados)
        {
            InitializeComponent();

            if (baresCadastrados.Count > 0)
                txtId.Text = (baresCadastrados.Last().Id + 1).ToString();
            else txtId.Text = "1";

            this.baresCadastrados = baresCadastrados;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            bar = new Bar();

            List<string> erros = bar.Validar();

            if (erros.Count > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
