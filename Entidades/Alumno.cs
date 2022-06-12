using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Alumno
    {
        public string UniqueId { get; private set; }
        public string Nombre { get; set; }

        public List<Evaluaciones> Evalucion { get; set; } = new List<Evaluaciones>();
        public Alumno() => UniqueId = Guid.NewGuid().ToString();

    }
}