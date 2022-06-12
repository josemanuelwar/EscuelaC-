using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using CoreEscuela.Entidades;
using System.Linq;
namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public void Inicializar()
        {
            Escuela = new Escuela("Facultad de ciencias de la computacion", 2012);
            Escuela.TiposEscuelas = TipoEscuela.Primaria;
            Escuela.Ciudad = "Puebla";
            Escuela.Pais = "Mexico";
            CargarCursos();
            CargarAsignaturas();
            CargarEvaluaciones();
        }

        private List<Alumno> GeneralAlumnoAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipe", "Eusebio", "Farid", "Donal", "Alvaro", "Nicolas" };
            string[] apellidos1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trupm", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumno = from n1 in nombre1
                              from n2 in nombre2
                              from n3 in apellidos1
                              select new Alumno { Nombre = $"{n1} {n2} {n3}" };

            return listaAlumno.OrderBy((al) => al.UniqueId).Take(cantidad).ToList();
        }


        private void CargarCursos()
        {
            Escuela.cursos = new List<Curso>(){
                new Curso(){Nombre="101", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre="201", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre="301", Jornada=TiposJornada.Mañana},
                new Curso(){Nombre="401", Jornada=TiposJornada.Tarde},
                new Curso(){Nombre="501", Jornada=TiposJornada.Tarde},
                new Curso(){Nombre="502", Jornada=TiposJornada.Tarde}
            };
            Random rnd = new Random();
            foreach (var c in Escuela.cursos)
            {
                int cantidadRandor = rnd.Next(5, 20);
                c.Alumnos = GeneralAlumnoAlAzar(cantidadRandor);
            }
        }

         protected void CargarAsignaturas()
        {
            foreach (var curso in Escuela.cursos)
            {
                List<Asignatura> listaAsignatura = new List<Asignatura>(){
                    new Asignatura { Nombre="Matematicas" },
                    new Asignatura { Nombre="Educasion Fisica" },
                    new Asignatura { Nombre="Castellano" },
                    new Asignatura { Nombre="Ciencias Naturales" }
                };
                curso.Asignatura = listaAsignatura;
            }
        }


        private  void CargarEvaluaciones()
        {
            foreach (var curso in Escuela.cursos)
            {
                foreach (var asignatura in curso.Asignatura)
                {
                    foreach (var alumno in curso.Alumnos)
                    {

                   
                     for (var i = 0; i < 5; i++)
                     {
                        var rnd = new Random(System.Environment.TickCount);
                        var ev  = new Evaluaciones
                        {
                            Asignatura = asignatura,
                            Nombre = $"{asignatura.Nombre} Ev# {i+1}",
                            Nota = (float) (5*rnd.NextDouble()),
                            Alumno=alumno
                        };
                        
                        //alumno.Evalucion.Add(ev);
                        //alumno.Evalucion.Add(ev);
                     }   
                        
                    }
                    
                }
                
            }

        }

    }
}