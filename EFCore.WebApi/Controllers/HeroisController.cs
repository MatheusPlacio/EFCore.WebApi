using EFCore.Dominio.Models;
using EFCore.Dominio.ViewModels.Heroi;
using EFCore.Repo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        [HttpPost]
        public ActionResult Post(RegisterHeroiViewModel novoHeroi, int id)
        {
            var h = new Heroi
            {
                Nome = novoHeroi.Nome,
                Id = id 
            };
            _context.Herois.Add(h);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Heroi heroi)
        {
            _context.Herois.Update(heroi);
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
