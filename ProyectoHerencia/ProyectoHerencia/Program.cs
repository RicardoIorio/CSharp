using System;

namespace ProyectoHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Caballo Babieca = new Caballo("Barbieca");

            Humano Bruno = new Humano("Bruno");

            Gorila Copito = new Gorila("Copito");

            Mamiferos[] almacenAnimales = new Mamiferos[3];

            almacenAnimales[0] = Babieca;

            almacenAnimales[1] = Bruno;

            almacenAnimales[2] = Copito;

            almacenAnimales[1].getNombre();

           /* Bruno.getNombre();

            Babieca.getNombre();

            Copito.getNombre();*/
        }
    }

    class Mamiferos
    {
        public Mamiferos(string nombre)
        {

            nombreSerVivo = nombre;

        }

        public void getNombre()
        {
            Console.WriteLine("El nombre es "+ nombreSerVivo);
        }


        public void respirar()
        {
            Console.WriteLine("Puedo respirar");
        }

        public void cuidarCrias()
        {
            Console.WriteLine("Cuido de mis crias");
        }

        private string nombreSerVivo;
    }

    class Caballo : Mamiferos
    {
        public Caballo(string nombreCaballo) : base(nombreCaballo)
        {
            

        }
                           
        public void galopar()
        {
            Console.WriteLine("Puedo galopar");
        }
    }

    class Humano : Mamiferos
    {

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public void pensar()
        {
            Console.WriteLine("Puedo pensar... supuestamente");
        }
    }

    class Gorila : Mamiferos
    {

        public Gorila(string nombreGorila) : base(nombreGorila)
        {

        }
        public void trepar()
        {
            Console.WriteLine("Puedo trepar");
        }
    }
}