using System.ComponentModel;

namespace SistemaDeEducacion.Entities
{
    public class Materia
    {
        public int? Id { get; set; }
        public string Name { get; set; }


        [Description("ignore")]
        public static string GetMaterias
        {
            get
            {
                return @"select materias.id, materias.nombre as Name from materias";
            }
        }

        [Description("ignore")]
        public static string GetMateriaByIdAndProfesores
        {
            get
            {
                return @"select materias.id, materias.nombre as Name, clase.*, profesores.id, profesores.nombre as Name, 
                        profesores.apellido as LastName, profesores.dni as Dni from materias 
                        inner join clase on clase.idmateria = materias.id
                        inner join profesores on profesores.id = clase.idprofesor
                        where materias.id = @Id";
            }
        }

        [Description("ignore")]
        public static string GetMateriaByIdAndAlumnos
        {
            get
            {
                return @"select materias.id, materias.nombre as Name, clase.*, alumnos.id, alumnos.nombre as Name,
                        alumnos.apellido as LastName, alumnos.dni as Dni from materias
                        inner join clase on clase.idmateria = materias.id
                        inner join [alumno-clase] on [alumno-clase].idclase = clase.id
                        inner join alumnos on alumnos.id = [alumno-clase].idalumno
                        where materias.id = @Id";
            }
        }
    }

}
