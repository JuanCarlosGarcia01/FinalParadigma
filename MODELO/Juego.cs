using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Juego
    {
        public string TipoDePartida { get; set; }
        public string ResultadoPartida { get; set; }
        public int NumeroRandom { get; set; }
        public int CantidadIntentosRestantes { get; set; }
        public int CantidadIntentosRealizados { get; set; }

        public static Juego instancia;

        public static Juego Instancia()
        {
            if (instancia == null)
            {
                instancia = new Juego();
                return instancia;
            }
            return instancia;
        }
    }
}
