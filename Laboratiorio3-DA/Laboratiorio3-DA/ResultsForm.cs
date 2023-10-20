using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratiorio3_DA
{
    public partial class ResultsForm : Form
    {
        Jugador[] jugadores;
        private AmigoSecreto juegoAmigoSecreto;
        public int CantidadJugadores { get; set; }

        public ResultsForm()
        {
            InitializeComponent();
            
        }

        //sofia creo este metodo
        public void SetJugadores(Jugador[] jugadores)
        {
            this.jugadores = jugadores;
            this.juegoAmigoSecreto = new AmigoSecreto(jugadores.Length);
            this.juegoAmigoSecreto.AsignarJugadores(jugadores);
            this.juegoAmigoSecreto.AsignarAmigosSecretos();

            lstAsignaciones.Items.Clear();
            foreach (Jugador jugador in jugadores)
            {
                if (jugador != null)
                    lstAsignaciones.Items.Add(jugador);
            }
            MostrarRelaciones();
        }


        private void btnRegresarResultados_Click(object sender, EventArgs e)
        {
            PlayerConfigForm playerConfigForm = new PlayerConfigForm();
            playerConfigForm.Show();
            this.Close();
        }

        private void btnCalcularDias_Click(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = dtpFecha.Value;
            try
            {
                int diasRestantes = juegoAmigoSecreto.CalcularDiasProximaEndulzada(fechaSeleccionada);
                MessageBox.Show($"Días restantes hasta la próxima endulzada: {diasRestantes}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMostrarGustos_Click(object sender, EventArgs e)
        {
            Jugador jugadorSeleccionado = (Jugador)lstAsignaciones.SelectedItem;
            if (jugadorSeleccionado != null)
            {
                MessageBox.Show(jugadorSeleccionado.mostrarJugador());
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un jugador.");
            }
        }

        public void lstAsignaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MostrarRelaciones();
        }

        private void MostrarRelaciones()
        {
            if (juegoAmigoSecreto.Jugadores == null || juegoAmigoSecreto.Jugadores.Length == 0)
            {
                label2.Text = "No hay jugadores asignados.";
                return;
            }

            StringBuilder relaciones = new StringBuilder();
            foreach (Jugador jugador in juegoAmigoSecreto.Jugadores)
            {
                if (jugador != null && jugador.AmigoSecreto != null) // Asegurarte que tanto el jugador como su amigo secreto no son null
                    relaciones.AppendLine($"{jugador.Nombre}: {jugador.AmigoSecreto.Nombre}");
            }

            label2.Text = relaciones.ToString();
        }
    }
}
