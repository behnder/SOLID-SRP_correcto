using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_SRP_correcto
{
    class Renderizado
    {
        
            Jugador jugadorSRP;

            public Renderizado(Jugador jugador)
            {
                this.jugadorSRP = jugador;
            }

            public void CargarModelo3D()
            {
                Console.WriteLine("Cargando modelo del jugador... " + jugadorSRP.Nombre);
            }
            public void Animar()
            {
                Console.WriteLine("INGRESE 1 para cargar animación básica\n 2 Para animación completa");
                Console.ReadLine();
            }
        
    }
}
