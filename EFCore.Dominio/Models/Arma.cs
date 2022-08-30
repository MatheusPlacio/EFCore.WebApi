namespace EFCore.Dominio.Models
{
    public class Arma
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Heroi Heroi { get; set; }
        public Guid HeroiId { get; set; }
    }
}
