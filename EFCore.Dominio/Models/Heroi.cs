using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EFCore.Dominio.Models
{
    public class Heroi
    {

        public int Id { get; set; }
        public string Nome { get; set; }
     
        [JsonIgnore]
        public IdentidadeSecreta Identidade { get; set; } // Elemento/objeto de navegação

        //Um Heroi pode ter várias armas, ou seja, eu crio uma lista de armas.   
        [JsonIgnore]  //[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]       
        public List<Arma> Armas { get; set; }

        [JsonIgnore]
        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}
