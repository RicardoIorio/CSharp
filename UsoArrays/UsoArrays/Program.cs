using System;

namespace UsoArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //array implícito

            //  var datos = new[] { "Juan", "Díaz", "España" };

            var valores = new[] { 15, 28, 35, 75.5}; // todo a double

            // array de objetos

            empleados Ana = new empleados("Ana", 27);

            empleados[] arrayEmpleados = new empleados[2];

            arrayEmpleados[0] = new empleados("Sara", 25);

            arrayEmpleados[1] = Ana;

            // array de tipos o clases anónimas

            var personas = new[]
            {
                new{nombre="Juan", edad=19},

                new{nombre="María", edad=49},

                new{nombre="Diana", edad=35}
            };

            /* for(int i = 0; i < arrayEmpleados.Length; i++)
             {

                 Console.WriteLine(arrayEmpleados[i].getNameAge());


             }*/

            foreach (double variable in valores)
            {

                Console.WriteLine(variable);
            }

        }

    }

    class empleados
    {
        public empleados(string nombre, int edad)
        {

            this.nombre = nombre;

            this.edad = edad;

        }

        public string getNameAge()
        {
            return $"{nombre}: {edad}";


        }

        private string nombre;

        private int edad;
    }
}
