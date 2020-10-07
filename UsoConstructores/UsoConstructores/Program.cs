using System;

namespace UsoConstructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); // crear objeto o instancia de tipo coche. dar un estado inicial del objeto

            Coche coche2 = new Coche(12.0, 14.67);

            Console.WriteLine(coche1.getInfoCoche());

            Console.WriteLine(coche2.getInfoCoche());

            coche2.setExtras(true, "Alcántara");

            Console.WriteLine(coche2.getExtras());
        }
    }

    partial class Coche
    {
        public Coche()
        {
            ruedas = 4;

            ancho = 123.6;

            largo = 12.5;

            tapiceria = "Tela";

        }

        public Coche(double nuevoAncho, double nuevoLargo)// constructor hecho por mi
        {
            ruedas = 4;

            largo = nuevoLargo;

            ancho = nuevoAncho;

            tapiceria = "Tela";
        }
    }






    partial class Coche
    {

        public string getInfoCoche()
        {
            return "informacion del coche:\n" + "Ruedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho;
        }

        public void setExtras(bool climatizador, string tapiceria)
        {
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }

        public string getExtras()
        {

            return "Extras del coche: \n" + "Tapicería: " + tapiceria + " ,Climatizador: " + climatizador;
        }

        private int ruedas;

        private double largo;

        private double ancho;

        private bool climatizador;

        private string tapiceria;

    }
}
