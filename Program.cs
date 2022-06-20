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
            var listaObjetos = engine.GetObjetoEscuelas();
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