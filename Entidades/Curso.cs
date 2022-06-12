using System.Collections.Generic;
using System;
namespace CoreEscuela.Entidades
{
    public class Curso
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }
        public TiposJornada Jornada { get; set; }

        public List<Asignatura> Asignatura { get; set; }
        public List<Alumno> Alumnos { get; set; }
        public Curso() => this.UniqueId = Guid.NewGuid().ToString();

    }
}