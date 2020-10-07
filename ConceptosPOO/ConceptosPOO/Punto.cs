using System;
using System.Collections.Generic;
using System.Text;

namespace ConceptosPOO
{
    class Punto
    {

        public Punto()
        {
            //Console.WriteLine("Este es el constructor por defecto" );

            this.x = 0;
            this.y = 0;

            contadorDeObjetos++;
        }


        public Punto(int x, int y)
        {
            //Console.WriteLine($"Coordenada x: {x} , Coordenada y: {y}");

            this.x = x;

            this.y = y;

            contadorDeObjetos++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {

            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));

            return distanciaPuntos;


        }
        public static int ContadorDeObjetos() => contadorDeObjetos;

        private static int contadorDeObjetos = 0;

        private int x , y;

        private const int constantePrueba = 7;
    }

}
