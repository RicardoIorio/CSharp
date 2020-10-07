using System;

namespace CondicionalIF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad");

            int edad = int.Parse(Console.ReadLine());

            if (edad < 18)
                Console.WriteLine("Eres un niño");

            else if (edad >= 18)
                Console.WriteLine("Eres joven");

            else if (edad >= 30)
                Console.WriteLine("Eres maduro");

            else if (edad >= 60)
                Console.WriteLine("Eres viejo");
        }
    }
}
