using System;

namespace Tip11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con constructor normal

            Mascota perro = new Mascota("Manchas");
            Mascota gato = new Mascota("Michi");
            Mascota pez = new Mascota("Memo");

            Console.WriteLine(perro);
            Console.WriteLine(gato);
            Console.WriteLine(pez);

            Console.WriteLine("-------------");

            //Con costructor estatico
            Alimento pan = new Alimento();
            Alimento leche = new Alimento();

            pan.Calorias = 50;
            leche.Calorias = 75;

            Console.WriteLine(pan);
            Console.WriteLine(leche);




        }
    }
}
