namespace EFCore.Dominio.Models
{
    public class HeroiBatalha
    {
        public Guid HeroiId { get; set; }
        public Heroi Heroi { get; set; }
        public Guid BatalhaId { get; set; }
        public Batalha Batalha { get; set; }
    }
}
