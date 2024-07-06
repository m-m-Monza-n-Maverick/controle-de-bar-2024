using ControleDeBar.Dominio.Compartilhado;
namespace ControleDeBar.Dominio.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string Nome { get; set; }
        public int Id { get; set; }

        public Garcom()
        {
            
        }
        public Garcom(string nome, int id)
        {
            Nome = nome;
            Id = id;
            
        }

        public override List<string> Validar()
        {
            throw new NotImplementedException();
        }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            throw new NotImplementedException();
        }
    }
}