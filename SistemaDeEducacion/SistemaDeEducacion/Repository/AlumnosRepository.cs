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
    public class AlumnosRepository : IAlumnosRepository
    {
        private readonly string _connectionString;

        public AlumnosRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<List<AlumnosViewModel>> GetAlumnos()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var result = await connection.QueryAsync<AlumnosViewModel>(Alumnos.GetAlumnos);
                return result.ToList();
            }
        }

        public async Task<List<AlumnosViewModel>> GetAlumnoById(int id)
        {
            var lookup = new Dictionary<int, AlumnosViewModel>();

            using (var resource = new SqlConnection(_connectionString))
            {
                var listado = await resource.QueryAsync<AlumnosViewModel, Carrera, Materia, AlumnosViewModel>(Alumnos.GetAlumnoById,
                    (alumno, carrera, materia) =>
                    {
                        AlumnosViewModel alumnoEntry;

                        if (!lookup.TryGetValue(alumno.Id, out alumnoEntry))
                        {
                            lookup.Add(alumno.Id, alumnoEntry = alumno);
                        }

                        if (alumnoEntry.College == null)
                            alumnoEntry.College = new List<Carrera>();

                        if (alumnoEntry.Course == null)
                            alumnoEntry.Course = new List<Materia>();

                        if (!alumnoEntry.College.Any(x => x.Id == carrera.Id))
                            alumnoEntry.College.Add(carrera);

                        if (!alumnoEntry.Course.Any(x => x.Id == materia.Id))
                            alumnoEntry.Course.Add(materia);

                        return alumnoEntry;
                    }, new { Id = id },
                    splitOn: "Id");
            }

            var result = lookup.Values.ToList();
            return result;
        }

        public async Task<AlumnosViewModel> InsertAlumno(AlumnosViewModel alumno)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
               try 
                {
                      var result = await connection.QueryAsync<AlumnosViewModel>(Alumnos.InsertAlumno, new
                      {
                            Id = new Random().Next(4, 1000),
                            Name = alumno.Name,
                            LastName = alumno.LastName,
                            Dni = alumno.Dni,
                            DateOfBirth = alumno.DateOfBirth,
                            Address = alumno.Address,
                            SexoId = alumno.SexoId
                      });
                      return result.FirstOrDefault();
                }
                catch (Exception ex)
                {
                      throw ex;
                }
            }
        }

    }
}
