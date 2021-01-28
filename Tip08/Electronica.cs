using System;
using System.Collections.Generic;
using System.Text;

namespace Tip11
{
    class Electronica:Mascota
    {
        //Usamos new para indicarle al compilador que
        //el ocultamiento no es accidental

        private new string nombre;

        public String Nombre
        {
            set { nombre = value; }
        }

    }
}
