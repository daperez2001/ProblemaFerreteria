using System;

namespace Solucion
{
    public class Ferreteria
    {
        private Almacen almacen;
        private double precioBase;

        public Ferreteria(double anchoInicial, double largoInicial, double precioBase)
        {
            almacen = new Almacen(500);
            this.precioBase = precioBase;
            almacen.AgregarTabla(new Tabla(anchoInicial, largoInicial, precioBase));
        }

        public void ProcesarSolicitud(double anchoSolicitado, double largoSolicitado)
        {
            Tabla tabla = almacen.BuscarTablaAdecuada(anchoSolicitado, largoSolicitado);
            if (tabla != null)
            {
                Tabla residual = tabla.Cortar(anchoSolicitado, largoSolicitado);
                double precio = tabla.CalcularPrecioPorArea(anchoSolicitado, largoSolicitado);
                Console.WriteLine($"Tabla vendida por {precio} colones.");

                if (residual != null)
                {
                    almacen.AgregarTabla(residual);
                }
            }
            else
            {
                Console.WriteLine("No hay tablas disponibles para las dimensiones solicitadas.");
            }
        }
    }
}
