using EFCore.Dominio.Models;
using EFCore.Repo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArmasController : ControllerBase
    {
        private readonly HeroiContext _context;
        public ArmasController(HeroiContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Arma>>> Get()
        {
            return await _context.Armas.AsNoTracking().ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Arma>> GetId(int id)
        {
            return await _context.Armas.FirstOrDefaultAsync(a => a.Id == id);
        }

        [HttpPost]
        public ActionResult Post(Arma arma)
        {
            _context.Armas.Add(arma);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Arma arma)
        {
            _context.Armas.Update(arma);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var exluir = _context.Armas.FirstOrDefault(a => a.Id == id);
            _context.Armas.Remove(exluir);
            _context.SaveChanges();
            return Ok(exluir);
        }
    }
}
