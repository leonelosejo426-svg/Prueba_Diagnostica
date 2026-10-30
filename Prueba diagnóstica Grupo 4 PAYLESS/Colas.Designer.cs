namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    partial class Colas
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
            this.btnTomarTurno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTurnoActual = new System.Windows.Forms.Label();
            this.lblClienteActual = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnLlamarSiguiente = new System.Windows.Forms.Button();
            this.btnVerSiguiente = new System.Windows.Forms.Button();
            this.lstColaEspera = new System.Windows.Forms.ListBox();
            this.lblTotalEspera = new System.Windows.Forms.Label();
            this.lblProximo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTomarTurno
            // 
            this.btnTomarTurno.FlatAppearance.BorderSize = 0;
            this.btnTomarTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTomarTurno.Location = new System.Drawing.Point(54, 156);
            this.btnTomarTurno.Name = "btnTomarTurno";
            this.btnTomarTurno.Size = new System.Drawing.Size(100, 31);
            this.btnTomarTurno.TabIndex = 0;
            this.btnTomarTurno.Text = "Tomar turno";
            this.btnTomarTurno.UseVisualStyleBackColor = true;
            this.btnTomarTurno.Click += new System.EventHandler(this.btnTomarTurno_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atención al cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registrar persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Turno en atención";
            // 
            // lblTurnoActual
            // 
            this.lblTurnoActual.AutoSize = true;
            this.lblTurnoActual.Location = new System.Drawing.Point(409, 103);
            this.lblTurnoActual.Name = "lblTurnoActual";
            this.lblTurnoActual.Size = new System.Drawing.Size(45, 19);
            this.lblTurnoActual.TabIndex = 4;
            this.lblTurnoActual.Text = "label4";
            // 
            // lblClienteActual
            // 
            this.lblClienteActual.AutoSize = true;
            this.lblClienteActual.Location = new System.Drawing.Point(409, 146);
            this.lblClienteActual.Name = "lblClienteActual";
            this.lblClienteActual.Size = new System.Drawing.Size(45, 19);
            this.lblClienteActual.TabIndex = 5;
            this.lblClienteActual.Text = "label5";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(54, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(252, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(54, 113);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(252, 26);
            this.txtMotivo.TabIndex = 7;
            // 
            // btnLlamarSiguiente
            // 
            this.btnLlamarSiguiente.FlatAppearance.BorderSize = 0;
            this.btnLlamarSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlamarSiguiente.Location = new System.Drawing.Point(397, 177);
            this.btnLlamarSiguiente.Name = "btnLlamarSiguiente";
            this.btnLlamarSiguiente.Size = new System.Drawing.Size(128, 31);
            this.btnLlamarSiguiente.TabIndex = 8;
            this.btnLlamarSiguiente.Text = "Llamar Siguiente";
            this.btnLlamarSiguiente.UseVisualStyleBackColor = true;
            this.btnLlamarSiguiente.Click += new System.EventHandler(this.btnLlamarSiguiente_Click);
            // 
            // btnVerSiguiente
            // 
            this.btnVerSiguiente.FlatAppearance.BorderSize = 0;
            this.btnVerSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSiguiente.Location = new System.Drawing.Point(531, 177);
            this.btnVerSiguiente.Name = "btnVerSiguiente";
            this.btnVerSiguiente.Size = new System.Drawing.Size(116, 31);
            this.btnVerSiguiente.TabIndex = 9;
            this.btnVerSiguiente.Text = "Ver quién sigue";
            this.btnVerSiguiente.UseVisualStyleBackColor = true;
            this.btnVerSiguiente.Click += new System.EventHandler(this.btnVerSiguiente_Click);
            // 
            // lstColaEspera
            // 
            this.lstColaEspera.FormattingEnabled = true;
            this.lstColaEspera.ItemHeight = 19;
            this.lstColaEspera.Location = new System.Drawing.Point(32, 193);
            this.lstColaEspera.Name = "lstColaEspera";
            this.lstColaEspera.Size = new System.Drawing.Size(353, 137);
            this.lstColaEspera.TabIndex = 10;
            // 
            // lblTotalEspera
            // 
            this.lblTotalEspera.AutoSize = true;
            this.lblTotalEspera.Location = new System.Drawing.Point(67, 357);
            this.lblTotalEspera.Name = "lblTotalEspera";
            this.lblTotalEspera.Size = new System.Drawing.Size(69, 19);
            this.lblTotalEspera.TabIndex = 11;
            this.lblTotalEspera.Text = "En espera";
            // 
            // lblProximo
            // 
            this.lblProximo.AutoSize = true;
            this.lblProximo.Location = new System.Drawing.Point(158, 357);
            this.lblProximo.Name = "lblProximo";
            this.lblProximo.Size = new System.Drawing.Size(63, 19);
            this.lblProximo.TabIndex = 12;
            this.lblProximo.Text = "Siguiente";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(67, 395);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(61, 19);
            this.lblMensaje.TabIndex = 13;
            this.lblMensaje.Text = "Mensaje";
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 423);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblProximo);
            this.Controls.Add(this.lblTotalEspera);
            this.Controls.Add(this.lstColaEspera);
            this.Controls.Add(this.btnVerSiguiente);
            this.Controls.Add(this.btnLlamarSiguiente);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblClienteActual);
            this.Controls.Add(this.lblTurnoActual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTomarTurno);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Colas";
            this.Text = "Colas Sistema de atención por turnos";
            this.Load += new System.EventHandler(this.Colas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTomarTurno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTurnoActual;
        private System.Windows.Forms.Label lblClienteActual;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnLlamarSiguiente;
        private System.Windows.Forms.Button btnVerSiguiente;
        private System.Windows.Forms.ListBox lstColaEspera;
        private System.Windows.Forms.Label lblTotalEspera;
        private System.Windows.Forms.Label lblProximo;
        private System.Windows.Forms.Label lblMensaje;
    }
}