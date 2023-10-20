namespace Laboratiorio3_DA
{
    partial class ResultsForm
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
            this.lblTituloResultados = new System.Windows.Forms.Label();
            this.lstAsignaciones = new System.Windows.Forms.ListBox();
            this.btnMostrarGustos = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCalcularDias = new System.Windows.Forms.Button();
            this.btnRegresarResultados = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloResultados
            // 
            this.lblTituloResultados.AutoSize = true;
            this.lblTituloResultados.Location = new System.Drawing.Point(253, 38);
            this.lblTituloResultados.Name = "lblTituloResultados";
            this.lblTituloResultados.Size = new System.Drawing.Size(250, 16);
            this.lblTituloResultados.TabIndex = 0;
            this.lblTituloResultados.Text = "Resultados del Juego de Amigo Secreto";
            // 
            // lstAsignaciones
            // 
            this.lstAsignaciones.FormattingEnabled = true;
            this.lstAsignaciones.ItemHeight = 16;
            this.lstAsignaciones.Location = new System.Drawing.Point(32, 96);
            this.lstAsignaciones.Name = "lstAsignaciones";
            this.lstAsignaciones.Size = new System.Drawing.Size(132, 68);
            this.lstAsignaciones.TabIndex = 1;
            this.lstAsignaciones.SelectedIndexChanged += new System.EventHandler(this.lstAsignaciones_SelectedIndexChanged);
            // 
            // btnMostrarGustos
            // 
            this.btnMostrarGustos.Location = new System.Drawing.Point(317, 228);
            this.btnMostrarGustos.Name = "btnMostrarGustos";
            this.btnMostrarGustos.Size = new System.Drawing.Size(92, 55);
            this.btnMostrarGustos.TabIndex = 2;
            this.btnMostrarGustos.Text = "Mostrar Gustos";
            this.btnMostrarGustos.UseVisualStyleBackColor = true;
            this.btnMostrarGustos.Click += new System.EventHandler(this.btnMostrarGustos_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(484, 219);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(265, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnCalcularDias
            // 
            this.btnCalcularDias.Location = new System.Drawing.Point(504, 279);
            this.btnCalcularDias.Name = "btnCalcularDias";
            this.btnCalcularDias.Size = new System.Drawing.Size(111, 67);
            this.btnCalcularDias.TabIndex = 4;
            this.btnCalcularDias.Text = "Calcular Dias";
            this.btnCalcularDias.UseVisualStyleBackColor = true;
            this.btnCalcularDias.Click += new System.EventHandler(this.btnCalcularDias_Click);
            // 
            // btnRegresarResultados
            // 
            this.btnRegresarResultados.Location = new System.Drawing.Point(108, 321);
            this.btnRegresarResultados.Name = "btnRegresarResultados";
            this.btnRegresarResultados.Size = new System.Drawing.Size(75, 56);
            this.btnRegresarResultados.TabIndex = 5;
            this.btnRegresarResultados.Text = "Regresar";
            this.btnRegresarResultados.UseVisualStyleBackColor = true;
            this.btnRegresarResultados.Click += new System.EventHandler(this.btnRegresarResultados_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegresarResultados);
            this.Controls.Add(this.btnCalcularDias);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnMostrarGustos);
            this.Controls.Add(this.lstAsignaciones);
            this.Controls.Add(this.lblTituloResultados);
            this.Name = "ResultsForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultsForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloResultados;
        private System.Windows.Forms.ListBox lstAsignaciones;
        private System.Windows.Forms.Button btnMostrarGustos;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCalcularDias;
        private System.Windows.Forms.Button btnRegresarResultados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}