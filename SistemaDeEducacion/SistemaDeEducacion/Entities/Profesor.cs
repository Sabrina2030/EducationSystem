using System;
using System.ComponentModel;

namespace SistemaDeEducacion.Entities
{
    public class Profesor
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sexo { get; set; }

        [Description("ignore")]
        public static string GetAllProfesores
        {
            get
            {
                return @"select profesores.nombre as Name, profesores.apellido as LastName, profesores.dni as Dni, 
                        profesores.[fecha-nacimiento] as DateOfBirth, sexo.sexo as Sexo from profesores
                        inner join sexo on sexo.id = profesores.idsexo";
            }
        }

        [Description("ignore")]
        public static string GetProfesorById
        {
            get
            {
                return @"select profesores.nombre as Name, profesores.apellido as LastName, profesores.dni as Dni,
                        profesores.[fecha-nacimiento] as DateOfBirth, sexo.sexo as Sexo, materias.id as Id, 
                        materias.nombre as Name, carreras.id as Id, carreras.nombre as Name from profesores
                        inner join sexo on sexo.id = profesores.idsexo
                        inner join clase on clase.idprofesor = profesores.id
                        inner join materias on materias.id = clase.idmateria
                        inner join carreras on carreras.id = clase.idcarrera
                        where profesores.id =  @Id";
            }
        }
    }
}
