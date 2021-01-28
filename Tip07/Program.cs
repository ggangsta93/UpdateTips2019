using System;

namespace Tip07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer caso
            Automovil miAuto = new Automovil("Ferrari");
            Console.WriteLine(miAuto);
            Console.WriteLine("------");

            //Segundo caso
            Mascota miMascota = new Mascota();
            Console.WriteLine(miMascota);
            Console.WriteLine("------");

            //Tercer caso
            Mensajes miMensaje = new Mensajes();
            miMensaje.Saludo();
            Console.WriteLine("------");

            //Cuarto caso
            Amigo miAmigo = new Amigo("Aldo", "5554443333");
            miAmigo.Mensajear();
                                                         
        }
    }
}
