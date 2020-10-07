using System;

namespace UsoArrays2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayElementos = Leerdatos();

            foreach (int i in arrayElementos) Console.WriteLine(i);
        }

        static int[] Leerdatos ()      
        {

            Console.WriteLine("¿Cuantos elementos quiere que tenga el array?");

            string respuesta = Console.ReadLine();

            int numElementos = int.Parse(respuesta);

            int[] datos = new int[numElementos];

            for(int i = 0; i < numElementos; i++)
            {

                Console.WriteLine($"Introduce el dato para la posición{i}");

                respuesta = Console.ReadLine();

                int datosElementos = int.Parse(respuesta);

                datos[i] = datosElementos;
            }

            return datos;
        }
    }
}
