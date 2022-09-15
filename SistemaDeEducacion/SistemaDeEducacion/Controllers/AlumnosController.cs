using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SistemaDeEducacion.Interfaces.Busines;
using SistemaDeEducacion.Interfaces.Repository;
using SistemaDeEducacion.Models;
using System.Threading.Tasks;

namespace SistemaDeEducacion.Controllers
{
    public class AlumnosController : Controller
    {

        private readonly ILogger<AlumnosController> _logger;
        private readonly IAlumnosRepository _alumnosRepository;
        private readonly IAltaAlumno _altaAlumno;

        public AlumnosController(ILogger<AlumnosController> logger, IAlumnosRepository alumnosRepository, IAltaAlumno altaAlumno)
        {
            _logger = logger;
            _alumnosRepository = alumnosRepository;
            _altaAlumno = altaAlumno;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _alumnosRepository.GetAlumnos();
            return View(result);
        }

        //ej: https://localhost:44395/Alumnos/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var result = await _alumnosRepository.GetAlumnoById(id);
            return View(result);
            //return Ok(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        //post alumnos
        [HttpPost]
        public async Task<IActionResult> Create(AlumnosViewModel model)
        {
            _altaAlumno.AltaAlumno(model);
            return RedirectToAction("Index");
        }
    }
}
