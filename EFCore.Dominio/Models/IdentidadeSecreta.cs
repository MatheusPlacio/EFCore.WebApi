namespace EFCore.Dominio.Models
{
    public class IdentidadeSecreta
    {
        public Guid Id { get; set; }
        public string NomeReal { get; set; }
        public Guid HeroiId { get; set; }
        public Heroi Heroi { get; set; }
    }
}
