using System;

namespace UsDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroElegido;
            int intentos = 1;
            Console.WriteLine("Juguemos un juego, voy a elegir un número entre 0 y 100 y tienes que adivinarlo");

            Random numero = new Random();

            int numeroAleatorio = numero.Next(0, 100);

            Console.WriteLine("Adivina a ver si puedes");
            try
            {

                numeroElegido = int.Parse(Console.ReadLine());

            }
            catch (Exception ex) when (ex.GetType()!= typeof(FormatException))
            {
                Console.WriteLine("Se produjo un error, se tomará como si ubieras introducido el numero 0");
                //Console.WriteLine(ex.Message);
                numeroElegido = 0;
            }

            catch(FormatException ex)
            {
                Console.WriteLine("Has introducido texto, se tomará como si ubieras introducido el numero 0");
                numeroElegido = 0;
            }
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
            if (intentos > 1)
                Console.WriteLine($"Enhorabuena adivinaste al intento numero {intentos}");
        }
    }
}
