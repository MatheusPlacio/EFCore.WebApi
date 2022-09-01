using EFCore.Repo;
using EFCore.Repo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BatalhasController : ControllerBase
    {
        private readonly IEFCoreRepository _context;
        public BatalhasController(IEFCoreRepository context)
        {
            _context = context;
        }


    }
}
