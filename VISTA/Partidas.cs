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
    public partial class Partidas : Form
    {
        MODELO.Juego jUEGO;
        MODELO.DatosPartidas dATOSPARTIDA;

        private static readonly Random _random = new Random();
        public int numero = _random.Next(0, 101);

        int creditos;
        int intentos;

        int numeroComputador;
        int miNumero;

        public Partidas()
        {
            InitializeComponent();
            numeroRandom();
            Reset();

            cambioResultado();

            dATOSPARTIDA = MODELO.DatosPartidas.Instancia();
            jUEGO = new MODELO.Juego();
        }

        public void numeroRandom()
        {

            lbNumeroRandom.Text = Convert.ToString(numero);
        }

        public void Reset()
        {
            jUEGO = new MODELO.Juego();

            intentos = 0;
            creditos = 10;
            numero = _random.Next(0, 101);

            ActualizarDatos();
        }

        public void cambioResultado()
        {
            gpMiNumero.Enabled = true;
            gpCaracteristicas.Enabled = false;
        }

        public void cambioAdivinar()
        {
            gpMiNumero.Enabled = false;
            gpCaracteristicas.Enabled = true;
        }

        public void ActualizarDatos()
        {
            numerosIntentos.Text = "Intentos: "  + intentos.ToString();
            numeroCreditos.Text = "Creditos: " + creditos.ToString();
            txtMiNumero.Text = null;
            cambioResultado();
            
        }

        public void AgregarDatosGrilla()
        {
            jUEGO.TipoDePartida = MODELO.Juego.Instancia().TipoDePartida;
            jUEGO.NumeroRandom = numero;
            jUEGO.CantidadIntentosRestantes = intentos;
            jUEGO.CantidadIntentosRealizados = creditos;

            dATOSPARTIDA.ListaPartidaJugadas.Add(dATOSPARTIDA);
        }

        public void CasoPerder()
        {
            if (creditos <= 0)
            {
                jUEGO.ResultadoPartida = "Perdiste";
                AgregarDatosGrilla();

                DialogResult opcion = MessageBox.Show("Juego Terminado, ¿Desea volver a jugar?", "Importante", MessageBoxButtons.YesNo);
                if (opcion == DialogResult.Yes)
                {
                    Reset();
                    ActualizarDatos();
                    numeroRandom();
                }
                else if (opcion == DialogResult.No)
                {
                    this.Close();
                }
            }
        }   

        public void casoGanar()
        {

            if (numeroComputador == miNumero)
            {
                DialogResult opcion = MessageBox.Show("Juego Terminado, ¿Desea volver a jugar?", "Importante", MessageBoxButtons.YesNo);
                if (opcion == DialogResult.Yes)
                {
                    Reset();
                    ActualizarDatos();
                    numeroRandom();
                }

                if (opcion == DialogResult.No)
                {
                    this.Close();
                }
            }
        }


        private void btnAbandonar_Click(object sender, EventArgs e)
        {
            DialogResult opción = MessageBox.Show("Esto contara como haber perdido", "¿Seguro que quiere realizar esta accion?", MessageBoxButtons.YesNo);

            if (opción == DialogResult.Yes)
            {
                this.Close();
                jUEGO.ResultadoPartida = "Perdiste";
                AgregarDatosGrilla();
                CasoPerder();
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {


            if (!int.TryParse(txtMiNumero.Text, out miNumero))
            {
                MessageBox.Show("Ingrese un numero");
                return;
            }
            else if (miNumero > 100)
            {
                MessageBox.Show("Ingrese un numero menor a 100");
                return;
            }
            else if (miNumero < 0)
            {
                MessageBox.Show("Ingrese un numero mayor a cero");
                return;
            }

            if (miNumero == numeroComputador)
            {
                DialogResult opcion = MessageBox.Show("Juego Terminado, ¿Desea volver a jugar?", "Importante", MessageBoxButtons.YesNo);
                if (opcion == DialogResult.Yes)
                {
                    Reset();
                }

                if (opcion == DialogResult.No)
                {
                    this.Close();
                }
            }
            else
            {
                intentos++;
                creditos -= 5;
                ActualizarDatos();
            }

            //miNumero = Convert.ToInt32(txtMiNumero.Text);
            cambioAdivinar();
            CasoPerder();
            
        }   
        private void btnVolverAIntentar_Click(object sender, EventArgs e)
            {
                
                cambioResultado();
            }
        }
    }


