using System;

namespace Tip03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tips con cadenas

            //Como usar caracteres unicode codificados como 4 digitos
            //hexadecimales
            char c = '\u00a9';

            Console.WriteLine("{0}",c);

            //Concatenación con valores numericos
            //ToString se invoca automaticamente

            Console.WriteLine("El cinco es "+5);
            float a = 3.567891f;
            Console.WriteLine("El valor de a " + a);

            //Interpolacion de cadenas
            Console.WriteLine($"El valor de {a} es importante {c}");
        }
    }
}
