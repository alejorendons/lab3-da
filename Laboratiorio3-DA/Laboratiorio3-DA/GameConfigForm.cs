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
    public partial class GameConfigForm : Form
    {
        public GameConfigForm()
        {
            InitializeComponent();
        }

        private void btnConfigurarJugadores_Click(object sender, EventArgs e)
        {
            PlayerConfigForm playerConfig = new PlayerConfigForm();
            playerConfig.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void GameConfigForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtValorEndulzada_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
