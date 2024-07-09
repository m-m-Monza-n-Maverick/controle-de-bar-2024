namespace ControleDeBar.Dominio.Compartilhado
{
    public interface IControladorContasAbertas
    {
        string ToolTipContasAbertas { get; }
        string ToolTipFecharConta { get; }

        void CarregarContasEmAberto();
        void FecharConta();
    }
}
