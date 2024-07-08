using ControleDeBar.Dominio.ModuloPedido;
namespace ControleDeBar.Dominio.ModuloConta
{
    public class Conta()
    {
        public int Id { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public decimal ValorTotal { get; set; }
        public bool EmAberto { get; set; }
        public DateTime Data { get; set; }

        public Conta(List<Pedido> pedidos, decimal valorTotal, bool emAberto, DateTime data) : this()
        {
            Pedidos = pedidos;
            ValorTotal = valorTotal;
            EmAberto = emAberto;
            Data = data;
        }

        public void AtualizarRegistro(Conta contaAtualizada)
        {
            Pedidos = contaAtualizada.Pedidos;
        }
    }
}