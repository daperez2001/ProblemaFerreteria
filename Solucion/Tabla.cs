using System;

namespace Solucion
{
    public class Tabla
    {
        public double Ancho { get; private set; }
        public double Largo { get; private set; }
        public double Precio { get; private set; }

        public Tabla(double ancho, double largo, double precioBase)
        {
            Ancho = ancho;
            Largo = largo;
            Precio = (ancho * largo) * (precioBase / (4 * 6)); // Precio proporcional al área
        }

        public double CalcularPrecioPorArea(double ancho, double largo)
        {
            double areaSolicitada = ancho * largo;
            return Precio * (areaSolicitada / (Ancho * Largo));
        }

        public Tabla Cortar(double anchoSolicitado, double largoSolicitado)
        {
            // Lógica para calcular el corte y devolver la tabla restante y la tabla del cliente.
            // Ejemplo de ajuste del ancho o largo para simular el corte
            // Verificar si el corte es posible y ajustar dimensiones
            if (anchoSolicitado <= Ancho && largoSolicitado <= Largo)
            {
                double nuevoAncho = Ancho - anchoSolicitado;
                double nuevoLargo = Largo - largoSolicitado;
                Ancho = anchoSolicitado;
                Largo = largoSolicitado;
                return new Tabla(nuevoAncho, nuevoLargo, Precio);
            }
            else
            {
                Console.WriteLine("No se puede realizar el corte: dimensiones inválidas.");
                return null;
            }
        }
    }
}
