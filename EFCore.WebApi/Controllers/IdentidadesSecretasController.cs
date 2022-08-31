using EFCore.Dominio.Models;
using EFCore.Repo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentidadesSecretasController : ControllerBase
    {
        private readonly HeroiContext _context;
        public IdentidadesSecretasController(HeroiContext contexto)
        {
            _context = contexto;
        }
        [HttpGet]
        public async Task<ActionResult<List<IdentidadeSecreta>>> Get()
        {
            return await _context.IdentidadesSecretas.AsNoTracking().ToListAsync();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var exluir = _context.IdentidadesSecretas.FirstOrDefault(a => a.Id == id);
            _context.IdentidadesSecretas.Remove(exluir);
            _context.SaveChanges();
            return Ok();
        }
    }
}
