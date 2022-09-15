using SistemaDeEducacion.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaDeEducacion.Interfaces.Repository
{
    public interface IProfesorRepository
    {
        Task<List<ProfesorViewModel>> GetProfesores();
        Task<List<ProfesorViewModel>> GetProfesorById(int id);
    }
}
