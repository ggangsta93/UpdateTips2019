using System;
using System.Collections.Generic;
using System.Text;

namespace Tip11
{
    class Mascota
    {
        protected string nombre;
        public Mascota()
        {

        }
        public Mascota(String pNombre)
        {
            nombre = pNombre;
            Console.WriteLine("Desde el contructor de Mascota");
        }

        public override string ToString()
        {
            return string.Format("Mi mascota es {0}",nombre);
        }
    }
}
