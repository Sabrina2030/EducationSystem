using SistemaDeEducacion.Entities;
using System;
using System.Collections.Generic;


namespace SistemaDeEducacion.Models
{
    public class ProfesorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sexo { get; set; }
        public List<Carrera> College { get; set; }
        public List<Materia> Course { get; set; }
    }
}
