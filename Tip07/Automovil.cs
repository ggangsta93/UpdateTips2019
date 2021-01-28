using System;
using System.Collections.Generic;
using System.Text;

namespace Tip07
{
    class Automovil
    {
        private string modelo = "Ninguno asignado";

        //Primer uso
        //Usamos this para quitar la ambiguedad entre el nombre del parametro
        //y el atributo

        public Automovil(string modelo)
        {
            //Aqui aparece una ambiguedad para quien lea el codigo
            //para la computadora es modelo el parametro
            //modelo = "Vochito";

            //Ahora indicamos que usamos el atributo
            //this es una autoreferencia al objetso que esta ejecutando el codigo
            this.modelo = modelo;
        }

        public override string ToString()
        {
            return string.Format("Tu auto es {0}",modelo);
        }
    }
}
