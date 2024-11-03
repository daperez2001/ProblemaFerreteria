using System;

namespace Solucion
{
    public class Programa
    {
        public static void Main()
        {
            Ferreteria ferreteria = new Ferreteria(4, 6, 24000);
            // Ejemplo de uso
            ferreteria.ProcesarSolicitud(2, 3);
            ferreteria.ProcesarSolicitud(1, 2);
        }
    }
}
