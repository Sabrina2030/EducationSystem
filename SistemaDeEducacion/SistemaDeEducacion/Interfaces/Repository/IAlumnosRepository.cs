using SistemaDeEducacion.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaDeEducacion.Interfaces.Repository
{
    public interface IAlumnosRepository
    {
        Task<List<AlumnosViewModel>> GetAlumnos();
        Task<List<AlumnosViewModel>> GetAlumnoById(int id);
        Task<AlumnosViewModel> InsertAlumno(AlumnosViewModel alumno);
    }
}
