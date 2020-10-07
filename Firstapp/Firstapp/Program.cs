using System;

namespace Firstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;

            Console.WriteLine("Introduce la medida del radio");

            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;

            double area = Math.Pow(radio, 2)* PI;

            Console.WriteLine($"El area del círculo es: {area} ");



        }
    }
}