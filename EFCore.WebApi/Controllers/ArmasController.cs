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
        public ArmasController(HeroiContext contexto)
        {
            _context = contexto;
        }

        [HttpGet]
        public async Task<ActionResult<List<Arma>>> Get()
        {
            return await _context.Armas.AsNoTracking().ToListAsync();
        }

        [HttpPost("Armas")]
        public ActionResult PostArmas(Arma armaId)
        {
            var ar = new Arma
            {
                Nome = "Mente",
                Heroi = new Heroi
                {
                   Id = armaId.Id              
                }
            };
       
            _context.Armas.Add(ar);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var exluir = _context.Armas.FirstOrDefault(a => a.Id == id);
            _context.Armas.Remove(exluir);
            _context.SaveChanges();
            return Ok();
        }


    }
}
