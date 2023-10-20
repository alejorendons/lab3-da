namespace Laboratiorio3_DA
{
    partial class GameConfigForm
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
            this.lblConfigTitulo = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.nudNumeroEndulzadas = new System.Windows.Forms.NumericUpDown();
            this.nudFrecuenciaEndulzadas = new System.Windows.Forms.NumericUpDown();
            this.txtValorEndulzada = new System.Windows.Forms.TextBox();
            this.txtValorRegalo = new System.Windows.Forms.TextBox();
            this.btnConfigurarJugadores = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEndulzadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrecuenciaEndulzadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConfigTitulo
            // 
            this.lblConfigTitulo.AutoSize = true;
            this.lblConfigTitulo.Location = new System.Drawing.Point(302, 27);
            this.lblConfigTitulo.Name = "lblConfigTitulo";
            this.lblConfigTitulo.Size = new System.Drawing.Size(152, 16);
            this.lblConfigTitulo.TabIndex = 0;
            this.lblConfigTitulo.Text = "Configuración del Juego";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(413, 57);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(268, 22);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(413, 103);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(268, 22);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // nudNumeroEndulzadas
            // 
            this.nudNumeroEndulzadas.Location = new System.Drawing.Point(300, 160);
            this.nudNumeroEndulzadas.Name = "nudNumeroEndulzadas";
            this.nudNumeroEndulzadas.Size = new System.Drawing.Size(154, 22);
            this.nudNumeroEndulzadas.TabIndex = 3;
            // 
            // nudFrecuenciaEndulzadas
            // 
            this.nudFrecuenciaEndulzadas.Location = new System.Drawing.Point(300, 222);
            this.nudFrecuenciaEndulzadas.Name = "nudFrecuenciaEndulzadas";
            this.nudFrecuenciaEndulzadas.Size = new System.Drawing.Size(154, 22);
            this.nudFrecuenciaEndulzadas.TabIndex = 4;
            // 
            // txtValorEndulzada
            // 
            this.txtValorEndulzada.Location = new System.Drawing.Point(300, 289);
            this.txtValorEndulzada.Name = "txtValorEndulzada";
            this.txtValorEndulzada.Size = new System.Drawing.Size(154, 22);
            this.txtValorEndulzada.TabIndex = 5;
            this.txtValorEndulzada.TextChanged += new System.EventHandler(this.txtValorEndulzada_TextChanged);
            // 
            // txtValorRegalo
            // 
            this.txtValorRegalo.Location = new System.Drawing.Point(300, 350);
            this.txtValorRegalo.Name = "txtValorRegalo";
            this.txtValorRegalo.Size = new System.Drawing.Size(154, 22);
            this.txtValorRegalo.TabIndex = 6;
            // 
            // btnConfigurarJugadores
            // 
            this.btnConfigurarJugadores.Location = new System.Drawing.Point(604, 367);
            this.btnConfigurarJugadores.Name = "btnConfigurarJugadores";
            this.btnConfigurarJugadores.Size = new System.Drawing.Size(94, 57);
            this.btnConfigurarJugadores.TabIndex = 7;
            this.btnConfigurarJugadores.Text = "Configurar Jugadores";
            this.btnConfigurarJugadores.UseVisualStyleBackColor = true;
            this.btnConfigurarJugadores.Click += new System.EventHandler(this.btnConfigurarJugadores_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(12, 383);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(94, 55);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fecha de fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Numero de endulzadas:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Frecuencia de endulzadas en dias: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor endulzadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor regalo:";
            // 
            // GameConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnConfigurarJugadores);
            this.Controls.Add(this.txtValorRegalo);
            this.Controls.Add(this.txtValorEndulzada);
            this.Controls.Add(this.nudFrecuenciaEndulzadas);
            this.Controls.Add(this.nudNumeroEndulzadas);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblConfigTitulo);
            this.Name = "GameConfigForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumeroEndulzadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrecuenciaEndulzadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConfigTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.NumericUpDown nudNumeroEndulzadas;
        private System.Windows.Forms.NumericUpDown nudFrecuenciaEndulzadas;
        private System.Windows.Forms.TextBox txtValorEndulzada;
        private System.Windows.Forms.TextBox txtValorRegalo;
        private System.Windows.Forms.Button btnConfigurarJugadores;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}