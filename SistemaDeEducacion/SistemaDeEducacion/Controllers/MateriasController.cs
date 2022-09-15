using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaDeEducacion.Interfaces.Repository;
using System.Threading.Tasks;

namespace SistemaDeEducacion.Controllers
{
    public class MateriasController : Controller
    {
        private readonly ILogger<MateriasController> _logger;
        private readonly IMateriasRepository _materiasRepository;

        public MateriasController(ILogger<MateriasController> logger, IMateriasRepository materiasRepository)
        {
            _logger = logger;
            _materiasRepository = materiasRepository;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _materiasRepository.GetMaterias();
            return View(result);
        }

        public async Task<IActionResult> DetailsMateriasAlumnos(int id)
        {
            var result = await _materiasRepository.GetByNameMateriaAlumno(id);
            return View(result);
            //return Ok(result);
        }

        public async Task<IActionResult> DetailsMateriasProfesores(int id)
        {
            var result = await _materiasRepository.GetByNameMateriaProfesor(id);
            return View(result);
            //return Ok(result);
        }
    }
}
