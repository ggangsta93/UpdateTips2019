using System;

namespace Tip01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            int m = 1000000;

            //Esto debe generar un overflow pero nunca nos enteramos
            int r = n * m;

            Console.WriteLine("Resultado: " + r);

            //Produce una excepción
            //int r2 = checked(n * m);
            //Console.WriteLine("Resultado: " + r);

            //Ahora capturamos la excepcion
            int r3 = 0;
            int r4 = 0;

            try
            {
                //Podemos tener un bloqeue donde se
                //verifica por overflow en todas las operaciones que
                //se lleven a cabo adhí
                //checked
                {
                    r3 = n * m;
                    r4 = n + m;
                }
            }
            catch
            {
                Console.WriteLine("Problema de overflow");
            }

        }
    }
}
