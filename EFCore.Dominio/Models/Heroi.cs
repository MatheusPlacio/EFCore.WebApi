namespace EFCore.Dominio.Models
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta Identidade { get; set; }

        //Um Heroi pode ter várias armas, ou seja, eu crio uma lista de armas.
        public List<Arma> Armas { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }

    }
}
