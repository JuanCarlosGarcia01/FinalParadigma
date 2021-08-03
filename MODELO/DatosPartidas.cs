using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class DatosPartidas
    {
        public static DatosPartidas instancia;

        public static DatosPartidas Instancia()
        {
            if (instancia == null)
            {
                instancia = new DatosPartidas();
                return instancia;
            }
            return instancia;
        }

        public DatosPartidas()
        {
            ListaPartidaJugadas = new List<DatosPartidas>();
        }

        public List<DatosPartidas> ListaPartidaJugadas { get; set; }
    }
}
