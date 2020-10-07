using System;

namespace EjemplosPOO
{

    class Program
    {
        static void Main(string[] args)
        {

            ConversorEuroDolar obj = new ConversorEuroDolar();

            obj.CambiaValorEuro(1.45);

            Console.WriteLine(obj.Convierte(50));
           /* Circulos circulo1; // Creamos una variable de tipo circulo / creamos un objeto de tipo circulo

            circulo1 = new Circulos(); //iniciamos el objeto que creamos antes, instanciacion de clase

            Console.WriteLine(circulo1.CalculoArea(5));

            Circulos circulo2;

            circulo2 = new Circulos();

            Console.WriteLine(circulo2.CalculoArea(9));*/

        }
    }
    class Circulos
    {
        private const double pi = Math.PI; //Propiedad de la clase Circulos. Campos de clase

        public double CalculoArea (int radio) //Metodo de clase. Lo que pueden hacer los objetos de tipo circulos
        {
            return pi * radio * radio;   
            
        }
    }

    class ConversorEuroDolar
    {
        double euro = 1.253;

        public double Convierte(double cantidad)
        {

            return cantidad * euro;
        }

        public void CambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = euro;

            else
            euro = nuevoValor;

        }
    }
}
