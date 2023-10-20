namespace Laboratiorio3_DA
{
    partial class PlayerConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConfigJugadoresTitulo = new System.Windows.Forms.Label();
            this.btnGuardarJugadores = new System.Windows.Forms.Button();
            this.btnVerResultados = new System.Windows.Forms.Button();
            this.btnRegresarJugadores = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lalCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegaloIdeal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxEndulzada = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxRegalo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblConfigJugadoresTitulo
            // 
            this.lblConfigJugadoresTitulo.AutoSize = true;
            this.lblConfigJugadoresTitulo.Location = new System.Drawing.Point(311, 29);
            this.lblConfigJugadoresTitulo.Name = "lblConfigJugadoresTitulo";
            this.lblConfigJugadoresTitulo.Size = new System.Drawing.Size(176, 16);
            this.lblConfigJugadoresTitulo.TabIndex = 0;
            this.lblConfigJugadoresTitulo.Text = "Configuración de Jugadores";
            // 
            // btnGuardarJugadores
            // 
            this.btnGuardarJugadores.Location = new System.Drawing.Point(366, 311);
            this.btnGuardarJugadores.Name = "btnGuardarJugadores";
            this.btnGuardarJugadores.Size = new System.Drawing.Size(98, 47);
            this.btnGuardarJugadores.TabIndex = 3;
            this.btnGuardarJugadores.Text = "Guardar Jugador";
            this.btnGuardarJugadores.UseVisualStyleBackColor = true;
            this.btnGuardarJugadores.Click += new System.EventHandler(this.btnGuardarJugadores_Click);
            // 
            // btnVerResultados
            // 
            this.btnVerResultados.Location = new System.Drawing.Point(663, 376);
            this.btnVerResultados.Name = "btnVerResultados";
            this.btnVerResultados.Size = new System.Drawing.Size(90, 49);
            this.btnVerResultados.TabIndex = 4;
            this.btnVerResultados.Text = "Ver Resultados";
            this.btnVerResultados.UseVisualStyleBackColor = true;
            this.btnVerResultados.Click += new System.EventHandler(this.btnVerResultados_Click);
            // 
            // btnRegresarJugadores
            // 
            this.btnRegresarJugadores.Location = new System.Drawing.Point(12, 363);
            this.btnRegresarJugadores.Name = "btnRegresarJugadores";
            this.btnRegresarJugadores.Size = new System.Drawing.Size(132, 75);
            this.btnRegresarJugadores.TabIndex = 5;
            this.btnRegresarJugadores.Text = "Regresar";
            this.btnRegresarJugadores.UseVisualStyleBackColor = true;
            this.btnRegresarJugadores.Click += new System.EventHandler(this.btnRegresarJugadores_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(170, 132);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre:";
            // 
            // lalCorreo
            // 
            this.lalCorreo.AutoSize = true;
            this.lalCorreo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lalCorreo.Location = new System.Drawing.Point(170, 172);
            this.lalCorreo.Name = "lalCorreo";
            this.lalCorreo.Size = new System.Drawing.Size(51, 16);
            this.lalCorreo.TabIndex = 7;
            this.lalCorreo.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(375, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 8;
            // 
            // lblRegaloIdeal
            // 
            this.lblRegaloIdeal.AutoSize = true;
            this.lblRegaloIdeal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblRegaloIdeal.Location = new System.Drawing.Point(170, 260);
            this.lblRegaloIdeal.Name = "lblRegaloIdeal";
            this.lblRegaloIdeal.Size = new System.Drawing.Size(88, 16);
            this.lblRegaloIdeal.TabIndex = 9;
            this.lblRegaloIdeal.Text = "Regalo ideal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(170, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Endulzada ideal:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(283, 129);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(316, 22);
            this.textBoxNombre.TabIndex = 11;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxEndulzada
            // 
            this.textBoxEndulzada.Location = new System.Drawing.Point(283, 169);
            this.textBoxEndulzada.Name = "textBoxEndulzada";
            this.textBoxEndulzada.Size = new System.Drawing.Size(316, 22);
            this.textBoxEndulzada.TabIndex = 12;
            this.textBoxEndulzada.TextChanged += new System.EventHandler(this.textBoxEndulzada_TextChanged);
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(283, 211);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(316, 22);
            this.textBoxCorreo.TabIndex = 13;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // textBoxRegalo
            // 
            this.textBoxRegalo.Location = new System.Drawing.Point(283, 260);
            this.textBoxRegalo.Name = "textBoxRegalo";
            this.textBoxRegalo.Size = new System.Drawing.Size(316, 22);
            this.textBoxRegalo.TabIndex = 14;
            this.textBoxRegalo.TextChanged += new System.EventHandler(this.textBoxRegalo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ingrese la cantidad de jugadores:";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(383, 73);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(81, 22);
            this.textBoxCantidad.TabIndex = 16;
            this.textBoxCantidad.TextChanged += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // PlayerConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRegalo);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.textBoxEndulzada);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRegaloIdeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lalCorreo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnRegresarJugadores);
            this.Controls.Add(this.btnVerResultados);
            this.Controls.Add(this.btnGuardarJugadores);
            this.Controls.Add(this.lblConfigJugadoresTitulo);
            this.Name = "PlayerConfigForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerConfigForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfigJugadoresTitulo;
        private System.Windows.Forms.Button btnGuardarJugadores;
        private System.Windows.Forms.Button btnVerResultados;
        private System.Windows.Forms.Button btnRegresarJugadores;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lalCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegaloIdeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxEndulzada;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxRegalo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCantidad;
    }
}