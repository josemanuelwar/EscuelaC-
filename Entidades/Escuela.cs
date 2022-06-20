using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Escuela : ObjetoEscuelaBase
    {

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TiposEscuelas { get; set; }
        public List<Curso> cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela(string pais, string nombre, int AñoDeCreacion, string Pais, string Ciudad)
        {
            this.Pais = pais;
            this.AñoDeCreacion = AñoDeCreacion;
            this.Ciudad = Ciudad;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TiposEscuelas} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }

    }

}