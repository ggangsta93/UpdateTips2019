using System;
using System.Collections.Generic;
using System.Text;

namespace Tip07
{
    class Amigo
    {
        private string nombre;
        private string whats;

        public Amigo(string pNombre, string pWhats)
        {
            this.nombre = pNombre;
            this.whats = pWhats;
        }

        public override string ToString()
        {
            return string.Format("Mi amigo {0} tiene whats {1}",nombre,whats);
        }

        //Cuarto caso
        //Nos mandamos a nosotros mismos como parametro
        //Para que quien nos reciba trabaje con nosotros
        public void Mensajear()
        {
            Mensajes miMensaje = new Mensajes();
            miMensaje.Presentar(this);
        }

    }
}
