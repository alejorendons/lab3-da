using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laboratiorio3_DA
{


    public partial class PlayerConfigForm : Form
    {
        
        private Jugador[] jugadores;
        private int indiceActual = 0;
        private int cantidadJugadores;




        public PlayerConfigForm()
        {
            InitializeComponent();
            

        }

        public void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            // Abre el formulario ResultsForm y esconde el PlayerConfigForm
            ResultsForm resultsForm = new ResultsForm();

            resultsForm.CantidadJugadores = int.Parse(textBoxCantidad.Text);
            //sofia
            resultsForm.SetJugadores(jugadores);
            resultsForm.Show();
            this.Hide();
        }

        private void btnRegresarJugadores_Click(object sender, EventArgs e)
        {
            // Abre el GameConfigForm y cierra el PlayerConfigForm
            GameConfigForm gameConfigForm = new GameConfigForm();
            gameConfigForm.Show();
            this.Close();
        }

        private void btnGuardarJugadores_Click(object sender, EventArgs e)
        {
            if (indiceActual >= jugadores.Length)
            {
                MessageBox.Show("Has alcanzado el número máximo de jugadores.");
                return;
            }
            string nombre = textBoxNombre.Text;
            string correo = textBoxCorreo.Text;
            string endulzadaIdeal = textBoxEndulzada.Text;
            string regaloIdeal = textBoxRegalo.Text;

            // Crear una instancia de Jugador y agregarlo a la lista
            Jugador nuevoJugador = new Jugador(nombre, correo, endulzadaIdeal, regaloIdeal);
            jugadores[indiceActual] = nuevoJugador;
            indiceActual++;

            // Limpiar los TextBoxes para el siguiente jugador
            textBoxNombre.Clear();
            textBoxCorreo.Clear();
            textBoxEndulzada.Clear();
            textBoxRegalo.Clear();

            MessageBox.Show("Jugador guardado correctamente.");


            
        }

        private void PlayerConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEndulzada_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRegalo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCantidad_TextChanged(object sender, EventArgs e)
        {
            int cantidadJugadores;

            if (int.TryParse(textBoxCantidad.Text, out int numJugadores))
            {
                jugadores = new Jugador[numJugadores];
                indiceActual = 0;
                cantidadJugadores = numJugadores;
                
            }
            else
            {
                
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }

        

    }
}
