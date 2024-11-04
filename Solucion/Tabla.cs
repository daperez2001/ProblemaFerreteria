using System;

namespace Solucion
{
    public class Tabla : IComparable<Tabla>
    {
        public double Ancho { get; private set; }
        public double Largo { get; private set; }
        public double Precio { get; private set; }

        public Tabla(double ancho, double largo, double precioBase)
        {
            Ancho = ancho;
            Largo = largo;
            Precio = precioBase;
        }

        // Quitar
        public double CalcularPrecioPorArea(double ancho, double largo)
        {
            double areaSolicitada = ancho * largo;
            return Precio * areaSolicitada;
        }

        public List<Tabla> Cortar(double anchoSolicitado, double largoSolicitado)
        {
            // Lógica para calcular el corte y devolver la tabla restante y la tabla del cliente.
            // Ejemplo de ajuste del ancho o largo para simular el corte
            // Verificar si el corte es posible y ajustar dimensiones
            var tablas = new List<Tabla>();
            if (largoSolicitado < Largo)
            {
                double nuevoLargo = Largo - largoSolicitado;
                Largo = largoSolicitado;
                tablas.Add(new Tabla(Ancho, nuevoLargo, Precio));
            }
            if (anchoSolicitado < Ancho)
            {
                double nuevoAncho = Ancho - anchoSolicitado;
                Ancho = anchoSolicitado;
                tablas.Add(new Tabla(nuevoAncho, Largo, Precio));
            }
            return tablas;
        }

        public int CompareTo(Tabla? other)
        {
            if (other == null) return 1;
            if (this.Ancho != other.Ancho) return this.Ancho > other.Ancho ? 1 : -1;
            if (this.Largo == other.Largo) return 0;
            return this.Largo > other.Largo ? 1 : -1;
        }
    }
}
