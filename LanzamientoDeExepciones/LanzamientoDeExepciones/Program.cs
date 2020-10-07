using System;

namespace LanzamientoDeExepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número del mes");

            int numMes = int.Parse(Console.ReadLine());
           
            Console.WriteLine(NombreDelMes(numMes));
            
            Console.WriteLine("aqui sigue el programa");
            


            static string NombreDelMes(int mes)
            {
                switch (mes)
                {
                    case 1:
                        return "Enero";

                    case 2:
                        return "Febrero";

                    case 3:
                        return "Marzo";

                    case 4:
                        return "Abril";

                    case 5:
                        return "Mayo";

                    case 6:
                        return "Junio";

                    case 7:
                        return "Julio";

                    case 8:
                        return "Agosto";

                    case 9:
                        return "Septiembre";

                    case 10:
                        return "Octube";

                    case 11:
                        return "Noviembre";

                    case 12:
                        return "Diciembre";

                    default:
                            return "gato";


                }

            }
        }
    }
}