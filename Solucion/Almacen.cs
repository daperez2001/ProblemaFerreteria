using System;

namespace Solucion
{
    public class Almacen
    {
        private Tabla[] tablas;
        private int contador;

        public Almacen(int capacidadMaxima)
        {
            tablas = new Tabla[capacidadMaxima];
            contador = 0;
        }

        // Quitar
        public void AgregarTabla(Tabla tabla)
        {
            if (contador < tablas.Length)
            {
                tablas[contador++] = tabla;
                Array.Sort(tablas, 0, contador, Comparer<Tabla>.Create((a, b) => a.Ancho.CompareTo(b.Ancho)));
            }
        }
        // Quitar
        public Tabla BuscarTablaAdecuada(double ancho, double largo)
        {
            foreach (var tabla in tablas)
            {
                if (tabla != null && tabla.Ancho >= ancho && tabla.Largo >= largo)
                {
                    return tabla;
                }
            }
            return null;
        }
    }
}
