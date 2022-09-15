using SistemaDeEducacion.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SistemaDeEducacion.Models
{
    public class AlumnosViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public int? SexoId { get; set; }

        [Description("ignore")]
        public string Sexo { get; set; }
        public DateTime? FirstDay { get; set; }
        public int? Semester { get; set; }
        public List<Carrera> College { get; set; }
        public List<Materia> Course { get; set; }
    }
}
