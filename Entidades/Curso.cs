using System.Collections.Generic;
using System;
namespace CoreEscuela.Entidades
{
    public class Curso : ObjetoEscuelaBase
    {
        public TiposJornada Jornada { get; set; }

        public List<Asignatura> Asignatura { get; set; }
        public List<Alumno> Alumnos { get; set; }

    }
}