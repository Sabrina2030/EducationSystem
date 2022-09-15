using Microsoft.Extensions.Configuration;
using SistemaDeEducacion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using SistemaDeEducacion.Interfaces.Repository;
using SistemaDeEducacion.Models;

namespace SistemaDeEducacion.Repository
{
    public class ProfesoresRepository :IProfesorRepository
    {
        private readonly string _connectionString;
        public ProfesoresRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<ProfesorViewModel>> GetProfesores()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<ProfesorViewModel>(Profesor.GetAllProfesores);
                return result.ToList();
            }
        }

        public async Task<List<ProfesorViewModel>> GetProfesorById(int id)
        {
            var lookup = new Dictionary<int, ProfesorViewModel>();

            using (var resource = new SqlConnection(_connectionString))
            {
                var listado = await resource.QueryAsync<ProfesorViewModel, Carrera, Materia, ProfesorViewModel>(Profesor.GetProfesorById,
                    (profesor, carrera, materia) =>
                    {
                        ProfesorViewModel profesorEntry;

                        if (!lookup.TryGetValue(profesor.Id, out profesorEntry))
                        {
                            lookup.Add(profesor.Id, profesorEntry = profesor);
                        }

                        if (profesorEntry.College == null)
                            profesorEntry.College = new List<Carrera>();

                        if (profesorEntry.Course == null)
                            profesorEntry.Course = new List<Materia>();

                        profesorEntry.College.Add(carrera);
                        profesorEntry.Course.Add(materia);

                        return profesorEntry;
                    }, new { Id = id },
                    splitOn: "Id");
            }

            var result = lookup.Values.ToList();
            return result;
        }
    }
}
