using EFCore.Dominio.Models;
using EFCore.Dominio.ViewModels.Heroi;
using EFCore.Repo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroisController : ControllerBase
    {

        private readonly HeroiContext _context;
        public HeroisController(HeroiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Heroi>>> Get()
        {
            return await _context.Herois.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Heroi>> GetId(int id)
        {
            return await _context.Herois.FirstOrDefaultAsync(a => a.Id == id);
        }

        //var HeroiNome = _context.IdentidadesSecretas
        //    .Include(h => h.HeroiId)
        //    .Where(h => h.HeroiId == id)
        //    .Include(x => x.Heroi)
        //    .Where(x => x.Heroi.Nome == nomeReal)
        //    .FirstOrDefault();

        [HttpPost]
        public ActionResult Post(RegisterHeroiViewModel novoHeroi, int id, string nomeReal)
        {
            var h = new Heroi
            {   
                Nome = "Magneto",
                Identidade = new IdentidadeSecreta
                {
                    HeroiId = id,
                    NomeReal = nomeReal,
                }
            };

            _context.Herois.Add(h);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost("Armas")]
        public ActionResult PostArmas(RegisterHeroiViewModel hero, int id)
        {
            var heroi = new Heroi
            {
                Nome = "Magneto",
                Armas = new List<Arma>
                {
                    new Arma { Nome = "Mente"}                             
                }
            };
            _context.Herois.Add(heroi);
            _context.SaveChanges();
            return Ok();
        }



        [HttpPut]
        public ActionResult Put(int id, string nome)
        {
            var heroi = _context.Herois
                 .Where(h => h.Id == id)
                 .FirstOrDefault();
            heroi.Nome = nome;

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var exluir = _context.Herois.FirstOrDefault(a => a.Id == id);
            _context.Herois.Remove(exluir);
            _context.SaveChanges();
            return Ok();
        }
    }

}
