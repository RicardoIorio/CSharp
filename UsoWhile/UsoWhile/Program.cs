using System;

namespace UsoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 1;
            Console.WriteLine("Juguemos un juego, voy a elegir un número entre 0 y 100 y tienes que adivinarlo");

            Random numero = new Random();

            int numeroAleatorio = numero.Next(0, 100);

            Console.WriteLine("Adivina a ver si puedes");

            int numeroElegido = int.Parse(Console.ReadLine());

            if (numeroElegido == numeroAleatorio)
                Console.WriteLine("Enhorabuena adivinaste al primer intento, como lo has hecho O_O");

            while (numeroElegido != numeroAleatorio)
            {
                intentos++;

                if (numeroElegido < numeroAleatorio)
                {
                    Console.WriteLine($"Ups parece que no acertaste, el numero es mas alto que {numeroElegido}");
                    numeroElegido = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Ups parece que no acertaste, el numero es mas bajo que {numeroElegido}");
                    numeroElegido = int.Parse(Console.ReadLine());
                }              
            }
            if(intentos>1)
                Console.WriteLine($"Enhorabuena adivinaste al intento numero {intentos}");
        }
    }
}
