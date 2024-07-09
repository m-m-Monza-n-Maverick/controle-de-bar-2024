using ControleDeBar.Dominio.Compartilhado;
using ControleDeBar.Dominio.ModuloGarcom;
using ControleDeBar.Dominio.ModuloMesa;
using ControleDeBar.Dominio.ModuloPedido;
namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta() : EntidadeBase
    {
        public Mesa Mesa { get; set; }
        public Garcom Garcom { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public decimal ValorTotal { get; set; }
        public bool EmAberto { get; set; }
        public DateTime Data { get; set; }

        public Conta(Mesa mesa, Garcom garcom, List<Pedido> pedidos, decimal valorTotal, bool emAberto, DateTime data) : this()
        {
            Mesa = mesa;
            Garcom = garcom;
            Pedidos = pedidos;
            ValorTotal = valorTotal;
            EmAberto = emAberto;
            Data = data;
        }
        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Conta atualizada = (Conta)novoRegistro;
            Pedidos = atualizada.Pedidos;
        }
        public override List<string> Validar()
        {
            List<string> erros = [];

            VerificaNulo(ref erros, Mesa, "Mesa");
            VerificaNulo(ref erros, Garcom, "Garçom");
            VerificaNulo(ref erros, Pedidos);

            return erros;
        }
        public override string ToString()
        {
            if (EmAberto) return $"Valor: {ValorTotal}, em aberto";
            return $"Valor: {ValorTotal}, pago";
        }
        protected void VerificaNulo(ref List<string> erros, List<Pedido> listaEntidades)
        {
            if (listaEntidades.Count == 0)
                erros.Add($"\nInsira um \"Pedido\"");
        }
    }
}