using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class Menú : Form
    {
        MODELO.Juego jUEGO;

        public Menú()
        {
            InitializeComponent();
            jUEGO = MODELO.Juego.Instancia();
        }

        private void btnConAyuda_Click(object sender, EventArgs e)
        {
            Form partida = new Partidas();
            partida.Show();
            jUEGO.TipoDePartida = "Con ayuda";
            partida.Text = "Partida con ayuda";
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form partida = new Historial();
            partida.Show();
        }

        private void btnSinAyuda_Click(object sender, EventArgs e)
        {
            Form partida = new Partidas();
            partida.Show();
            jUEGO.TipoDePartida = "Sin ayuda";
            partida.Text = "Partida sin ayuda";
        }
    }
}
