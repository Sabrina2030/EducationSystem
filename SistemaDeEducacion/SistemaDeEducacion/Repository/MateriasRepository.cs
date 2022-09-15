using Microsoft.Extensions.Configuration;
using SistemaDeEducacion.Interfaces.Repository;
using SistemaDeEducacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using SistemaDeEducacion.Entities;

namespace SistemaDeEducacion.Repository
{
    public class MateriasRepository : IMateriasRepository
    {
        private readonly string _connectionString;
        public MateriasRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<MateriaViewModel>> GetMaterias()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<MateriaViewModel>(Materia.GetMaterias);
                return result.Select(x => new MateriaViewModel
                {
                    Id = x.Id,
                    Name = x.Name

                }).ToList();
            }
        }

        public async Task<List<MateriaViewModel>> GetByNameMateriaAlumno(int Id)
        {
            var lookup = new Dictionary<int, MateriaViewModel>();

            using (var resource = new SqlConnection(_connectionString))
            {
                var listado = await resource.QueryAsync<MateriaViewModel, Alumnos, MateriaViewModel>(Materia.GetMateriaByIdAndAlumnos,
                    (materia, alumnos) =>
                    {
                        MateriaViewModel materiaEntry;

                        if (!lookup.TryGetValue(materia.Id, out materiaEntry))
                        {
                            lookup.Add(materia.Id, materiaEntry = materia);
                        }

                        if (materiaEntry.Students == null)
                            materiaEntry.Students = new List<Alumnos>();

                        materiaEntry.Students.Add(alumnos);

                        return materiaEntry;
                    }, new { Id = Id },
                    splitOn: "Id");
            }

            var result = lookup.Values.ToList();
            return result;
        }

        public async Task<List<MateriaViewModel>> GetByNameMateriaProfesor(int Id)
        {
            var lookup = new Dictionary<int, MateriaViewModel>();

            using (var resource = new SqlConnection(_connectionString))
            {
                var listado = await resource.QueryAsync<MateriaViewModel, Profesor, MateriaViewModel>(Materia.GetMateriaByIdAndProfesores,
                    (materia, profesor) =>
                    {
                        MateriaViewModel materiaEntry;

                        if (!lookup.TryGetValue(materia.Id, out materiaEntry))
                        {
                            lookup.Add(materia.Id, materiaEntry = materia);
                        }

                        if (materiaEntry.Teachers == null)
                            materiaEntry.Teachers = new List<Profesor>();

                        materiaEntry.Teachers.Add(profesor);

                        return materiaEntry;
                    }, new { Id = Id },
                    splitOn: "Id");
            }

            var result = lookup.Values.ToList();
            return result;
        }
    }
}
