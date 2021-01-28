using System;

namespace Tip04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nuevo C#8

            //Indice, permite referenciar al final del grupo con
            //el operador ^
            //^0 genera error, ^1 en adelante hasta el limite del arreglo

            int[] arreglo = new int[] { 0, 1, 2, 3, 4, 5 };

            int ultimo = arreglo[^1];
            int penultimo = arreglo[^2];

            Console.WriteLine($"Ultimo {ultimo}, penultimo {penultimo}");

            //Tanges, permite hacer slices o rebanadas del arreglo
            int[] primeros = arreglo[..2];
            int[] ultimos = arreglo[3..];
            int[] intermedios = arreglo[2..4];

            Console.WriteLine("primeros");
            foreach (int n in primeros)
                Console.Write(n+" ");

            Console.WriteLine("\nultimos");
            foreach (int n in ultimos)
                Console.Write(n + " ");

            Console.WriteLine("\nintermedios");
            foreach (int n in intermedios)
                Console.Write(n + " ");



        }
    }
}
