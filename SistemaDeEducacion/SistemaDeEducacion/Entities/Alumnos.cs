using System;
using System.ComponentModel;

namespace SistemaDeEducacion.Entities
{
    public class Alumnos
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }

        //public int idSexo { get; set; }

        [Description("ignore")]
        public string Sexo { get; set; }


        [Description("ignore")]
        public static string GetAlumnos
        {
            get
            {
                return @"select alumnos.nombre AS Name, alumnos.apellido AS LastName, alumnos.[fecha-nacimiento] AS DateOfBirth, 
                         alumnos.dni AS Dni, alumnos.domicilio AS Address, sexo.sexo AS Sexo from alumnos
                         inner join sexo on sexo.id = alumnos.idsexo";
            }
        }

        [Description("ignore")]
        public static string GetAlumnoById
        {
            get
            {
                return @"select alumnos.nombre as Name, alumnos.apellido as LastName, alumnos.dni as Dni, 
                        alumnos.[fecha-nacimiento] as DateOfBirth, alumnos.domicilio as Address , sexo.sexo as Sexo, 
                        periodo.[fecha-inicio] as FirstDay, periodo.semestre as Semester, clase.*, materias.id as Id, 
                        materias.nombre as Name, carreras.id as Id, carreras.nombre as Name from dbo.alumnos
                        inner join dbo.[alumno-clase] on [alumno-clase].idalumno = alumnos.id
                        inner join dbo.sexo on sexo.id = alumnos.idsexo
                        inner join dbo.Periodo on Periodo.id = [alumno-clase].idperiodo
                        inner join dbo.clase on clase.id = [alumno-clase].idclase
                        inner join dbo.materias on materias.id = clase.idmateria
                        inner join dbo.carreras on carreras.id = clase.idcarrera
                        where alumnos.id = @Id";
            }
        }

        [Description("ignore")]
        public static string InsertAlumno
        {
            get
            {
                return @"insert into dbo.alumnos (id, nombre, apellido, dni, [fecha-nacimiento], domicilio, idsexo) 
                        values (@Id, @Name, @LastName, @Dni, @DateOfBirth, @Address, @SexoId)";
            }
        }

    }
}
