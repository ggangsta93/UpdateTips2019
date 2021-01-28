using System;
using System.Collections.Generic;
using System.Text;

namespace Tip07
{
    class Mascota
    {
        private string nombre = "Sin nombre";
        private int anios = 0;

        //Version de default
        //Si colocamos la invocacion al otro constructor
        //Se invoca primero el de parametro y luego el de default
        //El de default pondra sus propios valores sin importar
        //los colocados por el de parametros

        public Mascota():this("Manchas",1)
        {
            Console.WriteLine("Constructor de default");
            nombre = "Punk";
        }

        //Version con parametro
        public Mascota(String pNombre, int pAnios)
        {
            Console.WriteLine("Constructor con parametro");
            nombre = pNombre;
            anios = pAnios;
        }

        public override string ToString()
        {
            return string.Format("Tu mascota se llama {0} y tiene {1} años.",nombre,anios);
        }
    }
}
