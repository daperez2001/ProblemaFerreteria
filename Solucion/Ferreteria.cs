using System;

namespace Solucion
{
    public class Ferreteria
    {
        private Almacen almacen;
        private Tabla estandar;
        
        public Ferreteria(double anchoInicial, double largoInicial, double precioBase)
        {
            almacen = new Almacen(500);
            estandar = new Tabla(anchoInicial, largoInicial, precioBase);
            almacen.AgregarTabla(new Tabla(anchoInicial, largoInicial, precioBase));
        }

        
        public double ProcesarSolicitud(double anchoSolicitado, double largoSolicitado)
        {
            Tabla? tabla = almacen.BuscarTablaAdecuada(anchoSolicitado, largoSolicitado);
            if (tabla is null)
            {
                tabla = new Tabla(estandar.Ancho, estandar.Largo, estandar.Precio);
                if (tabla.Ancho < anchoSolicitado || tabla.Largo < largoSolicitado)
                {
                    almacen.AgregarTabla(tabla);
                    return -1;
                }
            }
            
            var residuales = tabla.Cortar(anchoSolicitado, largoSolicitado);
            
            foreach(var residual in residuales)
                almacen.AgregarTabla(residual);
            
            double precio = tabla.CalcularPrecioPorArea(anchoSolicitado, largoSolicitado);
            return precio;
        }
    }
}