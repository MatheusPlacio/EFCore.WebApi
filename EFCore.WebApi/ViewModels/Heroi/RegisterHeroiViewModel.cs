using EFCore.Dominio.Models;
using System.Text.Json.Serialization;

namespace EFCore.WebApi.ViewModels.Heroi
{
    
    public class RegisterHeroiViewModel
    {
        
        public string? Nome { get; set; }
        // public IdentidadeSecreta Identidade { get; set; } // Elemento/objeto de navegação    
        // public List<Arma> Armas { get; set; }      
        // public List<HeroiBatalha> HeroisBatalhas { get; set; }
    }
}
