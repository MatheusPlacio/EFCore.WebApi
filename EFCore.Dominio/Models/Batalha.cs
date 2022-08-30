namespace EFCore.Dominio.Models
{
    public class Batalha
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        
        //Um heroi já participou de várias batalhas, e uma batalha pode ter vários herois, então N p/ N.
        public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
