using SistemaDeEducacion.Interfaces.Busines;
using SistemaDeEducacion.Interfaces.Repository;
using SistemaDeEducacion.Models;

namespace SistemaDeEducacion.Busines
{
    public class AltaAlumnoService : IAltaAlumno
    {
        public readonly IAlumnosRepository _alumnosRepository;

        public AltaAlumnoService(IAlumnosRepository alumnosRepository)
        {
            _alumnosRepository = alumnosRepository;
        }

        //alta alumno
        //TODO: agregar turno, periodo, carrera, materia.
        public void AltaAlumno(AlumnosViewModel model)
        {
            _alumnosRepository.InsertAlumno(model);
        }
    }
}
