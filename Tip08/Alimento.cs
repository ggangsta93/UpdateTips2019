using System;
using System.Collections.Generic;
using System.Text;

namespace Tip11
{
    class Alimento
    {
        private int calorias;
        //El constructor estatico se ejecuta solo una vez para todas las instancias
        static Alimento()
        {
            Console.WriteLine("Desde el constructor de Alimento");
        }
        
        public int Calorias
        {
            set { calorias = value; }
        }

        public override string ToString()
        {
            return string.Format("Tiene {0} calorias", calorias);
        }

    }
}
