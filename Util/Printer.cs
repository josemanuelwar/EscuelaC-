using static System.Console;
namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void DibujarLinea(int tam =15){
            WriteLine("".PadLeft(tam,'='));
        }

        public static void writeTitle(string titulo){
            var tamano = titulo.Length+4;
            DibujarLinea(tamano);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamano);
        }

        public static void Beep(int hz = 2000,int tiempo = 500,int cantidad=1){
            while (cantidad-- > 0)
            {
                System.Console.Beep(hz,tiempo);
            }
        }
    }
}