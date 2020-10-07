using System;
namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos a evaluar si puedes conducir un vehiculo");

            Console.WriteLine("Introduzca su edad");

            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Tienes carnet de conducir?");

                string carnet = Console.ReadLine();

                int compara = String.Compare(carnet, "si", true);

                if (compara == 0)
                    Console.WriteLine("Felicidades puedes conducir");

                else
                    Console.WriteLine("Lo siento pero no puedes conducir");
            }
            else
                Console.WriteLine("Lo siento pero no puedes conducir");
        }
    }
}