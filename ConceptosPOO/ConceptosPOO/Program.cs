using System;


namespace ConceptosPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            //clases anónimas
            var miVar = new { nombre = "Bruno", edad = 16 };

            Console.WriteLine(miVar.nombre + " " + miVar.edad);

            var otraVar = new { nombre = "Ana", edad = 25 };

            miVar = otraVar;
        }

        static void realizarTarea()
        {

            Punto origen = new Punto();

            Punto destino = new Punto(128, 80);

            Punto otroPunto = new Punto();

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia entre los puntos es de : {distancia}");

            Console.WriteLine($"Numero de objetos creados: {Punto.ContadorDeObjetos()}");
        }
    }
}
