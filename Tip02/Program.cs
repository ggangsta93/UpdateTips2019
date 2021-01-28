using System;

namespace Tip02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Float y double representan los numeros en base 2
            //Valores fraccionarios no se van a representar bien
            //y dar errores de precision

            float a = 1f;
            float b = 0.1f;

            float r = a - (b * 10);//Cuales el valor de r?

            Console.WriteLine("Con flotante {0}",r);//Aquí a Nicosio le dió otro valor diferente de cero

            //Como podemos corregir esto?
            //Hacemos uso de decimal, pues representa los numeros en
            //base 10

            decimal a1 = 1;
            decimal b1 = 0.1m;

            decimal r1 = a1 - (b1 * 10);//Cual es el valor der?
            Console.WriteLine("Con decimal es {0}",r1);





        }
    }
}
