using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaDeEducacion.Interfaces.Repository;
using System.Threading.Tasks;

namespace SistemaDeEducacion.Controllers
{
    public class ProfesoresController : Controller
    {
        private readonly ILogger<ProfesoresController> _logger;
        private readonly IProfesorRepository _profesorRepository;

        public ProfesoresController(ILogger<ProfesoresController> logger, IProfesorRepository profesorRepository)
        {
            _logger = logger;
            _profesorRepository = profesorRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _profesorRepository.GetProfesores();
            return View(result);
        }

        //ej: https://localhost:44395/Profesores/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var result = await _profesorRepository.GetProfesorById(id);
            return View(result);
            //return Ok(result);
        }
    }
}
