using System;
using System.Collections.Generic;
using System.Text;

namespace Tip07
{
    class Mensajes
    {
        //Tercer caso
        //Para invocar un metodo de la clase actual
        //Esto desde luegose puede simplificar

        public void Saludo()
        {
            Console.WriteLine("Hola a todos");
            this.Despide();
        }

        public void Despide()
        {
            Console.WriteLine("Adios a todos");
        }

        //Para el cuarto caso
        public void Presentar(Amigo pAmigo)
        {
            Console.WriteLine("Les presento a mi amigo");
            Console.WriteLine(pAmigo);
        }
    }
}
