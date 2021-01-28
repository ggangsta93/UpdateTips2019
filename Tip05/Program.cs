using System;

namespace Tip05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador Null-Coalescing

            string a = "Hola";
            string b = null;
            string r = "";

            //Si la variable no es null conserva su valor
            r = a ?? "Adios";
            Console.WriteLine(r);

            //Si la variable es null recibe el valor dado
            r = b ?? "Adios";
            Console.WriteLine(r);

            //Asigna a la variable solo si es null [Función propia de C#8]
            b = null;

            a ??= "No tenia null";
            b ??= "tenía null";

            Console.WriteLine("El valor de a queda en {0}",a);
            Console.WriteLine("El valor de b queda en {0}",b);



        }
    }
}
