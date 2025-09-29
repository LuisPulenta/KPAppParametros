using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Web.Data;
using System.Linq;
using Web.Data.Entities;

namespace Àpi.Controllers.Àpi
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly DataContext _dataContext;

        public EmpresaController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //--
        //-----------------------------------------------------------------------------------

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dataContext.Empresas
                .OrderBy(x => x.NombreEmpresa).ToListAsync());
        }

        //-----------------------------------------------------------------------------------
        [HttpGet("{nombre}")]
        [Route("GetEmpresa/{nombre}")]
        public async Task<ActionResult<Empresa>> GetEmpresa(string nombre)
        {
            Empresa empresa = await _dataContext.Empresas
                .FirstOrDefaultAsync(x => x.NombreEmpresa.ToLower() == nombre.ToLower());
            if (empresa == null)
            {
                return NotFound();
            }
            return empresa;
        }
    }
}