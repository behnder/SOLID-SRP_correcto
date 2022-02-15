using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_correcto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================");
            Console.WriteLine("SRP");
            Jugador jugador2 = new Jugador("Timy", "Guerrero", 10, 50);
            jugador2.Atacar();
            jugador2.Curar();

            Renderizado renderJugador2 = new Renderizado(jugador2);
            renderJugador2.CargarModelo3D();
            renderJugador2.Animar();
        }
    }
}
