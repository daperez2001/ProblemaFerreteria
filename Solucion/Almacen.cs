using System;

namespace Solucion
{
    public class Almacen
    {
        private List<Tabla> tablas;

        public Almacen(int capacidadMaxima)
        {
            tablas = new (capacidadMaxima);
        }

        // Quitar
        public void AgregarTabla(Tabla tabla)
        {
            if (tablas.Count < tablas.Capacity)
            {
                tablas.Add(tabla);
                tablas.Sort();
            }
        }
        // Quitar
        public Tabla? BuscarTablaAdecuada(double ancho, double largo)
        {
            foreach (var tabla in tablas)
            {
                if (tabla != null && tabla.Ancho >= ancho && tabla.Largo >= largo)
                {
                    tablas.Remove(tabla);
                    return tabla;
                }
            }
            return null;
        }
    }
}
