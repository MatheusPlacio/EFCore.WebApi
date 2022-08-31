using System.Text.Json.Serialization;

namespace EFCore.Dominio.Models
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [JsonIgnore]
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}
