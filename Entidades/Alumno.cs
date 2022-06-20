using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Alumno : ObjetoEscuelaBase
    {
        public List<Evaluacion> Evalucion { get; set; } = new List<Evaluacion>();
   
    }
}