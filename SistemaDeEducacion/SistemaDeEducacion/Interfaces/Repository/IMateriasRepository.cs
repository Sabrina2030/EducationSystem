using SistemaDeEducacion.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaDeEducacion.Interfaces.Repository
{
    public interface IMateriasRepository
    {
        Task<List<MateriaViewModel>> GetMaterias();

        Task<List<MateriaViewModel>> GetByNameMateriaAlumno(int Id);
        Task<List<MateriaViewModel>> GetByNameMateriaProfesor(int Id);
    }
}
