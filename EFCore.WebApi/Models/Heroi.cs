namespace EFCore.WebApi.Models
{
    public class Heroi
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Batalha Batalha { get; set; }
        public Guid BatalhaId { get; set; }

    }
}
