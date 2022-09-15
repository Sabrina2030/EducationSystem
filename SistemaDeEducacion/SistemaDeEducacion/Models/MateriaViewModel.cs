using SistemaDeEducacion.Entities;
using System.Collections.Generic;


namespace SistemaDeEducacion.Models
{
    public class MateriaViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Alumnos> Students { get; set; }

        public List<Profesor> Teachers { get; set; }
    }
}
