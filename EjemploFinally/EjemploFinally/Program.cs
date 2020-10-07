using System;

namespace EjemploFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\Bruno\Desktop\tirar.txt";

                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch(Exception ex)
            { 
                Console.WriteLine("Error con la lectura del archivo");

                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexión cerrada");


            }
        }
    }
}
