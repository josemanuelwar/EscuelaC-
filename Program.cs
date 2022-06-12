using System.Security.Cryptography;
using System;
using CoreEscuela;
using CoreEscuela.Entidades;
using CoreEscuela.Util;
using static System.Console;
namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            //Printer.Beep();
            engine.Inicializar();
            ImprimirCursosEscuela(engine.Escuela);
        }
        public static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.writeTitle("Cursos de la Escuela");
            try
            {
                if (escuela?.cursos != null)
                {
                    foreach (var curso in escuela.cursos)
                    {
                        WriteLine($"nombre: {curso.Nombre}, id: {curso.UniqueId}");
                    }

                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}