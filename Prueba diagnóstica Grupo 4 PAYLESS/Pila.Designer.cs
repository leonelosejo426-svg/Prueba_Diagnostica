namespace Prueba_diagnóstica_Grupo_4_PAYLESS
{
    partial class Pila
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnVisitar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnVerCima = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtPaginaActual = new System.Windows.Forms.TextBox();
            this.lstContenidoPila = new System.Windows.Forms.ListBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mi navegador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nueva dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Página actual";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(41, 104);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(220, 26);
            this.txtDireccion.TabIndex = 3;
            // 
            // btnVisitar
            // 
            this.btnVisitar.FlatAppearance.BorderSize = 0;
            this.btnVisitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitar.Location = new System.Drawing.Point(41, 148);
            this.btnVisitar.Name = "btnVisitar";
            this.btnVisitar.Size = new System.Drawing.Size(100, 29);
            this.btnVisitar.TabIndex = 4;
            this.btnVisitar.Text = "Visitar / Push";
            this.btnVisitar.UseVisualStyleBackColor = true;
            this.btnVisitar.Click += new System.EventHandler(this.btnVisitar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(146, 148);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(100, 29);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás / Pop";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnVerCima
            // 
            this.btnVerCima.FlatAppearance.BorderSize = 0;
            this.btnVerCima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCima.Location = new System.Drawing.Point(245, 148);
            this.btnVerCima.Name = "btnVerCima";
            this.btnVerCima.Size = new System.Drawing.Size(114, 29);
            this.btnVerCima.TabIndex = 6;
            this.btnVerCima.Text = "Ver cima / Peek";
            this.btnVerCima.UseVisualStyleBackColor = true;
            this.btnVerCima.Click += new System.EventHandler(this.btnVerCima_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Location = new System.Drawing.Point(41, 183);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 29);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar historial";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtPaginaActual
            // 
            this.txtPaginaActual.Location = new System.Drawing.Point(419, 104);
            this.txtPaginaActual.Name = "txtPaginaActual";
            this.txtPaginaActual.Size = new System.Drawing.Size(188, 26);
            this.txtPaginaActual.TabIndex = 8;
            // 
            // lstContenidoPila
            // 
            this.lstContenidoPila.FormattingEnabled = true;
            this.lstContenidoPila.ItemHeight = 19;
            this.lstContenidoPila.Location = new System.Drawing.Point(47, 236);
            this.lstContenidoPila.Name = "lstContenidoPila";
            this.lstContenidoPila.Size = new System.Drawing.Size(437, 175);
            this.lstContenidoPila.TabIndex = 9;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(37, 443);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(61, 19);
            this.lblMensaje.TabIndex = 10;
            this.lblMensaje.Text = "Mensaje";
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 505);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lstContenidoPila);
            this.Controls.Add(this.txtPaginaActual);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnVerCima);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnVisitar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Pila";
            this.Text = "Pila HISTORIAL WEB ";
            this.Load += new System.EventHandler(this.Pila_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnVisitar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnVerCima;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtPaginaActual;
        private System.Windows.Forms.ListBox lstContenidoPila;
        private System.Windows.Forms.Label lblMensaje;
    }
}