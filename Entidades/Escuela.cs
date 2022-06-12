using System;
using System.Collections.Generic;
namespace CoreEscuela.Entidades
{
    public class Escuela
    {
        public string UniqueId {get; private set;} = Guid.NewGuid().ToString();
        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value.ToUpper(); }
        }

        public int AñoDeCreacion { get; set; }

        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public TipoEscuela TiposEscuelas { get; set; }
        public List<Curso> cursos { get; set; }

        public Escuela(string nombre, int año) => (Nombre, AñoDeCreacion) = (nombre, año);

        public Escuela()
        {
            this.AñoDeCreacion = 0;
            this.Ciudad = "p";
            this.Pais = "p";
            this.nombre = "m";
        }

        public Escuela(string pais, string nombre, int AñoDeCreacion, string Pais, string Ciudad)
        {
            this.Pais = pais;
            this.AñoDeCreacion = AñoDeCreacion;
            this.Ciudad = Ciudad;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {TiposEscuelas} \n Pais: {Pais}, Ciudad: {Ciudad}";
        }

    }

}